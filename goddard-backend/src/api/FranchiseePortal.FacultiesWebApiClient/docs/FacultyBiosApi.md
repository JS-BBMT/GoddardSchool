# FranchiseePortal.FacultiesWebApiClient.Api.FacultyBiosApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1FacultyGet**](FacultyBiosApi.md#apiv1facultyget) | **GET** /api/v1/faculty | 
[**ApiV1FacultyIdGet**](FacultyBiosApi.md#apiv1facultyidget) | **GET** /api/v1/faculty/{id} | 
[**ApiV1PostfacultiesPost**](FacultyBiosApi.md#apiv1postfacultiespost) | **POST** /api/v1/Postfaculties | 
[**ApiV1PostfacultyPost**](FacultyBiosApi.md#apiv1postfacultypost) | **POST** /api/v1/Postfaculty | 


<a name="apiv1facultyget"></a>
# **ApiV1FacultyGet**
> FacultyBiosPagedResponse ApiV1FacultyGet (string fmsSchoolId = null, bool? includeEmptyBios = null, bool? includeDisabledBios = null, int? page = null, int? pageSize = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.FacultiesWebApiClient.Api;
using FranchiseePortal.FacultiesWebApiClient.Client;
using FranchiseePortal.FacultiesWebApiClient.Model;

namespace Example
{
    public class ApiV1FacultyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FacultyBiosApi(config);
            var fmsSchoolId = "fmsSchoolId_example";  // string |  (optional) 
            var includeEmptyBios = true;  // bool? |  (optional) 
            var includeDisabledBios = true;  // bool? |  (optional) 
            var page = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 

            try
            {
                FacultyBiosPagedResponse result = apiInstance.ApiV1FacultyGet(fmsSchoolId, includeEmptyBios, includeDisabledBios, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FacultyBiosApi.ApiV1FacultyGet: " + e.Message );
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
 **fmsSchoolId** | **string**|  | [optional] 
 **includeEmptyBios** | **bool?**|  | [optional] 
 **includeDisabledBios** | **bool?**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **pageSize** | **int?**|  | [optional] 

### Return type

[**FacultyBiosPagedResponse**](FacultyBiosPagedResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1facultyidget"></a>
# **ApiV1FacultyIdGet**
> FacultyBios ApiV1FacultyIdGet (long id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.FacultiesWebApiClient.Api;
using FranchiseePortal.FacultiesWebApiClient.Client;
using FranchiseePortal.FacultiesWebApiClient.Model;

namespace Example
{
    public class ApiV1FacultyIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FacultyBiosApi(config);
            var id = 789L;  // long | 

            try
            {
                FacultyBios result = apiInstance.ApiV1FacultyIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FacultyBiosApi.ApiV1FacultyIdGet: " + e.Message );
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
 **id** | **long**|  | 

### Return type

[**FacultyBios**](FacultyBios.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1postfacultiespost"></a>
# **ApiV1PostfacultiesPost**
> void ApiV1PostfacultiesPost (List<PostFacultyBiosRequest> postFacultyBiosRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.FacultiesWebApiClient.Api;
using FranchiseePortal.FacultiesWebApiClient.Client;
using FranchiseePortal.FacultiesWebApiClient.Model;

namespace Example
{
    public class ApiV1PostfacultiesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FacultyBiosApi(config);
            var postFacultyBiosRequest = new List<PostFacultyBiosRequest>(); // List<PostFacultyBiosRequest> |  (optional) 

            try
            {
                apiInstance.ApiV1PostfacultiesPost(postFacultyBiosRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FacultyBiosApi.ApiV1PostfacultiesPost: " + e.Message );
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
 **postFacultyBiosRequest** | [**List&lt;PostFacultyBiosRequest&gt;**](PostFacultyBiosRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1postfacultypost"></a>
# **ApiV1PostfacultyPost**
> void ApiV1PostfacultyPost (PostFacultyBiosRequest postFacultyBiosRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.FacultiesWebApiClient.Api;
using FranchiseePortal.FacultiesWebApiClient.Client;
using FranchiseePortal.FacultiesWebApiClient.Model;

namespace Example
{
    public class ApiV1PostfacultyPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FacultyBiosApi(config);
            var postFacultyBiosRequest = new PostFacultyBiosRequest(); // PostFacultyBiosRequest |  (optional) 

            try
            {
                apiInstance.ApiV1PostfacultyPost(postFacultyBiosRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FacultyBiosApi.ApiV1PostfacultyPost: " + e.Message );
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
 **postFacultyBiosRequest** | [**PostFacultyBiosRequest**](PostFacultyBiosRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

