using FranchiseePortal.TestimonialsWebApiClient.Model;
using System.Threading.Tasks;

namespace FranchiseePortal.TestimonialsEditor
{
    public interface ITestimonialsEditorService
    {
        Task<Testimonial> SaveTestimonial(TestimonialDto testimonialDto);
    }
}
