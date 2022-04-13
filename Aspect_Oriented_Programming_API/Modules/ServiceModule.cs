using Aspect_Oriented_Programming_API.Interceptors;
using Aspect_Oriented_Programming_API.Services;
using Autofac;
using Autofac.Extras.DynamicProxy;

namespace Aspect_Oriented_Programming_API.Modules
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LoggingInterceptor>();
            builder.RegisterType<AuthenticationInterceptor>();

            builder.RegisterType<CustomerService>()
                .As<ICustomerService>()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(LoggingInterceptor))
                .InterceptedBy(typeof(AuthenticationInterceptor));

            base.Load(builder);
        }
    }
}