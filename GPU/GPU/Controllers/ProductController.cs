using Database.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GPU.Controllers
{
	[Route("api/product")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IProductService _product;

		public ProductController(IProductService product)
		{
			_product = product;
		}
		[HttpGet]
		[Route("")]
		public async Task<IActionResult> GetAllAsync()
		{
			var product = await _product.GetAllAsync();
			if (product == null)
			{
				return NotFound("this category doesn`t exist!");
			}
			return Ok(product);
		}
	}
}
