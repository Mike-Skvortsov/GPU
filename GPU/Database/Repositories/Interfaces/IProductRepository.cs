using Entities;
using Microsoft.EntityFrameworkCore;

namespace Database.Repositories.Interfaces
{
	public interface IProductRepository: IBaseRepository<Product>
	{
		Task<Product> GetProductById(int productId);
	}
}
