namespace FranchiseePortal.Sessions.Dto
{
    public class AddressDto
    {
        public string City { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public double? Longitude { get; set; }
        public string PostalCode { get; set; }
        public string StateOrProvince { get; set; }
    }
}
