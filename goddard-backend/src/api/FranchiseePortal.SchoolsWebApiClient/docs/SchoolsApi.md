# FranchiseePortal.SchoolsWebApiClient.Api.SchoolsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1SchoolsFmsIdIdGet**](SchoolsApi.md#apiv1schoolsfmsididget) | **GET** /api/v1/schools/fms_id_{id} | 
[**ApiV1SchoolsGet**](SchoolsApi.md#apiv1schoolsget) | **GET** /api/v1/schools | 
[**ApiV1SchoolsIdCareersGet**](SchoolsApi.md#apiv1schoolsidcareersget) | **GET** /api/v1/schools/{id}/careers | 
[**ApiV1SchoolsIdClearFeaturesCachePost**](SchoolsApi.md#apiv1schoolsidclearfeaturescachepost) | **POST** /api/v1/schools/{id}/clear-features-cache | 
[**ApiV1SchoolsIdGet**](SchoolsApi.md#apiv1schoolsidget) | **GET** /api/v1/schools/{id} | 
[**ApiV1SchoolsIdSocialMediaGet**](SchoolsApi.md#apiv1schoolsidsocialmediaget) | **GET** /api/v1/schools/{id}/social-media | 
[**ApiV1SchoolsIdSummerCampsGet**](SchoolsApi.md#apiv1schoolsidsummercampsget) | **GET** /api/v1/schools/{id}/summer-camps | 
[**ApiV1SchoolsSchoolNumberSchoolNumberGet**](SchoolsApi.md#apiv1schoolsschoolnumberschoolnumberget) | **GET** /api/v1/schools/school_number_{schoolNumber} | 


<a name="apiv1schoolsfmsididget"></a>
# **ApiV1SchoolsFmsIdIdGet**
> School ApiV1SchoolsFmsIdIdGet (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.SchoolsWebApiClient.Api;
using FranchiseePortal.SchoolsWebApiClient.Client;
using FranchiseePortal.SchoolsWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolsFmsIdIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SchoolsApi(config);
            var id = id_example;  // string | 

            try
            {
                School result = apiInstance.ApiV1SchoolsFmsIdIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolsApi.ApiV1SchoolsFmsIdIdGet: " + e.Message );
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
 **id** | **string**|  | 

### Return type

[**School**](School.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schoolsget"></a>
# **ApiV1SchoolsGet**
> SchoolPagination ApiV1SchoolsGet (double? lat = null, double? lng = null, bool? showOnPublicWebsite = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.SchoolsWebApiClient.Api;
using FranchiseePortal.SchoolsWebApiClient.Client;
using FranchiseePortal.SchoolsWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SchoolsApi(config);
            var lat = 1.2D;  // double? |  (optional) 
            var lng = 1.2D;  // double? |  (optional) 
            var showOnPublicWebsite = true;  // bool? |  (optional) 

            try
            {
                SchoolPagination result = apiInstance.ApiV1SchoolsGet(lat, lng, showOnPublicWebsite);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolsApi.ApiV1SchoolsGet: " + e.Message );
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
 **lat** | **double?**|  | [optional] 
 **lng** | **double?**|  | [optional] 
 **showOnPublicWebsite** | **bool?**|  | [optional] 

### Return type

[**SchoolPagination**](SchoolPagination.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schoolsidcareersget"></a>
# **ApiV1SchoolsIdCareersGet**
> List&lt;SchoolCareer&gt; ApiV1SchoolsIdCareersGet (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.SchoolsWebApiClient.Api;
using FranchiseePortal.SchoolsWebApiClient.Client;
using FranchiseePortal.SchoolsWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolsIdCareersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SchoolsApi(config);
            var id = id_example;  // string | 

            try
            {
                List<SchoolCareer> result = apiInstance.ApiV1SchoolsIdCareersGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolsApi.ApiV1SchoolsIdCareersGet: " + e.Message );
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
 **id** | **string**|  | 

### Return type

[**List&lt;SchoolCareer&gt;**](SchoolCareer.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schoolsidclearfeaturescachepost"></a>
# **ApiV1SchoolsIdClearFeaturesCachePost**
> void ApiV1SchoolsIdClearFeaturesCachePost (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.SchoolsWebApiClient.Api;
using FranchiseePortal.SchoolsWebApiClient.Client;
using FranchiseePortal.SchoolsWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolsIdClearFeaturesCachePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SchoolsApi(config);
            var id = id_example;  // string | 

            try
            {
                apiInstance.ApiV1SchoolsIdClearFeaturesCachePost(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolsApi.ApiV1SchoolsIdClearFeaturesCachePost: " + e.Message );
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
 **id** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schoolsidget"></a>
# **ApiV1SchoolsIdGet**
> School ApiV1SchoolsIdGet (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.SchoolsWebApiClient.Api;
using FranchiseePortal.SchoolsWebApiClient.Client;
using FranchiseePortal.SchoolsWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolsIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SchoolsApi(config);
            var id = id_example;  // string | 

            try
            {
                School result = apiInstance.ApiV1SchoolsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolsApi.ApiV1SchoolsIdGet: " + e.Message );
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
 **id** | **string**|  | 

### Return type

[**School**](School.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schoolsidsocialmediaget"></a>
# **ApiV1SchoolsIdSocialMediaGet**
> List&lt;SchoolSocialMediaFeed&gt; ApiV1SchoolsIdSocialMediaGet (string id, int? limit = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.SchoolsWebApiClient.Api;
using FranchiseePortal.SchoolsWebApiClient.Client;
using FranchiseePortal.SchoolsWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolsIdSocialMediaGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SchoolsApi(config);
            var id = id_example;  // string | 
            var limit = 56;  // int? |  (optional)  (default to 10)

            try
            {
                List<SchoolSocialMediaFeed> result = apiInstance.ApiV1SchoolsIdSocialMediaGet(id, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolsApi.ApiV1SchoolsIdSocialMediaGet: " + e.Message );
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
 **id** | **string**|  | 
 **limit** | **int?**|  | [optional] [default to 10]

### Return type

[**List&lt;SchoolSocialMediaFeed&gt;**](SchoolSocialMediaFeed.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schoolsidsummercampsget"></a>
# **ApiV1SchoolsIdSummerCampsGet**
> List&lt;SummerCamp&gt; ApiV1SchoolsIdSummerCampsGet (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.SchoolsWebApiClient.Api;
using FranchiseePortal.SchoolsWebApiClient.Client;
using FranchiseePortal.SchoolsWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolsIdSummerCampsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SchoolsApi(config);
            var id = id_example;  // string | 

            try
            {
                List<SummerCamp> result = apiInstance.ApiV1SchoolsIdSummerCampsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolsApi.ApiV1SchoolsIdSummerCampsGet: " + e.Message );
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
 **id** | **string**|  | 

### Return type

[**List&lt;SummerCamp&gt;**](SummerCamp.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schoolsschoolnumberschoolnumberget"></a>
# **ApiV1SchoolsSchoolNumberSchoolNumberGet**
> School ApiV1SchoolsSchoolNumberSchoolNumberGet (string schoolNumber)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.SchoolsWebApiClient.Api;
using FranchiseePortal.SchoolsWebApiClient.Client;
using FranchiseePortal.SchoolsWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolsSchoolNumberSchoolNumberGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SchoolsApi(config);
            var schoolNumber = schoolNumber_example;  // string | 

            try
            {
                School result = apiInstance.ApiV1SchoolsSchoolNumberSchoolNumberGet(schoolNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolsApi.ApiV1SchoolsSchoolNumberSchoolNumberGet: " + e.Message );
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
 **schoolNumber** | **string**|  | 

### Return type

[**School**](School.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

