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
	public class ProductRepository: IProductRepository
	{
		private readonly DBContext _context;
		public ProductRepository(DBContext context)
		{
			this._context = context;
		}
		public async Task<ICollection<Product>> GetAllAsync()
		{
			return await this._context.Products.Include(x => x.Manufacturer).ToListAsync();
		}
	}
}
