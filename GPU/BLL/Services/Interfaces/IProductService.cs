﻿using BLL.DTO.ProductDTO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
	public interface IProductService
	{
		Task<IEnumerable<AllProductDTO>> GetAllAsync();
		Task<Product> GetProductById(int id);
	}
}
