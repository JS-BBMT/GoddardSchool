using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using Abp.Linq.Extensions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using FranchiseePortal.ResourceLinks.Exporting;
using FranchiseePortal.ResourceLinks.Dtos;
using FranchiseePortal.Dto;
using Abp.Application.Services.Dto;
using FranchiseePortal.Authorization;
using Abp.Extensions;
using Abp.Authorization;
using Microsoft.EntityFrameworkCore;
using Abp.UI;
using FranchiseePortal.Storage;

namespace FranchiseePortal.ResourceLinks
{
    [AbpAuthorize(AppPermissions.Pages_Administration_ResourceLinks)]
    public class ResourceLinksAppService : FranchiseePortalAppServiceBase, IResourceLinksAppService
    {
        private readonly IRepository<ResourceLink> _resourceLinkRepository;
        private readonly IResourceLinksExcelExporter _resourceLinksExcelExporter;

        public ResourceLinksAppService(IRepository<ResourceLink> resourceLinkRepository, IResourceLinksExcelExporter resourceLinksExcelExporter)
        {
            _resourceLinkRepository = resourceLinkRepository;
            _resourceLinksExcelExporter = resourceLinksExcelExporter;
        }

        public async Task<PagedResultDto<GetResourceLinkForViewDto>> GetAll(GetAllResourceLinksInput input)
        {
            var filteredResourceLinks = _resourceLinkRepository.GetAll()
                        .WhereIf(!string.IsNullOrWhiteSpace(input.Filter), e => false || e.Text.Contains(input.Filter) || e.Url.Contains(input.Filter) || e.Icon.Contains(input.Filter))
                        .WhereIf(!string.IsNullOrWhiteSpace(input.TextFilter), e => e.Text == input.TextFilter)
                        .WhereIf(!string.IsNullOrWhiteSpace(input.UrlFilter), e => e.Url == input.UrlFilter)
                        .WhereIf(!string.IsNullOrWhiteSpace(input.IconFilter), e => e.Icon == input.IconFilter);

            var pagedAndFilteredResourceLinks = filteredResourceLinks
                .OrderBy(input.Sorting ?? "id asc")
                .PageBy(input);

            var resourceLinks = from o in pagedAndFilteredResourceLinks
                                select new
                                {
                                    o.Text,
                                    o.Url,
                                    o.Icon,
                                    o.IsExternal,
                                    Id = o.Id
                                };

            var totalCount = await filteredResourceLinks.CountAsync();

            var dbList = await resourceLinks.ToListAsync();
            var results = new List<GetResourceLinkForViewDto>();

            foreach (var o in dbList)
            {
                var res = new GetResourceLinkForViewDto()
                {
                    ResourceLink = new ResourceLinkDto
                    {

                        Text = o.Text,
                        Url = o.Url,
                        Icon = o.Icon,
                        IsExternal = o.IsExternal,
                        Id = o.Id,
                    }
                };

                results.Add(res);
            }

            return new PagedResultDto<GetResourceLinkForViewDto>(
                totalCount,
                results
            );

        }

        public async Task<GetResourceLinkForViewDto> GetResourceLinkForView(int id)
        {
            var resourceLink = await _resourceLinkRepository.GetAsync(id);

            var output = new GetResourceLinkForViewDto { ResourceLink = ObjectMapper.Map<ResourceLinkDto>(resourceLink) };

            return output;
        }

        [AbpAuthorize(AppPermissions.Pages_Administration_ResourceLinks_Edit)]
        public async Task<GetResourceLinkForEditOutput> GetResourceLinkForEdit(EntityDto input)
        {
            var resourceLink = await _resourceLinkRepository.FirstOrDefaultAsync(input.Id);

            var output = new GetResourceLinkForEditOutput { ResourceLink = ObjectMapper.Map<CreateOrEditResourceLinkDto>(resourceLink) };

            return output;
        }

        public async Task CreateOrEdit(CreateOrEditResourceLinkDto input)
        {
            if (input.Id == null)
            {
                await Create(input);
            }
            else
            {
                await Update(input);
            }
        }

        [AbpAuthorize(AppPermissions.Pages_Administration_ResourceLinks_Create)]
        protected virtual async Task Create(CreateOrEditResourceLinkDto input)
        {
            var resourceLink = ObjectMapper.Map<ResourceLink>(input);

            await _resourceLinkRepository.InsertAsync(resourceLink);

        }

        [AbpAuthorize(AppPermissions.Pages_Administration_ResourceLinks_Edit)]
        protected virtual async Task Update(CreateOrEditResourceLinkDto input)
        {
            var resourceLink = await _resourceLinkRepository.FirstOrDefaultAsync((int)input.Id);
            ObjectMapper.Map(input, resourceLink);

        }

        [AbpAuthorize(AppPermissions.Pages_Administration_ResourceLinks_Delete)]
        public async Task Delete(EntityDto input)
        {
            await _resourceLinkRepository.DeleteAsync(input.Id);
        }

        public async Task<FileDto> GetResourceLinksToExcel(GetAllResourceLinksForExcelInput input)
        {
            var filteredResourceLinks = _resourceLinkRepository.GetAll()
                        .WhereIf(!string.IsNullOrWhiteSpace(input.Filter), e => false || e.Text.Contains(input.Filter) || e.Url.Contains(input.Filter) || e.Icon.Contains(input.Filter))
                        .WhereIf(!string.IsNullOrWhiteSpace(input.TextFilter), e => e.Text == input.TextFilter)
                        .WhereIf(!string.IsNullOrWhiteSpace(input.UrlFilter), e => e.Url == input.UrlFilter)
                        .WhereIf(!string.IsNullOrWhiteSpace(input.IconFilter), e => e.Icon == input.IconFilter);

            var query = (from o in filteredResourceLinks
                         select new GetResourceLinkForViewDto()
                         {
                             ResourceLink = new ResourceLinkDto
                             {
                                 Text = o.Text,
                                 Url = o.Url,
                                 Icon = o.Icon,
                                 IsExternal = o.IsExternal,
                                 Id = o.Id
                             }
                         });

            var resourceLinkListDtos = await query.ToListAsync();

            return _resourceLinksExcelExporter.ExportToFile(resourceLinkListDtos);
        }

    }
}