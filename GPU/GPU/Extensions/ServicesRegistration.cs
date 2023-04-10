using Database.Repositories.Implements;
using Database.Repositories.Interfaces;

namespace GPU.Extensions
{
	internal static class ServicesRegistration
	{
		public static IServiceCollection ServicesRegister(this IServiceCollection services)
		{
			services.AddTransient<IProductRepository, ProductRepository>();
			return services;
		}
	}
}
