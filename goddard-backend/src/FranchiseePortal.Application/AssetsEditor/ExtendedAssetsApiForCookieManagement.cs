using System;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.ContentWebApiClient.Client;
using FranchiseePortal.ContentWebApiClient.Model;

namespace FranchiseePortal.AssetsEditor
{
    public class ExtendedAssetsApiForCookieManagement : AssetsApi, IExtendedAssetsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedAssetsApiForCookieManagement"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        /// <remarks>
        /// 20220707RBP - FIX #15672: Need this constructor so that Configuration can be properly injected by DI
        /// </remarks>
        public ExtendedAssetsApiForCookieManagement(ContentWebApiClient.Client.Configuration configuration) : base(configuration)
        {
        }

        public async
            System.Threading.Tasks.Task<
                FranchiseePortal.ContentWebApiClient.Client.ApiResponse<CompleteUploadResponse>>
            ApiV1DcpAssetsCompleteUploadGetWithHttpInfoAsync(
                string path = default(string),
                string uploadToken = default(string),
                string fileName = default(string),
                string mimeType = default(string),
                string affinity = default(string),
                System.Threading.CancellationToken cancellationToken =
                    default(System.Threading.CancellationToken))
        {
            FranchiseePortal.ContentWebApiClient.Client.RequestOptions localVarRequestOptions = new FranchiseePortal.ContentWebApiClient.Client.RequestOptions();
            
            localVarRequestOptions.Operation = "AssetsApi.ApiV1DcpAssetsCompleteUploadGet";
            localVarRequestOptions.Cookies.Add(new System.Net.Cookie("affinity", affinity));

            String[] _contentTypes = new String[] {
                };

            // to determine the Accept header
            String[] _accepts = new String[] {
                    "text/plain",
                    "application/json",
                    "text/json"
                };

            var localVarContentType =
                FranchiseePortal.ContentWebApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept =
                FranchiseePortal.ContentWebApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (path != null)
            {
                localVarRequestOptions.QueryParameters.Add(
                    FranchiseePortal.ContentWebApiClient.Client.ClientUtils.ParameterToMultiMap("", "path", path));
            }

            if (uploadToken != null)
            {
                localVarRequestOptions.QueryParameters.Add(
                    FranchiseePortal.ContentWebApiClient.Client.ClientUtils.ParameterToMultiMap("", "uploadToken",
                        uploadToken));
            }

            if (fileName != null)
            {
                localVarRequestOptions.QueryParameters.Add(
                    FranchiseePortal.ContentWebApiClient.Client.ClientUtils.ParameterToMultiMap("", "fileName",
                        fileName));
            }

            if (mimeType != null)
            {
                localVarRequestOptions.QueryParameters.Add(
                    FranchiseePortal.ContentWebApiClient.Client.ClientUtils.ParameterToMultiMap("", "mimeType",
                        mimeType));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient
                .GetAsync<CompleteUploadResponse>("/api/v1/dcp/assets/complete-upload", localVarRequestOptions,
                    this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV1DcpAssetsCompleteUploadGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }
    }


    public interface IExtendedAssetsApi : IAssetsApi
    {
        System.Threading.Tasks.Task<
                FranchiseePortal.ContentWebApiClient.Client.ApiResponse<CompleteUploadResponse>>
            ApiV1DcpAssetsCompleteUploadGetWithHttpInfoAsync(string path = default(string),
                string uploadToken = default(string),
                string fileName = default(string),
                string mimeType = default(string),
                string affinity = default(string),
                System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }


}
