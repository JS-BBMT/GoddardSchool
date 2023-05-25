namespace FranchiseePortal.Configuration
{
    /// <summary>
    /// Configuration for API clients
    /// </summary>
    public class ApiClientConfiguration
    {
        public const string AUTHORIZATION_SECTION = "App:Authorization";
        public const string CAREERS_SECTION = "App:Careers";
        public const string CONTENT_SECTION = "App:Content";
        public const string EVENTS_SECTION = "App:Events";
        public const string FACULTY_SECTION = "App:Faculty";
        public const string FEATURES_SECTION = "App:Features";
        public const string LEADS_SECTION = "App:Leads";
        public const string SCHOOLS_SECTION = "App:School";
        public const string TESTIMONIALS_SECTION = "App:Testimonials";
        public const string TOURS_SECTION = "App:Tours";

        public string APIUrl { get; set; }
    }
}
