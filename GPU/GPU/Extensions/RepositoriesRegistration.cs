using BLL.Services.Implements;
using BLL.Services.Interfaces;
using Database.Repositories.Implements;
using Database.Repositories.Interfaces;

namespace GPU.Extensions
{
	internal static class RepositoriesRegistration
	{
		public static IServiceCollection RepositoriesRegister(this IServiceCollection services)
		{
			services.AddTransient<IProductRepository, ProductRepository>();
			services.AddTransient<IManufacturerRepository, ManufacturerRepository>();
			services.AddTransient<IOrderRepository, OrderRepository>();
			return services;
		}
	}
}
