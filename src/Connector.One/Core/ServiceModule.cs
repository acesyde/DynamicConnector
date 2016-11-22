using Autofac;

namespace Connector.One.Core
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Services.MyService>().As<Services.IMyService>();
        }
    }
}
