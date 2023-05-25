using System;
using System.Collections.Generic;
using System.Text;

namespace FranchiseePortal.Sessions.Dto
{
    public class SchoolInfoDto
    {
        public string CrmId { get; set; }
        public string FmsId { get; set; }
        public string AdvertisingName { get; set; }
        public string Hours { get; set; }
        public AddressDto Address { get; set; }        
    }
}
