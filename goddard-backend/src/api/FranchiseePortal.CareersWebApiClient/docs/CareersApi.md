# FranchiseePortal.CareersWebApiClient.Api.CareersApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1CareersCareerIdDelete**](CareersApi.md#apiv1careerscareeriddelete) | **DELETE** /api/v1/careers/{careerId} | 
[**ApiV1CareersCareerIdGet**](CareersApi.md#apiv1careerscareeridget) | **GET** /api/v1/careers/{careerId} | 
[**ApiV1CareersPost**](CareersApi.md#apiv1careerspost) | **POST** /api/v1/careers | 
[**ApiV1CareersSchoolIdSchoolIdGet**](CareersApi.md#apiv1careersschoolidschoolidget) | **GET** /api/v1/careers/SchoolId/{schoolId} | 


<a name="apiv1careerscareeriddelete"></a>
# **ApiV1CareersCareerIdDelete**
> Career ApiV1CareersCareerIdDelete (long careerId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.CareersWebApiClient.Api;
using FranchiseePortal.CareersWebApiClient.Client;
using FranchiseePortal.CareersWebApiClient.Model;

namespace Example
{
    public class ApiV1CareersCareerIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CareersApi(config);
            var careerId = 789;  // long | 

            try
            {
                Career result = apiInstance.ApiV1CareersCareerIdDelete(careerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CareersApi.ApiV1CareersCareerIdDelete: " + e.Message );
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
 **careerId** | **long**|  | 

### Return type

[**Career**](Career.md)

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
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1careerscareeridget"></a>
# **ApiV1CareersCareerIdGet**
> Career ApiV1CareersCareerIdGet (long careerId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.CareersWebApiClient.Api;
using FranchiseePortal.CareersWebApiClient.Client;
using FranchiseePortal.CareersWebApiClient.Model;

namespace Example
{
    public class ApiV1CareersCareerIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CareersApi(config);
            var careerId = 789;  // long | 

            try
            {
                Career result = apiInstance.ApiV1CareersCareerIdGet(careerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CareersApi.ApiV1CareersCareerIdGet: " + e.Message );
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
 **careerId** | **long**|  | 

### Return type

[**Career**](Career.md)

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
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1careerspost"></a>
# **ApiV1CareersPost**
> Career ApiV1CareersPost (Career career = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.CareersWebApiClient.Api;
using FranchiseePortal.CareersWebApiClient.Client;
using FranchiseePortal.CareersWebApiClient.Model;

namespace Example
{
    public class ApiV1CareersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CareersApi(config);
            var career = new Career(); // Career |  (optional) 

            try
            {
                Career result = apiInstance.ApiV1CareersPost(career);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CareersApi.ApiV1CareersPost: " + e.Message );
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
 **career** | [**Career**](Career.md)|  | [optional] 

### Return type

[**Career**](Career.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **201** | Success |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1careersschoolidschoolidget"></a>
# **ApiV1CareersSchoolIdSchoolIdGet**
> List&lt;Career&gt; ApiV1CareersSchoolIdSchoolIdGet (string schoolId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.CareersWebApiClient.Api;
using FranchiseePortal.CareersWebApiClient.Client;
using FranchiseePortal.CareersWebApiClient.Model;

namespace Example
{
    public class ApiV1CareersSchoolIdSchoolIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CareersApi(config);
            var schoolId = schoolId_example;  // string | 

            try
            {
                List<Career> result = apiInstance.ApiV1CareersSchoolIdSchoolIdGet(schoolId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CareersApi.ApiV1CareersSchoolIdSchoolIdGet: " + e.Message );
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
 **schoolId** | **string**|  | 

### Return type

[**List&lt;Career&gt;**](Career.md)

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
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

