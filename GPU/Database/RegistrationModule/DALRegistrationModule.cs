using Autofac;
using Database.Repositories.Implements;
using Database.Repositories.Interfaces;

namespace Database.RegostrationModule
{
	public class DALRegistrationModule : Autofac.Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<DBContext>().AsSelf().InstancePerLifetimeScope();
			builder.RegisterType<ProductRepository>().As<IProductRepository>();
			builder.RegisterType<ManufacturerRepository>().As<IManufacturerRepository>();
			builder.RegisterType<UserRepository>().As<IUserRepository>();
			builder.RegisterType<OrderRepository>().As<IOrderRepository>();
		}
	}
}
