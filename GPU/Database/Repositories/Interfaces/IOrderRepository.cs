using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositories.Interfaces
{
	public interface IOrderRepository
	{
		Task<ICollection<Order>> GetAllAsync();

	}
}
