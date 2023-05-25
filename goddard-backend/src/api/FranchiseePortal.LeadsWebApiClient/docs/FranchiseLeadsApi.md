# FranchiseePortal.LeadsWebApiClient.Api.FranchiseLeadsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1FranchiseLeadsPost**](FranchiseLeadsApi.md#apiv1franchiseleadspost) | **POST** /api/v1/franchise-leads | 


<a name="apiv1franchiseleadspost"></a>
# **ApiV1FranchiseLeadsPost**
> void ApiV1FranchiseLeadsPost (string appName = null, ApiV1FranchiseLeadsPostRequest apiV1FranchiseLeadsPostRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.LeadsWebApiClient.Api;
using FranchiseePortal.LeadsWebApiClient.Client;
using FranchiseePortal.LeadsWebApiClient.Model;

namespace Example
{
    public class ApiV1FranchiseLeadsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new FranchiseLeadsApi(config);
            var appName = "appName_example";  // string |  (optional) 
            var apiV1FranchiseLeadsPostRequest = new ApiV1FranchiseLeadsPostRequest(); // ApiV1FranchiseLeadsPostRequest |  (optional) 

            try
            {
                apiInstance.ApiV1FranchiseLeadsPost(appName, apiV1FranchiseLeadsPostRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FranchiseLeadsApi.ApiV1FranchiseLeadsPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appName** | **string**|  | [optional] 
 **apiV1FranchiseLeadsPostRequest** | [**ApiV1FranchiseLeadsPostRequest**](ApiV1FranchiseLeadsPostRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

