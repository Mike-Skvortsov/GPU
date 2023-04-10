using BLL.AutoMapper.Profiles;

namespace GPU.Extensions
{
	internal static class AutoMapperRegistration
	{
		public static IServiceCollection AutoMapperProfilesRegister(this IServiceCollection services)
		{
			services.AddAutoMapper(typeof(ProductProfile));
			return services;
		}
	}
}
