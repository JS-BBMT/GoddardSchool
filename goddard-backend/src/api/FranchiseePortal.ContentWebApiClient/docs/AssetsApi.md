# FranchiseePortal.ContentWebApiClient.Api.AssetsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1DcpAssetsCompleteUploadGet**](AssetsApi.md#apiv1dcpassetscompleteuploadget) | **GET** /api/v1/dcp/assets/complete-upload | 
[**ApiV1DcpAssetsDeleteDelete**](AssetsApi.md#apiv1dcpassetsdeletedelete) | **DELETE** /api/v1/dcp/assets/delete | 
[**ApiV1DcpAssetsImageUploadLocationGet**](AssetsApi.md#apiv1dcpassetsimageuploadlocationget) | **GET** /api/v1/dcp/assets/image-upload-location | 
[**ApiV1DcpAssetsImageUploadLocationPost**](AssetsApi.md#apiv1dcpassetsimageuploadlocationpost) | **POST** /api/v1/dcp/assets/image-upload-location | 
[**ApiV1DcpAssetsImagesPathGet**](AssetsApi.md#apiv1dcpassetsimagespathget) | **GET** /api/v1/dcp/assets/images/{path} | 
[**ApiV1DcpAssetsPublishPost**](AssetsApi.md#apiv1dcpassetspublishpost) | **POST** /api/v1/dcp/assets/publish | 
[**ApiV1DcpAssetsSchoolHeroImagesGet**](AssetsApi.md#apiv1dcpassetsschoolheroimagesget) | **GET** /api/v1/dcp/assets/school-hero-images | 


<a name="apiv1dcpassetscompleteuploadget"></a>
# **ApiV1DcpAssetsCompleteUploadGet**
> CompleteUploadResponse ApiV1DcpAssetsCompleteUploadGet (string path = null, string uploadToken = null, string fileName = null, string mimeType = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.ContentWebApiClient.Client;
using FranchiseePortal.ContentWebApiClient.Model;

namespace Example
{
    public class ApiV1DcpAssetsCompleteUploadGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AssetsApi(config);
            var path = "path_example";  // string |  (optional) 
            var uploadToken = "uploadToken_example";  // string |  (optional) 
            var fileName = "fileName_example";  // string |  (optional) 
            var mimeType = "mimeType_example";  // string |  (optional) 

            try
            {
                CompleteUploadResponse result = apiInstance.ApiV1DcpAssetsCompleteUploadGet(path, uploadToken, fileName, mimeType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.ApiV1DcpAssetsCompleteUploadGet: " + e.Message );
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
 **path** | **string**|  | [optional] 
 **uploadToken** | **string**|  | [optional] 
 **fileName** | **string**|  | [optional] 
 **mimeType** | **string**|  | [optional] 

### Return type

[**CompleteUploadResponse**](CompleteUploadResponse.md)

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

<a name="apiv1dcpassetsdeletedelete"></a>
# **ApiV1DcpAssetsDeleteDelete**
> void ApiV1DcpAssetsDeleteDelete (string assetPath = null, string fileName = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.ContentWebApiClient.Client;
using FranchiseePortal.ContentWebApiClient.Model;

namespace Example
{
    public class ApiV1DcpAssetsDeleteDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AssetsApi(config);
            var assetPath = "assetPath_example";  // string |  (optional) 
            var fileName = "fileName_example";  // string |  (optional) 

            try
            {
                apiInstance.ApiV1DcpAssetsDeleteDelete(assetPath, fileName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.ApiV1DcpAssetsDeleteDelete: " + e.Message );
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
 **assetPath** | **string**|  | [optional] 
 **fileName** | **string**|  | [optional] 

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

<a name="apiv1dcpassetsimageuploadlocationget"></a>
# **ApiV1DcpAssetsImageUploadLocationGet**
> InitiateUploadResponse ApiV1DcpAssetsImageUploadLocationGet (string path = null, string fileName = null, int? fileSize = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.ContentWebApiClient.Client;
using FranchiseePortal.ContentWebApiClient.Model;

namespace Example
{
    public class ApiV1DcpAssetsImageUploadLocationGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AssetsApi(config);
            var path = "path_example";  // string |  (optional) 
            var fileName = "fileName_example";  // string |  (optional) 
            var fileSize = 56;  // int? |  (optional) 

            try
            {
                InitiateUploadResponse result = apiInstance.ApiV1DcpAssetsImageUploadLocationGet(path, fileName, fileSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.ApiV1DcpAssetsImageUploadLocationGet: " + e.Message );
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
 **path** | **string**|  | [optional] 
 **fileName** | **string**|  | [optional] 
 **fileSize** | **int?**|  | [optional] 

### Return type

[**InitiateUploadResponse**](InitiateUploadResponse.md)

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

<a name="apiv1dcpassetsimageuploadlocationpost"></a>
# **ApiV1DcpAssetsImageUploadLocationPost**
> InitiateUploadResponse ApiV1DcpAssetsImageUploadLocationPost (string path = null, string fileName = null, int? fileSize = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.ContentWebApiClient.Client;
using FranchiseePortal.ContentWebApiClient.Model;

namespace Example
{
    public class ApiV1DcpAssetsImageUploadLocationPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AssetsApi(config);
            var path = "path_example";  // string |  (optional) 
            var fileName = "fileName_example";  // string |  (optional) 
            var fileSize = 56;  // int? |  (optional) 

            try
            {
                InitiateUploadResponse result = apiInstance.ApiV1DcpAssetsImageUploadLocationPost(path, fileName, fileSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.ApiV1DcpAssetsImageUploadLocationPost: " + e.Message );
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
 **path** | **string**|  | [optional] 
 **fileName** | **string**|  | [optional] 
 **fileSize** | **int?**|  | [optional] 

### Return type

[**InitiateUploadResponse**](InitiateUploadResponse.md)

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

<a name="apiv1dcpassetsimagespathget"></a>
# **ApiV1DcpAssetsImagesPathGet**
> List&lt;OriginalAsset&gt; ApiV1DcpAssetsImagesPathGet (string path)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.ContentWebApiClient.Client;
using FranchiseePortal.ContentWebApiClient.Model;

namespace Example
{
    public class ApiV1DcpAssetsImagesPathGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AssetsApi(config);
            var path = "path_example";  // string | 

            try
            {
                List<OriginalAsset> result = apiInstance.ApiV1DcpAssetsImagesPathGet(path);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.ApiV1DcpAssetsImagesPathGet: " + e.Message );
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
 **path** | **string**|  | 

### Return type

[**List&lt;OriginalAsset&gt;**](OriginalAsset.md)

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
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1dcpassetspublishpost"></a>
# **ApiV1DcpAssetsPublishPost**
> void ApiV1DcpAssetsPublishPost (string assetPath = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.ContentWebApiClient.Client;
using FranchiseePortal.ContentWebApiClient.Model;

namespace Example
{
    public class ApiV1DcpAssetsPublishPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AssetsApi(config);
            var assetPath = "assetPath_example";  // string |  (optional) 

            try
            {
                apiInstance.ApiV1DcpAssetsPublishPost(assetPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.ApiV1DcpAssetsPublishPost: " + e.Message );
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
 **assetPath** | **string**|  | [optional] 

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

<a name="apiv1dcpassetsschoolheroimagesget"></a>
# **ApiV1DcpAssetsSchoolHeroImagesGet**
> List&lt;OriginalAsset&gt; ApiV1DcpAssetsSchoolHeroImagesGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.ContentWebApiClient.Client;
using FranchiseePortal.ContentWebApiClient.Model;

namespace Example
{
    public class ApiV1DcpAssetsSchoolHeroImagesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AssetsApi(config);

            try
            {
                List<OriginalAsset> result = apiInstance.ApiV1DcpAssetsSchoolHeroImagesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.ApiV1DcpAssetsSchoolHeroImagesGet: " + e.Message );
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

[**List&lt;OriginalAsset&gt;**](OriginalAsset.md)

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
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

