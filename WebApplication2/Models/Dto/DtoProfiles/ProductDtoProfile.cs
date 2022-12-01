using AutoMapper;
using WebApplication2.Models.Entities;

namespace WebApplication2.Models.Dto.DtoProfiles;

public class ProductDtoProfile : Profile
{
	public ProductDtoProfile()
	{
		CreateMap<Product, ProductDto>()
			.ForMember(destination => destination.AssemblyStatus,
				opt => opt.MapFrom(source => Enum.GetName(typeof(AssemblyStatus), source.AssemblyStatus)))
			.ReverseMap();
	}
}