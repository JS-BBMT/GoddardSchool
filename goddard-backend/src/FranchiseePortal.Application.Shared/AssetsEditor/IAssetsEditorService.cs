using System.Threading.Tasks;
using FranchiseePortal.AssetsEditor.Dtos;
using FranchiseePortal.ContentWebApiClient.Model;
using Microsoft.AspNetCore.Http;

namespace FranchiseePortal.AssetsEditor
{
    public interface IAssetsEditorService
    {
        Task<InitiateUploadResponse> InitiateUpload(InitiateUploadDto input);

        Task<CompleteUploadResponse> CompleteUpload(CompleteUploadDto input);

        Task DeleteAsset(string crmId, string path, string filename);
    }
}
