# FranchiseePortal.SchoolsWebApiClient.Api.GeocoordinatesApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1GeocoordinatesGet**](GeocoordinatesApi.md#apiv1geocoordinatesget) | **GET** /api/v1/geocoordinates | 


<a name="apiv1geocoordinatesget"></a>
# **ApiV1GeocoordinatesGet**
> List&lt;SchoolGeocoordinate&gt; ApiV1GeocoordinatesGet (bool? showOnPublicWebsite = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.SchoolsWebApiClient.Api;
using FranchiseePortal.SchoolsWebApiClient.Client;
using FranchiseePortal.SchoolsWebApiClient.Model;

namespace Example
{
    public class ApiV1GeocoordinatesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new GeocoordinatesApi(config);
            var showOnPublicWebsite = true;  // bool? |  (optional) 

            try
            {
                List<SchoolGeocoordinate> result = apiInstance.ApiV1GeocoordinatesGet(showOnPublicWebsite);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeocoordinatesApi.ApiV1GeocoordinatesGet: " + e.Message );
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
 **showOnPublicWebsite** | **bool?**|  | [optional] 

### Return type

[**List&lt;SchoolGeocoordinate&gt;**](SchoolGeocoordinate.md)

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

