using BLL.DTO.Manufacturer;
using Entities;

namespace BLL.Services.Interfaces
{
	public interface IManufacturerService
	{
		Task<IEnumerable<ManufacturerDTOWithId>> GetAllAsync();
		Task<ManufacturerDTO> GetManufacturerById(int id);
	}
}
