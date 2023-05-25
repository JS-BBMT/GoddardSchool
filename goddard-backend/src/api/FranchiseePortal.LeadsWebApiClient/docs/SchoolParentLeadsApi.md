# FranchiseePortal.LeadsWebApiClient.Api.SchoolParentLeadsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1SchoolLeadsGet**](SchoolParentLeadsApi.md#apiv1schoolleadsget) | **GET** /api/v1/school-leads | 
[**ApiV1SchoolLeadsGuidIdGuidIdGet**](SchoolParentLeadsApi.md#apiv1schoolleadsguididguididget) | **GET** /api/v1/school-leads/guid-id/{guidId} | 
[**ApiV1SchoolLeadsIdGet**](SchoolParentLeadsApi.md#apiv1schoolleadsidget) | **GET** /api/v1/school-leads/{id} | 
[**ApiV1SchoolLeadsIdTourPut**](SchoolParentLeadsApi.md#apiv1schoolleadsidtourput) | **PUT** /api/v1/school-leads/{id}/tour | 
[**ApiV1SchoolLeadsInternalPost**](SchoolParentLeadsApi.md#apiv1schoolleadsinternalpost) | **POST** /api/v1/school-leads/internal | 
[**ApiV1SchoolLeadsPost**](SchoolParentLeadsApi.md#apiv1schoolleadspost) | **POST** /api/v1/school-leads | 
[**ApiV1SchoolLeadsQueryByIdsPost**](SchoolParentLeadsApi.md#apiv1schoolleadsquerybyidspost) | **POST** /api/v1/school-leads/query-by-ids | 


<a name="apiv1schoolleadsget"></a>
# **ApiV1SchoolLeadsGet**
> LeadDtoPaginationDto ApiV1SchoolLeadsGet (long schoolId, string q = null, string name = null, int? childAge = null, DateTime? startDate = null, DateTime? endDate = null, List<string> programsOfInterest = null, int? page = null, int? pageSize = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.LeadsWebApiClient.Api;
using FranchiseePortal.LeadsWebApiClient.Client;
using FranchiseePortal.LeadsWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolLeadsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SchoolParentLeadsApi(config);
            var schoolId = 789L;  // long | 
            var q = "q_example";  // string |  (optional) 
            var name = "name_example";  // string |  (optional) 
            var childAge = 56;  // int? |  (optional) 
            var startDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var programsOfInterest = new List<string>(); // List<string> |  (optional) 
            var page = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 

            try
            {
                LeadDtoPaginationDto result = apiInstance.ApiV1SchoolLeadsGet(schoolId, q, name, childAge, startDate, endDate, programsOfInterest, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolParentLeadsApi.ApiV1SchoolLeadsGet: " + e.Message );
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
 **schoolId** | **long**|  | 
 **q** | **string**|  | [optional] 
 **name** | **string**|  | [optional] 
 **childAge** | **int?**|  | [optional] 
 **startDate** | **DateTime?**|  | [optional] 
 **endDate** | **DateTime?**|  | [optional] 
 **programsOfInterest** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **page** | **int?**|  | [optional] 
 **pageSize** | **int?**|  | [optional] 

### Return type

[**LeadDtoPaginationDto**](LeadDtoPaginationDto.md)

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

<a name="apiv1schoolleadsguididguididget"></a>
# **ApiV1SchoolLeadsGuidIdGuidIdGet**
> LeadDto ApiV1SchoolLeadsGuidIdGuidIdGet (Guid guidId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.LeadsWebApiClient.Api;
using FranchiseePortal.LeadsWebApiClient.Client;
using FranchiseePortal.LeadsWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolLeadsGuidIdGuidIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SchoolParentLeadsApi(config);
            var guidId = "guidId_example";  // Guid | 

            try
            {
                LeadDto result = apiInstance.ApiV1SchoolLeadsGuidIdGuidIdGet(guidId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolParentLeadsApi.ApiV1SchoolLeadsGuidIdGuidIdGet: " + e.Message );
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
 **guidId** | **Guid**|  | 

### Return type

[**LeadDto**](LeadDto.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schoolleadsidget"></a>
# **ApiV1SchoolLeadsIdGet**
> LeadDto ApiV1SchoolLeadsIdGet (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.LeadsWebApiClient.Api;
using FranchiseePortal.LeadsWebApiClient.Client;
using FranchiseePortal.LeadsWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolLeadsIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SchoolParentLeadsApi(config);
            var id = "id_example";  // string | 

            try
            {
                LeadDto result = apiInstance.ApiV1SchoolLeadsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolParentLeadsApi.ApiV1SchoolLeadsIdGet: " + e.Message );
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

[**LeadDto**](LeadDto.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schoolleadsidtourput"></a>
# **ApiV1SchoolLeadsIdTourPut**
> void ApiV1SchoolLeadsIdTourPut (Guid id, ApiV1SchoolLeadsIdTourPutRequest apiV1SchoolLeadsIdTourPutRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.LeadsWebApiClient.Api;
using FranchiseePortal.LeadsWebApiClient.Client;
using FranchiseePortal.LeadsWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolLeadsIdTourPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SchoolParentLeadsApi(config);
            var id = "id_example";  // Guid | 
            var apiV1SchoolLeadsIdTourPutRequest = new ApiV1SchoolLeadsIdTourPutRequest(); // ApiV1SchoolLeadsIdTourPutRequest |  (optional) 

            try
            {
                apiInstance.ApiV1SchoolLeadsIdTourPut(id, apiV1SchoolLeadsIdTourPutRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolParentLeadsApi.ApiV1SchoolLeadsIdTourPut: " + e.Message );
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
 **id** | **Guid**|  | 
 **apiV1SchoolLeadsIdTourPutRequest** | [**ApiV1SchoolLeadsIdTourPutRequest**](ApiV1SchoolLeadsIdTourPutRequest.md)|  | [optional] 

### Return type

void (empty response body)

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

<a name="apiv1schoolleadsinternalpost"></a>
# **ApiV1SchoolLeadsInternalPost**
> LeadDto ApiV1SchoolLeadsInternalPost (bool? async = null, string appName = null, ApiV1SchoolLeadsInternalPostRequest apiV1SchoolLeadsInternalPostRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.LeadsWebApiClient.Api;
using FranchiseePortal.LeadsWebApiClient.Client;
using FranchiseePortal.LeadsWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolLeadsInternalPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SchoolParentLeadsApi(config);
            var async = true;  // bool? |  (optional)  (default to true)
            var appName = "appName_example";  // string |  (optional) 
            var apiV1SchoolLeadsInternalPostRequest = new ApiV1SchoolLeadsInternalPostRequest(); // ApiV1SchoolLeadsInternalPostRequest |  (optional) 

            try
            {
                LeadDto result = apiInstance.ApiV1SchoolLeadsInternalPost(async, appName, apiV1SchoolLeadsInternalPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolParentLeadsApi.ApiV1SchoolLeadsInternalPost: " + e.Message );
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
 **async** | **bool?**|  | [optional] [default to true]
 **appName** | **string**|  | [optional] 
 **apiV1SchoolLeadsInternalPostRequest** | [**ApiV1SchoolLeadsInternalPostRequest**](ApiV1SchoolLeadsInternalPostRequest.md)|  | [optional] 

### Return type

[**LeadDto**](LeadDto.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schoolleadspost"></a>
# **ApiV1SchoolLeadsPost**
> LeadDto ApiV1SchoolLeadsPost (bool? async = null, string appName = null, ApiV1SchoolLeadsGetRequest apiV1SchoolLeadsGetRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.LeadsWebApiClient.Api;
using FranchiseePortal.LeadsWebApiClient.Client;
using FranchiseePortal.LeadsWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolLeadsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SchoolParentLeadsApi(config);
            var async = true;  // bool? |  (optional)  (default to true)
            var appName = "appName_example";  // string |  (optional) 
            var apiV1SchoolLeadsGetRequest = new ApiV1SchoolLeadsGetRequest(); // ApiV1SchoolLeadsGetRequest |  (optional) 

            try
            {
                LeadDto result = apiInstance.ApiV1SchoolLeadsPost(async, appName, apiV1SchoolLeadsGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolParentLeadsApi.ApiV1SchoolLeadsPost: " + e.Message );
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
 **async** | **bool?**|  | [optional] [default to true]
 **appName** | **string**|  | [optional] 
 **apiV1SchoolLeadsGetRequest** | [**ApiV1SchoolLeadsGetRequest**](ApiV1SchoolLeadsGetRequest.md)|  | [optional] 

### Return type

[**LeadDto**](LeadDto.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schoolleadsquerybyidspost"></a>
# **ApiV1SchoolLeadsQueryByIdsPost**
> List&lt;LeadDto&gt; ApiV1SchoolLeadsQueryByIdsPost (List<string> requestBody = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.LeadsWebApiClient.Api;
using FranchiseePortal.LeadsWebApiClient.Client;
using FranchiseePortal.LeadsWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolLeadsQueryByIdsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SchoolParentLeadsApi(config);
            var requestBody = new List<string>(); // List<string> |  (optional) 

            try
            {
                List<LeadDto> result = apiInstance.ApiV1SchoolLeadsQueryByIdsPost(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolParentLeadsApi.ApiV1SchoolLeadsQueryByIdsPost: " + e.Message );
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
 **requestBody** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**List&lt;LeadDto&gt;**](LeadDto.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

