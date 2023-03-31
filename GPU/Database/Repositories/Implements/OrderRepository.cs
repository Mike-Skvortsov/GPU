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
	public class OrderRepository : IOrderRepository
	{
		private readonly DBContext _context;
		public OrderRepository(DBContext context)
		{
			this._context = context;
		}
		public async Task<ICollection<Order>> GetAllAsync()
		{
			return await this._context.Orders.Include(x => x.Products).ToListAsync();
		}
	}
}
