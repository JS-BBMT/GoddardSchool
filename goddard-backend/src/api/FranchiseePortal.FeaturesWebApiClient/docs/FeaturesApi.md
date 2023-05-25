# FranchiseePortal.FeaturesWebApiClient.Api.FeaturesApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1FeaturePost**](FeaturesApi.md#apiv1featurepost) | **POST** /api/v1/feature | 
[**ApiV1FeaturesGet**](FeaturesApi.md#apiv1featuresget) | **GET** /api/v1/features | Returns all Features that exists.
[**ApiV1SchoolFeaturePost**](FeaturesApi.md#apiv1schoolfeaturepost) | **POST** /api/v1/school-feature | 
[**ApiV1SchoolFeaturesGet**](FeaturesApi.md#apiv1schoolfeaturesget) | **GET** /api/v1/school-features | Returns Features assigned to schools
[**ApiV1SchoolFeaturesSchoolCrmIdDelete**](FeaturesApi.md#apiv1schoolfeaturesschoolcrmiddelete) | **DELETE** /api/v1/school-features/{schoolCrmId} | 
[**ApiV1SchoolFeaturesSchoolCrmIdPost**](FeaturesApi.md#apiv1schoolfeaturesschoolcrmidpost) | **POST** /api/v1/school-features/{schoolCrmId} | 


<a name="apiv1featurepost"></a>
# **ApiV1FeaturePost**
> SchoolFeature ApiV1FeaturePost (AddFeatureModel addFeatureModel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.FeaturesWebApiClient.Api;
using FranchiseePortal.FeaturesWebApiClient.Client;
using FranchiseePortal.FeaturesWebApiClient.Model;

namespace Example
{
    public class ApiV1FeaturePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FeaturesApi(config);
            var addFeatureModel = new AddFeatureModel(); // AddFeatureModel |  (optional) 

            try
            {
                SchoolFeature result = apiInstance.ApiV1FeaturePost(addFeatureModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeaturesApi.ApiV1FeaturePost: " + e.Message );
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
 **addFeatureModel** | [**AddFeatureModel**](AddFeatureModel.md)|  | [optional] 

### Return type

[**SchoolFeature**](SchoolFeature.md)

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

<a name="apiv1featuresget"></a>
# **ApiV1FeaturesGet**
> List&lt;Feature&gt; ApiV1FeaturesGet ()

Returns all Features that exists.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.FeaturesWebApiClient.Api;
using FranchiseePortal.FeaturesWebApiClient.Client;
using FranchiseePortal.FeaturesWebApiClient.Model;

namespace Example
{
    public class ApiV1FeaturesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FeaturesApi(config);

            try
            {
                // Returns all Features that exists.
                List<Feature> result = apiInstance.ApiV1FeaturesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeaturesApi.ApiV1FeaturesGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;Feature&gt;**](Feature.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schoolfeaturepost"></a>
# **ApiV1SchoolFeaturePost**
> SchoolFeaturesModel ApiV1SchoolFeaturePost (AddSchoolFeatureModel addSchoolFeatureModel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.FeaturesWebApiClient.Api;
using FranchiseePortal.FeaturesWebApiClient.Client;
using FranchiseePortal.FeaturesWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolFeaturePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FeaturesApi(config);
            var addSchoolFeatureModel = new AddSchoolFeatureModel(); // AddSchoolFeatureModel |  (optional) 

            try
            {
                SchoolFeaturesModel result = apiInstance.ApiV1SchoolFeaturePost(addSchoolFeatureModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeaturesApi.ApiV1SchoolFeaturePost: " + e.Message );
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
 **addSchoolFeatureModel** | [**AddSchoolFeatureModel**](AddSchoolFeatureModel.md)|  | [optional] 

### Return type

[**SchoolFeaturesModel**](SchoolFeaturesModel.md)

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

<a name="apiv1schoolfeaturesget"></a>
# **ApiV1SchoolFeaturesGet**
> List&lt;SchoolFeature&gt; ApiV1SchoolFeaturesGet (List<string> crmSchoolIds = null, List<string> features = null)

Returns Features assigned to schools

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.FeaturesWebApiClient.Api;
using FranchiseePortal.FeaturesWebApiClient.Client;
using FranchiseePortal.FeaturesWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolFeaturesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FeaturesApi(config);
            var crmSchoolIds = new List<string>(); // List<string> |  (optional) 
            var features = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Returns Features assigned to schools
                List<SchoolFeature> result = apiInstance.ApiV1SchoolFeaturesGet(crmSchoolIds, features);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeaturesApi.ApiV1SchoolFeaturesGet: " + e.Message );
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
 **crmSchoolIds** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **features** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**List&lt;SchoolFeature&gt;**](SchoolFeature.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schoolfeaturesschoolcrmiddelete"></a>
# **ApiV1SchoolFeaturesSchoolCrmIdDelete**
> SchoolFeaturesModel ApiV1SchoolFeaturesSchoolCrmIdDelete (string schoolCrmId, DeleteSchoolFeatureModel deleteSchoolFeatureModel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.FeaturesWebApiClient.Api;
using FranchiseePortal.FeaturesWebApiClient.Client;
using FranchiseePortal.FeaturesWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolFeaturesSchoolCrmIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FeaturesApi(config);
            var schoolCrmId = schoolCrmId_example;  // string | 
            var deleteSchoolFeatureModel = new DeleteSchoolFeatureModel(); // DeleteSchoolFeatureModel |  (optional) 

            try
            {
                SchoolFeaturesModel result = apiInstance.ApiV1SchoolFeaturesSchoolCrmIdDelete(schoolCrmId, deleteSchoolFeatureModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeaturesApi.ApiV1SchoolFeaturesSchoolCrmIdDelete: " + e.Message );
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
 **schoolCrmId** | **string**|  | 
 **deleteSchoolFeatureModel** | [**DeleteSchoolFeatureModel**](DeleteSchoolFeatureModel.md)|  | [optional] 

### Return type

[**SchoolFeaturesModel**](SchoolFeaturesModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **204** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schoolfeaturesschoolcrmidpost"></a>
# **ApiV1SchoolFeaturesSchoolCrmIdPost**
> SchoolFeaturesModel ApiV1SchoolFeaturesSchoolCrmIdPost (string schoolCrmId, AddSchoolFeatureByAlternateIdModel addSchoolFeatureByAlternateIdModel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.FeaturesWebApiClient.Api;
using FranchiseePortal.FeaturesWebApiClient.Client;
using FranchiseePortal.FeaturesWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolFeaturesSchoolCrmIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FeaturesApi(config);
            var schoolCrmId = schoolCrmId_example;  // string | 
            var addSchoolFeatureByAlternateIdModel = new AddSchoolFeatureByAlternateIdModel(); // AddSchoolFeatureByAlternateIdModel |  (optional) 

            try
            {
                SchoolFeaturesModel result = apiInstance.ApiV1SchoolFeaturesSchoolCrmIdPost(schoolCrmId, addSchoolFeatureByAlternateIdModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeaturesApi.ApiV1SchoolFeaturesSchoolCrmIdPost: " + e.Message );
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
 **schoolCrmId** | **string**|  | 
 **addSchoolFeatureByAlternateIdModel** | [**AddSchoolFeatureByAlternateIdModel**](AddSchoolFeatureByAlternateIdModel.md)|  | [optional] 

### Return type

[**SchoolFeaturesModel**](SchoolFeaturesModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Success |  -  |
| **204** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

