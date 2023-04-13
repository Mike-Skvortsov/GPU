using AutoMapper;
using BLL.DTO.OrderDTO;
using BLL.Services.Interfaces;
using Database.Repositories.Interfaces;

namespace BLL.Services.Implements
{
    public class OrderService : IOrderService
	{
		private readonly IOrderRepository _repository;
		private readonly IMapper _mapper;
		public OrderService(IOrderRepository repository, IMapper mapper)
		{
			_mapper= mapper;
			this._repository = repository;
		}
		public async Task<IEnumerable<OrderDTOAll>> GetAllAsync()
		{
			var order = await this._repository.GetAllAsync();
			return _mapper.Map<IEnumerable<OrderDTOAll>>(order);
		}
	}
}
