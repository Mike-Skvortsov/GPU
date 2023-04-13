using Database.Repositories.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Database.Repositories.Implements
{
	public class ProductRepository: BaseRepository<Product>, IProductRepository
	{
		public ProductRepository(DBContext dbContext) : base(dbContext)
		{ 
		}
		public async Task<Product?> GetProductById(int productId)
		{
			var product = await _dbContext.Products.Include(x => x.Manufacturer).Where(x => x.Id == productId).FirstOrDefaultAsync();
			return product;
		}
	}
}
