using AutoMapper;
using BLL.AutoMapper.Profiles;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace GPU.Extensions
{
	internal static class AutoMapperRegistration
	{
		public static IServiceCollection AddAutoMapperProfiles(this IServiceCollection services)
		{
			services.AddAutoMapper(typeof(ProductProfile), typeof(ManufacturerProfile));
			services.AddAutoMapper(typeof(OrderProfile));

			return services;
		}
	}
}
