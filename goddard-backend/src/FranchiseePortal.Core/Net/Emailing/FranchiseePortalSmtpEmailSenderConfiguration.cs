using Abp.Configuration;
using Abp.Net.Mail;
using Abp.Net.Mail.Smtp;
using Abp.Runtime.Security;

namespace FranchiseePortal.Net.Emailing
{
    public class FranchiseePortalSmtpEmailSenderConfiguration : SmtpEmailSenderConfiguration
    {
        public FranchiseePortalSmtpEmailSenderConfiguration(ISettingManager settingManager) : base(settingManager)
        {

        }

        public override string Password => SimpleStringCipher.Instance.Decrypt(GetNotEmptySettingValue(EmailSettingNames.Smtp.Password));
    }
}