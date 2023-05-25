# FranchiseePortal.ContentWebApiClient.Api.SchoolsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1DcpSchoolsCrmIdPageGet**](SchoolsApi.md#apiv1dcpschoolscrmidpageget) | **GET** /api/v1/dcp/schools/{crmId}/page | 
[**ApiV1DcpSchoolsCrmIdPublishPost**](SchoolsApi.md#apiv1dcpschoolscrmidpublishpost) | **POST** /api/v1/dcp/schools/{crmId}/publish | 
[**ApiV1DcpSchoolsCrmIdUpdateSchoolPut**](SchoolsApi.md#apiv1dcpschoolscrmidupdateschoolput) | **PUT** /api/v1/dcp/schools/{crmId}/update-school | 
[**ApiV1DcpSchoolsGet**](SchoolsApi.md#apiv1dcpschoolsget) | **GET** /api/v1/dcp/schools | 


<a name="apiv1dcpschoolscrmidpageget"></a>
# **ApiV1DcpSchoolsCrmIdPageGet**
> string ApiV1DcpSchoolsCrmIdPageGet (string crmId, string path = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.ContentWebApiClient.Client;
using FranchiseePortal.ContentWebApiClient.Model;

namespace Example
{
    public class ApiV1DcpSchoolsCrmIdPageGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SchoolsApi(config);
            var crmId = "crmId_example";  // string | 
            var path = "\"\"";  // string |  (optional)  (default to "")

            try
            {
                string result = apiInstance.ApiV1DcpSchoolsCrmIdPageGet(crmId, path);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolsApi.ApiV1DcpSchoolsCrmIdPageGet: " + e.Message );
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
 **crmId** | **string**|  | 
 **path** | **string**|  | [optional] [default to &quot;&quot;]

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1dcpschoolscrmidpublishpost"></a>
# **ApiV1DcpSchoolsCrmIdPublishPost**
> void ApiV1DcpSchoolsCrmIdPublishPost (string crmId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.ContentWebApiClient.Client;
using FranchiseePortal.ContentWebApiClient.Model;

namespace Example
{
    public class ApiV1DcpSchoolsCrmIdPublishPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SchoolsApi(config);
            var crmId = "crmId_example";  // string | 

            try
            {
                apiInstance.ApiV1DcpSchoolsCrmIdPublishPost(crmId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolsApi.ApiV1DcpSchoolsCrmIdPublishPost: " + e.Message );
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
 **crmId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1dcpschoolscrmidupdateschoolput"></a>
# **ApiV1DcpSchoolsCrmIdUpdateSchoolPut**
> SchoolsUpdateResponse ApiV1DcpSchoolsCrmIdUpdateSchoolPut (string crmId, SchoolsUpdateRequest schoolsUpdateRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.ContentWebApiClient.Client;
using FranchiseePortal.ContentWebApiClient.Model;

namespace Example
{
    public class ApiV1DcpSchoolsCrmIdUpdateSchoolPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SchoolsApi(config);
            var crmId = "crmId_example";  // string | 
            var schoolsUpdateRequest = new SchoolsUpdateRequest(); // SchoolsUpdateRequest |  (optional) 

            try
            {
                SchoolsUpdateResponse result = apiInstance.ApiV1DcpSchoolsCrmIdUpdateSchoolPut(crmId, schoolsUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolsApi.ApiV1DcpSchoolsCrmIdUpdateSchoolPut: " + e.Message );
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
 **crmId** | **string**|  | 
 **schoolsUpdateRequest** | [**SchoolsUpdateRequest**](SchoolsUpdateRequest.md)|  | [optional] 

### Return type

[**SchoolsUpdateResponse**](SchoolsUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1dcpschoolsget"></a>
# **ApiV1DcpSchoolsGet**
> ExtendedSchoolInfoResponse ApiV1DcpSchoolsGet (string crmId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.ContentWebApiClient.Client;
using FranchiseePortal.ContentWebApiClient.Model;

namespace Example
{
    public class ApiV1DcpSchoolsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SchoolsApi(config);
            var crmId = "crmId_example";  // string |  (optional) 

            try
            {
                ExtendedSchoolInfoResponse result = apiInstance.ApiV1DcpSchoolsGet(crmId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolsApi.ApiV1DcpSchoolsGet: " + e.Message );
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
 **crmId** | **string**|  | [optional] 

### Return type

[**ExtendedSchoolInfoResponse**](ExtendedSchoolInfoResponse.md)

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

