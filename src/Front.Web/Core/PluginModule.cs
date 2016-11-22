using Autofac;
using Connector.Interfaces;
using Microsoft.Extensions.DependencyModel;
using System.Linq;
using System.Reflection;

namespace Front.Web.Core
{
    public class PluginModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var connectorInterface = typeof(ITodoConnector);

            var libs = DependencyContext.Default.RuntimeLibraries
                .Where(m => m.Name.StartsWith("Connector.", System.StringComparison.OrdinalIgnoreCase));

            foreach (var lib in libs)
            {
                var assembly = Assembly.Load(new AssemblyName(lib.Name));

                builder.RegisterAssemblyTypes(assembly)
                   .AsImplementedInterfaces()
                   .AssignableTo<ITodoConnector>();

                builder.RegisterAssemblyModules(assembly);
            }
        }
    }
}
