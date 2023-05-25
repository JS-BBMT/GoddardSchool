# FranchiseePortal.TestimonialsWebApiClient.Api.TestimonialsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1AddtestimonialsPost**](TestimonialsApi.md#apiv1addtestimonialspost) | **POST** /api/v1/addtestimonials | 
[**ApiV1TestimonialsGet**](TestimonialsApi.md#apiv1testimonialsget) | **GET** /api/v1/testimonials | 
[**ApiV1UnpublishedTestimonialsGet**](TestimonialsApi.md#apiv1unpublishedtestimonialsget) | **GET** /api/v1/unpublished-testimonials | 


<a name="apiv1addtestimonialspost"></a>
# **ApiV1AddtestimonialsPost**
> Testimonial ApiV1AddtestimonialsPost (TestimonialDto testimonialDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.TestimonialsWebApiClient.Api;
using FranchiseePortal.TestimonialsWebApiClient.Client;
using FranchiseePortal.TestimonialsWebApiClient.Model;

namespace Example
{
    public class ApiV1AddtestimonialsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TestimonialsApi(config);
            var testimonialDto = new TestimonialDto(); // TestimonialDto |  (optional) 

            try
            {
                Testimonial result = apiInstance.ApiV1AddtestimonialsPost(testimonialDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestimonialsApi.ApiV1AddtestimonialsPost: " + e.Message );
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
 **testimonialDto** | [**TestimonialDto**](TestimonialDto.md)|  | [optional] 

### Return type

[**Testimonial**](Testimonial.md)

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

<a name="apiv1testimonialsget"></a>
# **ApiV1TestimonialsGet**
> TestimonialPagedResponse ApiV1TestimonialsGet (string fmsSchoolId = null, int? page = null, int? pageSize = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.TestimonialsWebApiClient.Api;
using FranchiseePortal.TestimonialsWebApiClient.Client;
using FranchiseePortal.TestimonialsWebApiClient.Model;

namespace Example
{
    public class ApiV1TestimonialsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TestimonialsApi(config);
            var fmsSchoolId = fmsSchoolId_example;  // string |  (optional) 
            var page = 56;  // int? |  (optional)  (default to 1)
            var pageSize = 56;  // int? |  (optional)  (default to 20)

            try
            {
                TestimonialPagedResponse result = apiInstance.ApiV1TestimonialsGet(fmsSchoolId, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestimonialsApi.ApiV1TestimonialsGet: " + e.Message );
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
 **page** | **int?**|  | [optional] [default to 1]
 **pageSize** | **int?**|  | [optional] [default to 20]

### Return type

[**TestimonialPagedResponse**](TestimonialPagedResponse.md)

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

<a name="apiv1unpublishedtestimonialsget"></a>
# **ApiV1UnpublishedTestimonialsGet**
> GetUnpublishedTestimonialResultPagedResponse ApiV1UnpublishedTestimonialsGet (string fmsSchoolId, int? page = null, int? pageSize = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.TestimonialsWebApiClient.Api;
using FranchiseePortal.TestimonialsWebApiClient.Client;
using FranchiseePortal.TestimonialsWebApiClient.Model;

namespace Example
{
    public class ApiV1UnpublishedTestimonialsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TestimonialsApi(config);
            var fmsSchoolId = fmsSchoolId_example;  // string | 
            var page = 56;  // int? |  (optional)  (default to 1)
            var pageSize = 56;  // int? |  (optional)  (default to 20)

            try
            {
                GetUnpublishedTestimonialResultPagedResponse result = apiInstance.ApiV1UnpublishedTestimonialsGet(fmsSchoolId, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestimonialsApi.ApiV1UnpublishedTestimonialsGet: " + e.Message );
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
 **fmsSchoolId** | **string**|  | 
 **page** | **int?**|  | [optional] [default to 1]
 **pageSize** | **int?**|  | [optional] [default to 20]

### Return type

[**GetUnpublishedTestimonialResultPagedResponse**](GetUnpublishedTestimonialResultPagedResponse.md)

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

