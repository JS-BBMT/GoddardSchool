using Abp.Application.Features;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using FranchiseePortal.Features;
using FranchiseePortal.FeaturesWebApiClient.Api;
using FranchiseePortal.LeadsEditor.Dtos;
using FranchiseePortal.LeadsWebApiClient.Api;
using FranchiseePortal.LeadsWebApiClient.Model;
using FranchiseePortal.SchoolsWebApiClient.Api;
using FranchiseePortal.ToursEditor.Dtos;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FranchiseePortal.ToursEditor
{
    [RequiresFeature(AppFeatures.TourFeature)]
    public class ToursEditorService : FranchiseePortalAppServiceBase, IToursEditorService
    {
        #region Variables
        // Customized client by Swagger
        private readonly IToursApi _toursClient;
        private readonly IGuidesApi _guidesClient;
        private readonly ISchoolParentLeadsApi _leadsClient;
        private readonly ISchoolsApi _schoolsApi;
        private readonly IScheduleApi _scheduleApi;
        #endregion

        //========================================================================================

        #region Constructor
        public ToursEditorService(
            IToursApi toursClient,
            ISchoolParentLeadsApi leadsClient,
            ISchoolsApi schoolsApi,
            IGuidesApi guidesApi,
            IScheduleApi scheduleApi)
        {
            _toursClient = toursClient;
            _leadsClient = leadsClient;
            _schoolsApi = schoolsApi;
            _guidesClient = guidesApi;
            _scheduleApi = scheduleApi;
        }

        #endregion

        //========================================================================================

        #region Endpoints

        [HttpGet]
        public async Task<PagedResultDto<TourItemDto>> FindTours(FindToursInput input)
        {
            if (!await AuthorizeForSchoolAsync(input.SchoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            // Fetch tours data
            var toursSearchResult = await _toursClient.ApiV1ToursGetAsync(input.SchoolId, input.Status, input.StartDate, input.EndDate, input.Type, input.GuideName);

            List<LeadDto> leads = new List<LeadDto>();
            if (input.HasAdvancedLeadFilters())
            {
                var school = await _schoolsApi.ApiV1SchoolsIdGetAsync(input.SchoolId);

                // Fetch leads data using advanced filters only (empty query)
                leads = (await _leadsClient.ApiV1SchoolLeadsGetAsync(
                    long.Parse(school.FmsId), null, input.LeadName, input.ChildAge,
                    input.LeadStartDate, input.LeadEndDate, input.ProgramsOfInterest,
                    1, int.MaxValue)).Items;
            }
            else
            {
                var leadIds = toursSearchResult.Items
                    .Select(x => x.LeadId)
                    .Distinct()
                    .ToList();

                leads = (await _leadsClient.ApiV1SchoolLeadsQueryByIdsPostAsync(leadIds))
                    .ToList();

                if (leadIds.Count > leads.Count)
                {
                    Logger.WarnFormat("Expected {expected}, but received {actual} leads",
                            leadIds.Count,
                            leads.Count);
                }
            }

            // Join tours and leads on lead ID and map to TourDto
            var items = toursSearchResult.Items.Join(
                leads,
                outer => outer.LeadId,
                inner => inner.SchoolParentLeadId.ToString(),
                (tour, lead) => CreateTourItemDto(tour, lead))
                .ToList();

            var result = new PagedResultDto<TourItemDto>(toursSearchResult.Total, items);
            return result;
        }

        [HttpGet]
        public async Task<List<TourGuideDto>> GetSchoolGuides(string crmId)
       {
            if (!await AuthorizeForSchoolAsync(crmId))
            {
                throw new AbpAuthorizationException("User is not authorized to access school");
            }

            var result = await _guidesClient.ApiV1GuidesGetAsync(crmId);

            return result;
        }

        public async Task CreateTour(CreateTourInput tourDto)
        {
            if (!await AuthorizeForSchoolAsync(tourDto.SchoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            var tour = CreateTourInput.CreateTourDto(tourDto);

            var result = await _toursClient.ApiV1ToursPostAsync(tour);
        }

        public async Task UpdateTour(string id, UpdateTourInput tourDto)
        {
            if (!await AuthorizeForSchoolAsync(tourDto.SchoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            var tour = await _toursClient.ApiV1ToursIdGetAsync(id);
            var leadUpdate = UpdateLeadInput.CreateLeadUpdateRequest(tourDto.Lead);

            //Update lead
            await _leadsClient.ApiV1SchoolLeadsIdTourPutAsync(tourDto.Lead.GuidId, leadUpdate);


            UpdateTourInput.UpdateTourFields(tourDto, tour);

            //Update Tour
            await _toursClient.ApiV1ToursIdPutAsync(id, tour);
        }

        public async Task<ScheduleDto> GetSchedule(string schoolId, DateTime? startDate, DateTime? endDate)
        {
            if (!await AuthorizeForSchoolAsync(schoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to access school");
            }

            var result = await _scheduleApi.ApiV1ScheduleSchoolIdGetAsync(schoolId, startDate, endDate);
            
            return result;
        }

        #endregion

        //========================================================================================

        private TourItemDto CreateTourItemDto(TourDto tour, LeadDto lead)
        {
            // Map tour and lead to DTO
            var dto = ObjectMapper.Map<TourItemDto>(tour);
            dto.Lead = ObjectMapper.Map<TourItemLeadDto>(lead);

            return dto;
        }
    }
}
