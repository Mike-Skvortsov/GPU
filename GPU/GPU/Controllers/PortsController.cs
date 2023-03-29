using Database;
using Entities;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GPU.Controllers
{
	public class PortsController : ControllerBase
	{
		private readonly DBContext _context;

		public PortsController(DBContext context)
		{
			_context = context;
		}
		public async Task<ICollection<Ports>> GetAllPortsAsync()
		{
			return await _context.Ports.Include(x => x.Specifications).ToListAsync();
		}
	}
}
