using Database;
using Entities;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GPU.Controllers
{
	[Route("api/ports")]
	[ApiController]
	public class PortsController : ControllerBase
	{
		private readonly DBContext _context;

		public PortsController(DBContext context)
		{
			_context = context;
		}
		[HttpGet]
		[Route("")]
		public async Task<ICollection<Ports>> GetAllPortsAsync()
		{
			return await _context.Ports.Include(x => x.Specifications).ToListAsync();
		}
	}
}
