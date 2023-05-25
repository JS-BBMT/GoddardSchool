using Abp.AspNetZeroCore.Web.Authentication.External;
using Abp.Extensions;

namespace FranchiseePortal.Web.Authentication.External {
    public class MicrosoftExternalLoginInfoManager : DefaultExternalLoginInfoManager {
        public override string GetUserNameFromExternalAuthUserInfo(ExternalAuthUserInfo userInfo)
        {
            return userInfo.EmailAddress;
        }
    }
}
