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
	public class ManufacturerRepository : IManufacturerRepository
	{
		private readonly DBContext _context;
		public ManufacturerRepository(DBContext context)
		{
			this._context = context;
		}
		public async Task<ICollection<Manufacturer>> GetAllAsync()
		{
			return await this._context.Manufacturers.Include(x => x.Products).ToListAsync();
		}
	}
}
