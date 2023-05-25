using Abp.UI;
using FranchiseePortal.CareersWebApiClient.Api;
using FranchiseePortal.CareersWebApiClient.Model;
using System.Threading.Tasks;

namespace FranchiseePortal.CareersEditor
{
    public class CareersEditorService : FranchiseePortalAppServiceBase, ICareersEditorService
    {
        #region Variables
        // Customized client by Swagger
        private readonly ICareersApi _client;

        #endregion

        //========================================================================================

        #region Constructor
        public CareersEditorService(ICareersApi client)
        {
            _client = client;
        }
        #endregion

        //========================================================================================
        
        #region public Endpoints
        public async Task<Career> DeleteCareer(long careerId)
        {
            return await _client.ApiV1CareersCareerIdDeleteAsync(careerId);
        }

        public async Task<Career> SaveCareer(Career career)
        {
            try
            {
                return await _client.ApiV1CareersPostAsync(career);
            }
            catch (System.Exception ex)
            {
                if (ex.Message.Contains("Cannot insert duplicate key", System.StringComparison.OrdinalIgnoreCase))
                {
                    throw new UserFriendlyException(400, L("PostingCareerExistsErrorMessage"));
                }

                throw;
            }
        }
        #endregion
    }
}
