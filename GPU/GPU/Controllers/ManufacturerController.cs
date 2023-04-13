using BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GPU.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ManufacturerController : ControllerBase
	{
		private readonly IManufacturerService _manufacturerService;

		public ManufacturerController(IManufacturerService manufacturerService)
		{
			_manufacturerService = manufacturerService;
		}
		[HttpGet]
		[Route("{id}")]
		public async Task<IActionResult> GetManufacturerById(int id)
		{
			var model = await _manufacturerService.GetManufacturerById(id);
			if(model == null)
			{
				return NotFound();
			}
			return Ok(model);
		}
		[HttpGet]
		[Route("")]
		public async Task<IActionResult> GetManufacturers()
		{
			return Ok(await _manufacturerService.GetAllAsync());
		}
	}
}
