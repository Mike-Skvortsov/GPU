using Database.Repositories.Interfaces;
using Entities;

namespace Database.Repositories.Implements
{
	public class ManufacturerRepository : BaseRepository<Manufacturer>, IManufacturerRepository
	{
		public ManufacturerRepository(DBContext dbContext) : base(dbContext)
		{ }
	}
}
