# FranchiseePortal.SchoolEventsWebApiClient.Api.EventsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1AddEventsPost**](EventsApi.md#apiv1addeventspost) | **POST** /api/v1/addEvents | 
[**ApiV1EventsGet**](EventsApi.md#apiv1eventsget) | **GET** /api/v1/events | 


<a name="apiv1addeventspost"></a>
# **ApiV1AddEventsPost**
> PostEvents ApiV1AddEventsPost (PostEvents postEvents = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.SchoolEventsWebApiClient.Api;
using FranchiseePortal.SchoolEventsWebApiClient.Client;
using FranchiseePortal.SchoolEventsWebApiClient.Model;

namespace Example
{
    public class ApiV1AddEventsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EventsApi(config);
            var postEvents = new PostEvents(); // PostEvents |  (optional) 

            try
            {
                PostEvents result = apiInstance.ApiV1AddEventsPost(postEvents);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.ApiV1AddEventsPost: " + e.Message );
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
 **postEvents** | [**PostEvents**](PostEvents.md)|  | [optional] 

### Return type

[**PostEvents**](PostEvents.md)

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

<a name="apiv1eventsget"></a>
# **ApiV1EventsGet**
> List&lt;Events&gt; ApiV1EventsGet (string fmsSchoolId = null, string startDate = null, string endDate = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.SchoolEventsWebApiClient.Api;
using FranchiseePortal.SchoolEventsWebApiClient.Client;
using FranchiseePortal.SchoolEventsWebApiClient.Model;

namespace Example
{
    public class ApiV1EventsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new EventsApi(config);
            var fmsSchoolId = fmsSchoolId_example;  // string |  (optional) 
            var startDate = startDate_example;  // string |  (optional) 
            var endDate = endDate_example;  // string |  (optional) 

            try
            {
                List<Events> result = apiInstance.ApiV1EventsGet(fmsSchoolId, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.ApiV1EventsGet: " + e.Message );
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
 **startDate** | **string**|  | [optional] 
 **endDate** | **string**|  | [optional] 

### Return type

[**List&lt;Events&gt;**](Events.md)

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

