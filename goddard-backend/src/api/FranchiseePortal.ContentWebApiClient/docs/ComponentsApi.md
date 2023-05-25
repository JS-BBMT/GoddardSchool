# FranchiseePortal.ContentWebApiClient.Api.ComponentsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1DcpComponentsAssetListGet**](ComponentsApi.md#apiv1dcpcomponentsassetlistget) | **GET** /api/v1/dcp/components/asset-list | 
[**ApiV1DcpComponentsAssetListPut**](ComponentsApi.md#apiv1dcpcomponentsassetlistput) | **PUT** /api/v1/dcp/components/asset-list | 
[**ApiV1DcpComponentsCarouselGet**](ComponentsApi.md#apiv1dcpcomponentscarouselget) | **GET** /api/v1/dcp/components/carousel | 
[**ApiV1DcpComponentsCarouselPut**](ComponentsApi.md#apiv1dcpcomponentscarouselput) | **PUT** /api/v1/dcp/components/carousel | 
[**ApiV1DcpComponentsImageCardsGet**](ComponentsApi.md#apiv1dcpcomponentsimagecardsget) | **GET** /api/v1/dcp/components/image-cards | 
[**ApiV1DcpComponentsImageCardsPut**](ComponentsApi.md#apiv1dcpcomponentsimagecardsput) | **PUT** /api/v1/dcp/components/image-cards | 
[**ApiV1DcpComponentsTextGet**](ComponentsApi.md#apiv1dcpcomponentstextget) | **GET** /api/v1/dcp/components/text | 
[**ApiV1DcpComponentsTextPut**](ComponentsApi.md#apiv1dcpcomponentstextput) | **PUT** /api/v1/dcp/components/text | 
[**ApiV1DcpComponentsTitleGet**](ComponentsApi.md#apiv1dcpcomponentstitleget) | **GET** /api/v1/dcp/components/title | 
[**ApiV1DcpComponentsTitlePut**](ComponentsApi.md#apiv1dcpcomponentstitleput) | **PUT** /api/v1/dcp/components/title | 


<a name="apiv1dcpcomponentsassetlistget"></a>
# **ApiV1DcpComponentsAssetListGet**
> AssetListDto ApiV1DcpComponentsAssetListGet (string path = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.ContentWebApiClient.Client;
using FranchiseePortal.ContentWebApiClient.Model;

namespace Example
{
    public class ApiV1DcpComponentsAssetListGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ComponentsApi(config);
            var path = "path_example";  // string |  (optional) 

            try
            {
                AssetListDto result = apiInstance.ApiV1DcpComponentsAssetListGet(path);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComponentsApi.ApiV1DcpComponentsAssetListGet: " + e.Message );
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

### Return type

[**AssetListDto**](AssetListDto.md)

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

<a name="apiv1dcpcomponentsassetlistput"></a>
# **ApiV1DcpComponentsAssetListPut**
> AssetListDto ApiV1DcpComponentsAssetListPut (string path = null, AssetListDto assetListDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.ContentWebApiClient.Client;
using FranchiseePortal.ContentWebApiClient.Model;

namespace Example
{
    public class ApiV1DcpComponentsAssetListPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ComponentsApi(config);
            var path = "path_example";  // string |  (optional) 
            var assetListDto = new AssetListDto(); // AssetListDto |  (optional) 

            try
            {
                AssetListDto result = apiInstance.ApiV1DcpComponentsAssetListPut(path, assetListDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComponentsApi.ApiV1DcpComponentsAssetListPut: " + e.Message );
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
 **assetListDto** | [**AssetListDto**](AssetListDto.md)|  | [optional] 

### Return type

[**AssetListDto**](AssetListDto.md)

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

<a name="apiv1dcpcomponentscarouselget"></a>
# **ApiV1DcpComponentsCarouselGet**
> CarouselDto ApiV1DcpComponentsCarouselGet (string path = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.ContentWebApiClient.Client;
using FranchiseePortal.ContentWebApiClient.Model;

namespace Example
{
    public class ApiV1DcpComponentsCarouselGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ComponentsApi(config);
            var path = "path_example";  // string |  (optional) 

            try
            {
                CarouselDto result = apiInstance.ApiV1DcpComponentsCarouselGet(path);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComponentsApi.ApiV1DcpComponentsCarouselGet: " + e.Message );
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

### Return type

[**CarouselDto**](CarouselDto.md)

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

<a name="apiv1dcpcomponentscarouselput"></a>
# **ApiV1DcpComponentsCarouselPut**
> CarouselDto ApiV1DcpComponentsCarouselPut (string path = null, List<CarouselItemDto> carouselItemDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.ContentWebApiClient.Client;
using FranchiseePortal.ContentWebApiClient.Model;

namespace Example
{
    public class ApiV1DcpComponentsCarouselPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ComponentsApi(config);
            var path = "path_example";  // string |  (optional) 
            var carouselItemDto = new List<CarouselItemDto>(); // List<CarouselItemDto> |  (optional) 

            try
            {
                CarouselDto result = apiInstance.ApiV1DcpComponentsCarouselPut(path, carouselItemDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComponentsApi.ApiV1DcpComponentsCarouselPut: " + e.Message );
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
 **carouselItemDto** | [**List&lt;CarouselItemDto&gt;**](CarouselItemDto.md)|  | [optional] 

### Return type

[**CarouselDto**](CarouselDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1dcpcomponentsimagecardsget"></a>
# **ApiV1DcpComponentsImageCardsGet**
> List&lt;ImageCardDto&gt; ApiV1DcpComponentsImageCardsGet (string path = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.ContentWebApiClient.Client;
using FranchiseePortal.ContentWebApiClient.Model;

namespace Example
{
    public class ApiV1DcpComponentsImageCardsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ComponentsApi(config);
            var path = "path_example";  // string |  (optional) 

            try
            {
                List<ImageCardDto> result = apiInstance.ApiV1DcpComponentsImageCardsGet(path);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComponentsApi.ApiV1DcpComponentsImageCardsGet: " + e.Message );
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

### Return type

[**List&lt;ImageCardDto&gt;**](ImageCardDto.md)

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

<a name="apiv1dcpcomponentsimagecardsput"></a>
# **ApiV1DcpComponentsImageCardsPut**
> void ApiV1DcpComponentsImageCardsPut (string path = null, List<ImageCardUpdateDto> imageCardUpdateDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.ContentWebApiClient.Client;
using FranchiseePortal.ContentWebApiClient.Model;

namespace Example
{
    public class ApiV1DcpComponentsImageCardsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ComponentsApi(config);
            var path = "path_example";  // string |  (optional) 
            var imageCardUpdateDto = new List<ImageCardUpdateDto>(); // List<ImageCardUpdateDto> |  (optional) 

            try
            {
                apiInstance.ApiV1DcpComponentsImageCardsPut(path, imageCardUpdateDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComponentsApi.ApiV1DcpComponentsImageCardsPut: " + e.Message );
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
 **imageCardUpdateDto** | [**List&lt;ImageCardUpdateDto&gt;**](ImageCardUpdateDto.md)|  | [optional] 

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

<a name="apiv1dcpcomponentstextget"></a>
# **ApiV1DcpComponentsTextGet**
> TextComponentDto ApiV1DcpComponentsTextGet (string path = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.ContentWebApiClient.Client;
using FranchiseePortal.ContentWebApiClient.Model;

namespace Example
{
    public class ApiV1DcpComponentsTextGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ComponentsApi(config);
            var path = "path_example";  // string |  (optional) 

            try
            {
                TextComponentDto result = apiInstance.ApiV1DcpComponentsTextGet(path);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComponentsApi.ApiV1DcpComponentsTextGet: " + e.Message );
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

### Return type

[**TextComponentDto**](TextComponentDto.md)

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

<a name="apiv1dcpcomponentstextput"></a>
# **ApiV1DcpComponentsTextPut**
> void ApiV1DcpComponentsTextPut (string path = null, TextComponentUpdateDto textComponentUpdateDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.ContentWebApiClient.Client;
using FranchiseePortal.ContentWebApiClient.Model;

namespace Example
{
    public class ApiV1DcpComponentsTextPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ComponentsApi(config);
            var path = "path_example";  // string |  (optional) 
            var textComponentUpdateDto = new TextComponentUpdateDto(); // TextComponentUpdateDto |  (optional) 

            try
            {
                apiInstance.ApiV1DcpComponentsTextPut(path, textComponentUpdateDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComponentsApi.ApiV1DcpComponentsTextPut: " + e.Message );
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
 **textComponentUpdateDto** | [**TextComponentUpdateDto**](TextComponentUpdateDto.md)|  | [optional] 

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

<a name="apiv1dcpcomponentstitleget"></a>
# **ApiV1DcpComponentsTitleGet**
> TitleComponentDto ApiV1DcpComponentsTitleGet (string path = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.ContentWebApiClient.Client;
using FranchiseePortal.ContentWebApiClient.Model;

namespace Example
{
    public class ApiV1DcpComponentsTitleGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ComponentsApi(config);
            var path = "path_example";  // string |  (optional) 

            try
            {
                TitleComponentDto result = apiInstance.ApiV1DcpComponentsTitleGet(path);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComponentsApi.ApiV1DcpComponentsTitleGet: " + e.Message );
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

### Return type

[**TitleComponentDto**](TitleComponentDto.md)

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

<a name="apiv1dcpcomponentstitleput"></a>
# **ApiV1DcpComponentsTitlePut**
> void ApiV1DcpComponentsTitlePut (string path = null, TitleComponentUpdateDto titleComponentUpdateDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.ContentWebApiClient.Client;
using FranchiseePortal.ContentWebApiClient.Model;

namespace Example
{
    public class ApiV1DcpComponentsTitlePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ComponentsApi(config);
            var path = "path_example";  // string |  (optional) 
            var titleComponentUpdateDto = new TitleComponentUpdateDto(); // TitleComponentUpdateDto |  (optional) 

            try
            {
                apiInstance.ApiV1DcpComponentsTitlePut(path, titleComponentUpdateDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComponentsApi.ApiV1DcpComponentsTitlePut: " + e.Message );
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
 **titleComponentUpdateDto** | [**TitleComponentUpdateDto**](TitleComponentUpdateDto.md)|  | [optional] 

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

