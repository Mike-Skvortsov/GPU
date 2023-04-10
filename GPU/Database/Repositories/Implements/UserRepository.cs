using Database.Repositories.Interfaces;
using Entities;

namespace Database.Repositories.Implements
{
	public class UserRepository : BaseRepository<User>, IUserRepository
	{
		public UserRepository(DBContext dbContext) : base(dbContext)
		{
		}
	}
}
