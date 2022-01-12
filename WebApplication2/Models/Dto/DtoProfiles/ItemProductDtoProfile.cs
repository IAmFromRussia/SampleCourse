using AutoMapper;
using WebApplication2.Models.Entities;

namespace WebApplication2.Models.Dto.DtoProfiles;

public class ProductItemDtoProfile : Profile
{
	public ProductItemDtoProfile()
	{
		CreateMap<ItemProduct, ItemProductDto>().ReverseMap();
	}
}