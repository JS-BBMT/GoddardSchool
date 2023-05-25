namespace FranchiseePortal.Authorization.Schools
{
    /// <summary>
    /// Operations on a school
    /// Based on: https://docs.microsoft.com/en-us/aspnet/core/security/authorization/resourcebased?view=aspnetcore-5.0#operational-requirements
    /// </summary>
    public static class SchoolOperations
    {
        public static SchoolOperationAuthorizationRequirement Create =
       new SchoolOperationAuthorizationRequirement { Name = nameof(Create) };
        public static SchoolOperationAuthorizationRequirement Read =
            new SchoolOperationAuthorizationRequirement { Name = nameof(Read) };
        public static SchoolOperationAuthorizationRequirement Update =
            new SchoolOperationAuthorizationRequirement { Name = nameof(Update) };
        public static SchoolOperationAuthorizationRequirement Delete =
            new SchoolOperationAuthorizationRequirement { Name = nameof(Delete) };
    }
}
