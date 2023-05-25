# FranchiseePortal.LeadsWebApiClient.Api.ValidationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1ValidationEmailPost**](ValidationApi.md#apiv1validationemailpost) | **POST** /api/v1/validation/email | 
[**ApiV1ValidationPhonePost**](ValidationApi.md#apiv1validationphonepost) | **POST** /api/v1/validation/phone | 


<a name="apiv1validationemailpost"></a>
# **ApiV1ValidationEmailPost**
> EmailValidationResult ApiV1ValidationEmailPost (string appName = null, ApiV1ValidationEmailPostRequest apiV1ValidationEmailPostRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.LeadsWebApiClient.Api;
using FranchiseePortal.LeadsWebApiClient.Client;
using FranchiseePortal.LeadsWebApiClient.Model;

namespace Example
{
    public class ApiV1ValidationEmailPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ValidationApi(config);
            var appName = "appName_example";  // string |  (optional) 
            var apiV1ValidationEmailPostRequest = new ApiV1ValidationEmailPostRequest(); // ApiV1ValidationEmailPostRequest |  (optional) 

            try
            {
                EmailValidationResult result = apiInstance.ApiV1ValidationEmailPost(appName, apiV1ValidationEmailPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ValidationApi.ApiV1ValidationEmailPost: " + e.Message );
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
 **apiV1ValidationEmailPostRequest** | [**ApiV1ValidationEmailPostRequest**](ApiV1ValidationEmailPostRequest.md)|  | [optional] 

### Return type

[**EmailValidationResult**](EmailValidationResult.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1validationphonepost"></a>
# **ApiV1ValidationPhonePost**
> PhoneValidationResult ApiV1ValidationPhonePost (string appName = null, ApiV1ValidationPhonePostRequest apiV1ValidationPhonePostRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.LeadsWebApiClient.Api;
using FranchiseePortal.LeadsWebApiClient.Client;
using FranchiseePortal.LeadsWebApiClient.Model;

namespace Example
{
    public class ApiV1ValidationPhonePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ValidationApi(config);
            var appName = "appName_example";  // string |  (optional) 
            var apiV1ValidationPhonePostRequest = new ApiV1ValidationPhonePostRequest(); // ApiV1ValidationPhonePostRequest |  (optional) 

            try
            {
                PhoneValidationResult result = apiInstance.ApiV1ValidationPhonePost(appName, apiV1ValidationPhonePostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ValidationApi.ApiV1ValidationPhonePost: " + e.Message );
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
 **apiV1ValidationPhonePostRequest** | [**ApiV1ValidationPhonePostRequest**](ApiV1ValidationPhonePostRequest.md)|  | [optional] 

### Return type

[**PhoneValidationResult**](PhoneValidationResult.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

