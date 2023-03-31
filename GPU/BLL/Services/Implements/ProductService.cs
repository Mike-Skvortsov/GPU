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
	public class ProductService : IProductService
	{
		private readonly IProductRepository _repository;
		public ProductService(IProductRepository repository)
		{
			this._repository = repository;
		}
		public Task<ICollection<Product>> GetAllAsync() => this._repository.GetAllAsync();

	}
}
