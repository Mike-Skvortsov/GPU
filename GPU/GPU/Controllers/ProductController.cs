using BLL.Services.Interfaces;
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

		[HttpGet]
		public async Task<IActionResult> GetAllProductAsync()
		{
			return Ok(await _productService.GetAllAsync());
		}

		[HttpGet]
		[Route("{id}")]
		public async Task<IActionResult> GetByIdAsync(int id)
		{
			var product = await _productService.GetProductById(id);
			if (product == null)
				return BadRequest("This product not exist");

			return Ok(product);
		}
	}
}
