using Entities;

namespace BLL.Services.Interfaces
{
	public interface IUserService
	{
		Task<IEnumerable<User>> GetAllAsync();
	}
}
