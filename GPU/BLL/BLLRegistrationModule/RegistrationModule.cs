using Autofac;
using BLL.Services.Implements;
using BLL.Services.Interfaces;
using Database.RegostrationModule;

namespace BLL.RegistrationModule
{
	public class RegistrationModule : Autofac.Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterModule<DALRegistrationModule>();
			builder.RegisterType<UserService>().As<IUserService>();
			builder.RegisterType<OrderService>().As<IOrderService>();
			builder.RegisterType<ManufacturerService>().As<IManufacturerService>();
			builder.RegisterType<ProductService>().As<IProductService>();
		}
	}
}
