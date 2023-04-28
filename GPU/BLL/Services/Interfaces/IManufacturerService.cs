using BLL.DTO.Manufacturer;
using BLL.DTO.OrderDTO;
using Entities;

namespace BLL.Services.Interfaces
{
	public interface IManufacturerService
	{
		Task<IEnumerable<ManufacturerDTOWithId>> GetAllAsync();
		Task<ManufacturerDTO> GetManufacturerById(int id);
		Task<ManufacturerDTO> CreateAsync(ManufacturerDTO newManufacturer);
		Task<bool> DeleteAsync(int id);
		Task<ManufacturerDTOWithId> UpdateAsync(ManufacturerDTOWithId manufacturer);
	}
}
