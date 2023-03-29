﻿using Database;
using Entities;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GPU.Controllers
{
	public class DetailsController : ControllerBase
	{
		private readonly DBContext _context;

		public DetailsController(DBContext context)
		{
			_context = context;
		}
		public async Task<ICollection<Details>> GetAllDetailsAsync()
		{
			return await _context.Details.Include(x => x.Specifications).ToListAsync();
		}
	}
}