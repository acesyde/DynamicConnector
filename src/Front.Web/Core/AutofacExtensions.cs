using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Front.Web.Core
{
    public static class AutofacExtensions
    {
        public static IServiceProvider RegisterAutofac(this IServiceCollection services, ref IContainer applicationContainer)
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<PluginModule>();
            builder.Populate(services);
            applicationContainer = builder.Build();

            return new AutofacServiceProvider(applicationContainer);
        }
    }
}
