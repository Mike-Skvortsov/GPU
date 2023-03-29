using Database;
using Entities;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GPU.Controllers
{
	public class ProductController : ControllerBase
	{
		private readonly DBContext _context;

		public ProductController(DBContext context)
		{
			_context = context;
		}
		public async Task<ICollection<Product>> GetAllAsync()
		{
			return await _context.Products.Include(x => x.Specifications).ToListAsync();
		}
	}
}
