using AutoMapper;
using WebApplication2.Models.Dto;
using WebApplication2.Models.ViewModels.ProductViewModels;

namespace WebApplication2.Models.ViewModels.Profiles;

public class ProductViewModelProfile : Profile
{
	public ProductViewModelProfile()
	{
		CreateMap<ProductDto, CreateProductViewModel>().ReverseMap();
		CreateMap<ProductDto, DeleteProductViewModel>().ReverseMap();
		CreateMap<ProductDto, EditProductViewModel>().ReverseMap();
		CreateMap<ProductDto, ProductViewModel>();
	}
}