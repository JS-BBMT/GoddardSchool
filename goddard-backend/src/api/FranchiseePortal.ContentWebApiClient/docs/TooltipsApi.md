# FranchiseePortal.ContentWebApiClient.Api.TooltipsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1DcpTooltipsGet**](TooltipsApi.md#apiv1dcptooltipsget) | **GET** /api/v1/dcp/tooltips | 


<a name="apiv1dcptooltipsget"></a>
# **ApiV1DcpTooltipsGet**
> TooltipDto ApiV1DcpTooltipsGet (string cfParentPath, string cfName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.ContentWebApiClient.Client;
using FranchiseePortal.ContentWebApiClient.Model;

namespace Example
{
    public class ApiV1DcpTooltipsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TooltipsApi(config);
            var cfParentPath = "cfParentPath_example";  // string | 
            var cfName = "cfName_example";  // string | 

            try
            {
                TooltipDto result = apiInstance.ApiV1DcpTooltipsGet(cfParentPath, cfName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TooltipsApi.ApiV1DcpTooltipsGet: " + e.Message );
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
 **cfParentPath** | **string**|  | 
 **cfName** | **string**|  | 

### Return type

[**TooltipDto**](TooltipDto.md)

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

