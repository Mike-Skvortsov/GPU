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
	public class ProductRepository: BaseRepository<Product>, IProductRepository
	{
		public ProductRepository(DBContext dbContext) : base(dbContext)
		{ }
	}
}
