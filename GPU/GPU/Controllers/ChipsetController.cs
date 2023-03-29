using Database;
using Entities;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GPU.Controllers
{
	[Route("api/chipset")]
	[ApiController]
	public class ChipsetController : ControllerBase
	{
		private readonly DBContext _context;

		public ChipsetController(DBContext context)
		{
			_context = context;
		}
		[HttpGet]
		[Route("")]
		public async Task<ICollection<Chipset>> GetAllAsync()
		{
			return await _context.Chipsets.Include(x => x.Specifications).ToListAsync();
		}
	}
}
