using BLL.Services.Interfaces;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace GPU.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IProductService _productService;

		public ProductController(IProductService productService)
		{
			_productService = productService;
		}
		//[HttpGet]
		//[Route("")]
		//public async Task<IEnumerable<AllProductDTO> GetAllAsync()
		//{
		//	var product = await _productService.GetAllAsync();
		//	if (product == null)
		//	{
		//		return NotFound("this category doesn`t exist!");
		//	}
		//	return Ok(product);
		//}
		//[HttpGet]
		//[Route("{id}")]
		//public async Task<Product> GetByIdAsync([FromBody] int id)
		//{
		//	var product 
		//}
	}
}
