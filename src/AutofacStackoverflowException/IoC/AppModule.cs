using Autofac;
using Facade.Impl.Repositories;
using Facade.Impl.UoW;
using Facade.Repositories;
using Facade.UoW;
using System;
using System.Linq;
using System.Reflection;

namespace AutofacStackoverflowException.IoC
{
    public class AppModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterAssemblyTypes(typeof(UnitOfWork).GetTypeInfo().Assembly)
            //    .Where(t => t.Name.EndsWith("Repository", StringComparison.Ordinal))
            //    .As(t => t.GetInterfaces().Single(i => i.Name.EndsWith(t.Name)))
            //    .InstancePerLifetimeScope()
            //    .PropertiesAutowired(PropertyWiringOptions.AllowCircularDependencies);

            builder.RegisterType<TicketsRepository>()
                .As<ITicketsRepository>()
                .InstancePerLifetimeScope()
                .PropertiesAutowired(PropertyWiringOptions.AllowCircularDependencies);

            builder.RegisterType<OrdersRepository>()
                .As<IOrdersRepository>()
                .InstancePerLifetimeScope()
                .PropertiesAutowired(PropertyWiringOptions.AllowCircularDependencies);

            builder.RegisterType<UsersRepository>()
                .As<IUsersRepository>()
                .InstancePerLifetimeScope()
                .PropertiesAutowired(PropertyWiringOptions.AllowCircularDependencies);

            builder.RegisterType<UnitOfWork>()
                .As<IUnitOfWork>()
                .InstancePerLifetimeScope()
                .PropertiesAutowired(PropertyWiringOptions.AllowCircularDependencies);
        }
    }
}
