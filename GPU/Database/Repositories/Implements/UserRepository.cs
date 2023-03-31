using Database.Repositories.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositories.Implements
{
	public class UserRepository: IUserRepository
	{
		private readonly DBContext _context;
		public UserRepository(DBContext context)
		{
			this._context = context;
		}
		public async Task<ICollection<User>> GetAllAsync()
		{
			return await this._context.Users.ToListAsync();
		}
	}
}
