using BLL.Services.Interfaces;
using Database.Repositories.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Implements
{
	public class OrderService : IOrderService
	{
		private readonly IOrderRepository _repository;
		public OrderService(IOrderRepository repository)
		{
			this._repository = repository;
		}
		public Task<IEnumerable<Order>> GetAllAsync() => this._repository.GetAllAsync();

	}
}
