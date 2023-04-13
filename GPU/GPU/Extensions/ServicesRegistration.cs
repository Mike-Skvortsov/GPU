using BLL.Services.Implements;
using BLL.Services.Interfaces;

namespace GPU.Extensions
{
	internal static class ServicesRegistration
	{
		public static IServiceCollection ServicesRegister(this IServiceCollection services)
		{
			services.AddTransient<IProductService, ProductService>();
			services.AddTransient<IManufacturerService, ManufacturerService>();
			services.AddTransient<IOrderService, OrderService>();
			return services;
		}
	}
}
