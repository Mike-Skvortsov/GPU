using AutoMapper;
using BLL.DTO.Manufacturer;
using BLL.Services.Interfaces;
using Database.Repositories.Interfaces;
using Entities;

namespace BLL.Services.Implements
{
	public class ManufacturerService : IManufacturerService
	{
		private readonly IManufacturerRepository _repository;
		private readonly IMapper _mapper;

		public ManufacturerService(IManufacturerRepository repository, IMapper mapper)
		{
			this._repository = repository;
			_mapper = mapper;
		}
		public async Task<IEnumerable<ManufacturerDTOWithId>> GetAllAsync()
		{	

			var manufacturers = await _repository.GetAllAsync();
			return _mapper.Map<IEnumerable<ManufacturerDTOWithId>>(manufacturers);
		}

		public async Task<ManufacturerDTO> GetManufacturerById(int id)
		{
			var manufacturer = await _repository.GetByIdAsync(id);
			return _mapper.Map<ManufacturerDTO>(manufacturer);
		}
		public async Task<ManufacturerDTO> CreateAsync(ManufacturerDTO newManufacturer)
		{
			var manufacturer = await _repository.AddAsync(_mapper.Map<Manufacturer>(newManufacturer));
			return _mapper.Map<ManufacturerDTO>(manufacturer);
		}
		public async Task<bool> DeleteAsync(int id)
		{
			var deletedManufacturer = await _repository.DeleteByIdAsync(id);
			return deletedManufacturer;
		}
		public async Task<ManufacturerDTOWithId> UpdateAsync(ManufacturerDTOWithId manufacturer)
		{
			var updatedManufacturer = await _repository.UpdateAsync(_mapper.Map<Manufacturer>(manufacturer));

			return _mapper.Map<ManufacturerDTOWithId>(updatedManufacturer);
		}
	}
}
