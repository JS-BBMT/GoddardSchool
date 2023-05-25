# FranchiseePortal.AuthorizationWebApiClient.Api.AuthorizedSchoolsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1AuthorizedSchoolsGet**](AuthorizedSchoolsApi.md#apiv1authorizedschoolsget) | **GET** /api/v1/authorized-schools | 


<a name="apiv1authorizedschoolsget"></a>
# **ApiV1AuthorizedSchoolsGet**
> List&lt;AuthorizedSchool&gt; ApiV1AuthorizedSchoolsGet (string user = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.AuthorizationWebApiClient.Api;
using FranchiseePortal.AuthorizationWebApiClient.Client;
using FranchiseePortal.AuthorizationWebApiClient.Model;

namespace Example
{
    public class ApiV1AuthorizedSchoolsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthorizedSchoolsApi(config);
            var user = user_example;  // string |  (optional) 

            try
            {
                List<AuthorizedSchool> result = apiInstance.ApiV1AuthorizedSchoolsGet(user);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizedSchoolsApi.ApiV1AuthorizedSchoolsGet: " + e.Message );
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
 **user** | **string**|  | [optional] 

### Return type

[**List&lt;AuthorizedSchool&gt;**](AuthorizedSchool.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

