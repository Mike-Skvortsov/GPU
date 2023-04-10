using BLL.Services.Interfaces;
using Database.Repositories.Interfaces;
using Entities;

namespace BLL.Services.Implements
{
	public class UserService : IUserService
	{
		private readonly IUserRepository _repository;
		public UserService(IUserRepository repository)
		{
			this._repository = repository;
		}
		public Task<IEnumerable<User>> GetAllAsync() => this._repository.GetAllAsync();

	}
}
