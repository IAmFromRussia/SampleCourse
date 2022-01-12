using AutoMapper;
using Final.Models.ItemProductViewModel;
using WebApplication2.Models.Dto;
using WebApplication2.Models.ViewModels.ItemProductViewModel;

namespace WebApplication2.Models.ViewModels.Profiles;

public class ItemProductViewModelProfile : Profile
{
	public ItemProductViewModelProfile()
	{
		CreateMap<ItemProductDto, CreateItemProductViewModel>().ReverseMap();
		CreateMap<ItemProductDto, DeleteItemProductViewModel>().ReverseMap();
		CreateMap<ItemProductDto, EditItemProductViewModel>().ReverseMap();
		CreateMap<ItemProductDto, ItemProductViewModel.ItemProductViewModel>();
	}
}