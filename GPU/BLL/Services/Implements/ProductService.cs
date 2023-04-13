using AutoMapper;
using BLL.DTO.ProductDTO;
using BLL.Services.Interfaces;
using Database.Repositories.Interfaces;
using Entities;

namespace BLL.Services.Implements
{
	public class ProductService : IProductService
	{
		private readonly IProductRepository _repository;
		private readonly IMapper _mapper;
		public ProductService(IProductRepository repository, IMapper mapper)
		{
			this._repository = repository;
			this._mapper = mapper;
		}
		public async Task<IEnumerable<AllProductDTO>> GetAllAsync()
		{
			var products = await _repository.GetAllAsync();
			return _mapper.Map<IEnumerable<AllProductDTO>>(products);
		}
		public async Task<Product> GetProductById(int id)
		{
			return await _repository.GetProductById(id);
		}
	}
}
