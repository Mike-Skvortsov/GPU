using BLL.Services.Interfaces;
using Database.Repositories.Interfaces;
using Entities;

namespace BLL.Services.Implements
{
	public class ManufacturerService : IManufacturerService
	{
		private readonly IManufacturerRepository _repository;
		public ManufacturerService(IManufacturerRepository repository)
		{
			this._repository = repository;
		}
		public Task<IEnumerable<Manufacturer>> GetAllAsync() => this._repository.GetAllAsync();

	}
}
