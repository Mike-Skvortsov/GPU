using AutoMapper;
using BLL.DTO.ProductDTO;
using BLL.Services.Interfaces;
using Entities;

namespace BLL.AutoMapper.Profiles
{
	public class ProductProfile : Profile
	{
		private readonly IManufacturerService _manufacturerService;

		public ProductProfile(IManufacturerService manufacturerService)
		{
			_manufacturerService = manufacturerService;

			CreateMap<Product, AllProductDTO>();
			CreateMap<Product, ProductById>()
				.ForMember(x => x.Manufacturer, opt => opt.MapFrom(y => _manufacturerService.GetManufacturerById(y.ManufacturerId)));
		}

		public ProductProfile() : this(null)
		{
		}
	}
}
