# FranchiseePortal.SchoolsWebApiClient.Api.CacheApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiCacheDelete**](CacheApi.md#apicachedelete) | **DELETE** /api/cache | 


<a name="apicachedelete"></a>
# **ApiCacheDelete**
> void ApiCacheDelete ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.SchoolsWebApiClient.Api;
using FranchiseePortal.SchoolsWebApiClient.Client;
using FranchiseePortal.SchoolsWebApiClient.Model;

namespace Example
{
    public class ApiCacheDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CacheApi(config);

            try
            {
                apiInstance.ApiCacheDelete();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CacheApi.ApiCacheDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

