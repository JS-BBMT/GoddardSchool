using System;
using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Users;

namespace FranchiseePortal.Web.Models.TokenAuth
{
    public class ExternalAuthenticateModel
    {
        [Required]
        [MaxLength(UserLogin.MaxLoginProviderLength)]
        public string AuthProvider { get; set; }

        [Required]
        [MaxLength(UserLogin.MaxProviderKeyLength)]
        public string ProviderKey { get; set; }

        [Required]
        public string ProviderAccessCode { get; set; }

        public string ReturnUrl { get; set; }

        public bool? SingleSignIn { get; set; }

        // Adding token expiration for a server side compare
        public DateTimeOffset? TokenExpiration { get; set; }
    }
}
