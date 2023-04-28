using BLL.DTO.Manufacturer;
using BLL.Services.Interfaces;
using Entities;
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
		[HttpPost]
		[Route("Create")]
		public async Task<IActionResult> CreateManufacturer(ManufacturerDTO manufacturer)
		{
			var createdManufacturer = await _manufacturerService.CreateAsync(manufacturer);
			return Ok(createdManufacturer);
		}
		[HttpDelete]
		[Route("Update")]
		public async Task<IActionResult> UpdateManufacturer(ManufacturerDTOWithId manufacturer)
		{
			var updatedManufacturer = await _manufacturerService.UpdateAsync(manufacturer);
			return Ok(updatedManufacturer);
		}
		[HttpDelete]
		[Route("Delete/{id}")]
		public async Task<IActionResult> DeleteManufacturer(int id)
		{
			var createdManufacturer = await _manufacturerService.DeleteAsync(id);
			return Ok(createdManufacturer);
		}
	}
}
