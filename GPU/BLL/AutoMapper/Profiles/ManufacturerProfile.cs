using AutoMapper;
using BLL.DTO.Manufacturer;
using BLL.DTO.ProductDTO;
using Entities;

namespace BLL.AutoMapper.Profiles
{
	public class ManufacturerProfile: Profile
	{
		public ManufacturerProfile()
		{
			CreateMap<Manufacturer, ManufacturerDTO>();
			CreateMap<ManufacturerDTO, Manufacturer>();
			CreateMap<Manufacturer, ManufacturerDTOWithId>();
			CreateMap<ManufacturerDTOWithId, Manufacturer>();

		}
	}
}
	