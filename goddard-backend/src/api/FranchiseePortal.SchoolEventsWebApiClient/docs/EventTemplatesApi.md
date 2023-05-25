# FranchiseePortal.SchoolEventsWebApiClient.Api.EventTemplatesApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1EventTemplateDelete**](EventTemplatesApi.md#apiv1eventtemplatedelete) | **DELETE** /api/v1/eventTemplate | 
[**ApiV1EventTemplateGet**](EventTemplatesApi.md#apiv1eventtemplateget) | **GET** /api/v1/eventTemplate | 
[**ApiV1EventTemplatePost**](EventTemplatesApi.md#apiv1eventtemplatepost) | **POST** /api/v1/eventTemplate | 
[**ApiV1EventTemplatePut**](EventTemplatesApi.md#apiv1eventtemplateput) | **PUT** /api/v1/eventTemplate | 
[**ApiV1EventTemplatesGet**](EventTemplatesApi.md#apiv1eventtemplatesget) | **GET** /api/v1/eventTemplates | 


<a name="apiv1eventtemplatedelete"></a>
# **ApiV1EventTemplateDelete**
> void ApiV1EventTemplateDelete (long? templateId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.SchoolEventsWebApiClient.Api;
using FranchiseePortal.SchoolEventsWebApiClient.Client;
using FranchiseePortal.SchoolEventsWebApiClient.Model;

namespace Example
{
    public class ApiV1EventTemplateDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EventTemplatesApi(config);
            var templateId = 789;  // long? |  (optional) 

            try
            {
                apiInstance.ApiV1EventTemplateDelete(templateId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventTemplatesApi.ApiV1EventTemplateDelete: " + e.Message );
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
 **templateId** | **long?**|  | [optional] 

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

<a name="apiv1eventtemplateget"></a>
# **ApiV1EventTemplateGet**
> EventTemplate ApiV1EventTemplateGet (long? templateId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.SchoolEventsWebApiClient.Api;
using FranchiseePortal.SchoolEventsWebApiClient.Client;
using FranchiseePortal.SchoolEventsWebApiClient.Model;

namespace Example
{
    public class ApiV1EventTemplateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EventTemplatesApi(config);
            var templateId = 789;  // long? |  (optional) 

            try
            {
                EventTemplate result = apiInstance.ApiV1EventTemplateGet(templateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventTemplatesApi.ApiV1EventTemplateGet: " + e.Message );
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
 **templateId** | **long?**|  | [optional] 

### Return type

[**EventTemplate**](EventTemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1eventtemplatepost"></a>
# **ApiV1EventTemplatePost**
> EventTemplate ApiV1EventTemplatePost (PostEventTemplate postEventTemplate = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.SchoolEventsWebApiClient.Api;
using FranchiseePortal.SchoolEventsWebApiClient.Client;
using FranchiseePortal.SchoolEventsWebApiClient.Model;

namespace Example
{
    public class ApiV1EventTemplatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EventTemplatesApi(config);
            var postEventTemplate = new PostEventTemplate(); // PostEventTemplate |  (optional) 

            try
            {
                EventTemplate result = apiInstance.ApiV1EventTemplatePost(postEventTemplate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventTemplatesApi.ApiV1EventTemplatePost: " + e.Message );
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
 **postEventTemplate** | [**PostEventTemplate**](PostEventTemplate.md)|  | [optional] 

### Return type

[**EventTemplate**](EventTemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1eventtemplateput"></a>
# **ApiV1EventTemplatePut**
> EventTemplate ApiV1EventTemplatePut (long? templateId = null, PostEventTemplate postEventTemplate = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.SchoolEventsWebApiClient.Api;
using FranchiseePortal.SchoolEventsWebApiClient.Client;
using FranchiseePortal.SchoolEventsWebApiClient.Model;

namespace Example
{
    public class ApiV1EventTemplatePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EventTemplatesApi(config);
            var templateId = 789;  // long? |  (optional) 
            var postEventTemplate = new PostEventTemplate(); // PostEventTemplate |  (optional) 

            try
            {
                EventTemplate result = apiInstance.ApiV1EventTemplatePut(templateId, postEventTemplate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventTemplatesApi.ApiV1EventTemplatePut: " + e.Message );
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
 **templateId** | **long?**|  | [optional] 
 **postEventTemplate** | [**PostEventTemplate**](PostEventTemplate.md)|  | [optional] 

### Return type

[**EventTemplate**](EventTemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1eventtemplatesget"></a>
# **ApiV1EventTemplatesGet**
> List&lt;EventTemplate&gt; ApiV1EventTemplatesGet (long? fmsSchoolId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.SchoolEventsWebApiClient.Api;
using FranchiseePortal.SchoolEventsWebApiClient.Client;
using FranchiseePortal.SchoolEventsWebApiClient.Model;

namespace Example
{
    public class ApiV1EventTemplatesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EventTemplatesApi(config);
            var fmsSchoolId = 789;  // long? |  (optional) 

            try
            {
                List<EventTemplate> result = apiInstance.ApiV1EventTemplatesGet(fmsSchoolId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventTemplatesApi.ApiV1EventTemplatesGet: " + e.Message );
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
 **fmsSchoolId** | **long?**|  | [optional] 

### Return type

[**List&lt;EventTemplate&gt;**](EventTemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

