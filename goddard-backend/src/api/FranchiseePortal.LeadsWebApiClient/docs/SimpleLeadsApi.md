# FranchiseePortal.LeadsWebApiClient.Api.SimpleLeadsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1SimpleLeadsPost**](SimpleLeadsApi.md#apiv1simpleleadspost) | **POST** /api/v1/simple-leads | 


<a name="apiv1simpleleadspost"></a>
# **ApiV1SimpleLeadsPost**
> void ApiV1SimpleLeadsPost (string email = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.LeadsWebApiClient.Api;
using FranchiseePortal.LeadsWebApiClient.Client;
using FranchiseePortal.LeadsWebApiClient.Model;

namespace Example
{
    public class ApiV1SimpleLeadsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SimpleLeadsApi(config);
            var email = "email_example";  // string |  (optional) 

            try
            {
                apiInstance.ApiV1SimpleLeadsPost(email);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SimpleLeadsApi.ApiV1SimpleLeadsPost: " + e.Message );
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
 **email** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

