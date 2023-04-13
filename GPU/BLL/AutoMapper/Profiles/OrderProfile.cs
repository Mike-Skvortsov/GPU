using AutoMapper;
using BLL.DTO.OrderDTO;
using BLL.DTO.ProductDTO;
using Entities;

public class OrderProfile : Profile
{
	private readonly IMapper _mapper;

	public OrderProfile(IMapper mapper)
	{
		_mapper = mapper;

		CreateMap<Order, OrderDTOAll>();
			//.ForMember(dest => dest.Products, opt => opt.MapFrom(src =>
			//	src.Products.Select(p => _mapper.Map<AllProductDTO>(p))));
	}

	public OrderProfile() : this(new MapperConfiguration(cfg => { }).CreateMapper())
	{
	}
}
