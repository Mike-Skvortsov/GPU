using BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GPU.Controllers
{

	[Route("api/[controller]")]
	[ApiController]
	public class OrderController : ControllerBase
	{
		private readonly IOrderService _orderService;

		public OrderController(IOrderService orderService)
		{
			_orderService = orderService;
		}
		[HttpGet]
		[Route("")]
		public async Task<IActionResult> GetOrdersAsync()
		{
			var model = await _orderService.GetAllAsync();
			if (model == null)
			{
				return NotFound();
			}
			return Ok(model);
		}
	}
}
