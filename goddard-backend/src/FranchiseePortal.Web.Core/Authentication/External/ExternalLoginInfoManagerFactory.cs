using Abp.Dependency;

namespace FranchiseePortal.Web.Authentication.External
{
    public class ExternalLoginInfoManagerFactory : ITransientDependency
    {
        private readonly IIocManager _iocManager;

        public ExternalLoginInfoManagerFactory(IIocManager iocManager)
        {
            _iocManager = iocManager;
        }

        public IDisposableDependencyObjectWrapper<IExternalLoginInfoManager> GetExternalLoginInfoManager(string loginProvider)
        {
            if (loginProvider == "WsFederation")
            {
                return _iocManager.ResolveAsDisposable<WsFederationExternalLoginInfoManager>();
            }

            if (loginProvider == "Microsoft") {
                return _iocManager.ResolveAsDisposable<MicrosoftExternalLoginInfoManager>();
            }

            return _iocManager.ResolveAsDisposable<DefaultExternalLoginInfoManager>();
        }
    }
}
