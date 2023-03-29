using Database;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GPU.Controllers
{
	[Route("api/memory")]
	[ApiController]
	public class MemoryController : ControllerBase
	{
		private readonly DBContext _context;

		public MemoryController(DBContext context)
		{
			_context = context;
		}
		[HttpGet]
		[Route("")]
		public async Task<ICollection<Memory>> GetAllMemoriesAsync()
		{
			return await this._context.Memories.Include(x => x.Specifications).ToListAsync();
		}
	}
}
