using Database.Repositories.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositories.Implements
{
	public class ManufacturerService : IManufacturerService
	{
		private readonly IManufacturerRepository _repository;
		public ManufacturerService(IManufacturerRepository repository)
		{
			this._repository = repository;
		}
		public Task<ICollection<Manufacturer>> GetAllAsync() => this._repository.GetAllAsync();

	}
}
