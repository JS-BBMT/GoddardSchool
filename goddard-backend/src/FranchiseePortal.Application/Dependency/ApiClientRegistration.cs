using Castle.MicroKernel;
using Castle.MicroKernel.Registration;
namespace FranchiseePortal.Dependency
{
    /// <summary>
    /// Decorator around IRegistration to have our own type
    /// </summary>
    public class ApiClientRegistration : IRegistration
    {
        private readonly IRegistration _inner;

        private ApiClientRegistration(IRegistration inner)
        {
            _inner = inner;
        }

        public static ApiClientRegistration Create<TType, TImpl>()
            where TType : class
            where TImpl : TType
        {
            return new ApiClientRegistration(Component.For<TType>()
                .ImplementedBy<TImpl>()
                .LifeStyle.Transient);
        }

        public void Register(IKernelInternal kernel)
        {
            _inner.Register(kernel);
        }
    }
}
