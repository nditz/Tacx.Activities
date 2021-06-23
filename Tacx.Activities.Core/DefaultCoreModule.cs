using Autofac;
using Tacx.Activities.Core.Interfaces;
using Tacx.Activities.Core.Services;

namespace Tacx.Activities.Core
{
    public class DefaultCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ToDoItemSearchService>()
                .As<IToDoItemSearchService>().InstancePerLifetimeScope();
        }
    }
}
