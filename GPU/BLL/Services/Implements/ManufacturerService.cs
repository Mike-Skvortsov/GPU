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
	}
}
