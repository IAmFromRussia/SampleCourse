using AutoMapper;
using WebApplication2.Models.Dto;
using WebApplication2.Models.ViewModels.ItemViewModels;

namespace WebApplication2.Models.ViewModels.Profiles;

public class ItemViewModelProfile : Profile
{
	public ItemViewModelProfile()
	{
		CreateMap<ItemDto, CreateItemViewModel>().ReverseMap();
		CreateMap<ItemDto, DeleteItemViewModel>().ReverseMap();
		CreateMap<ItemDto, EditItemViewModel>().ReverseMap();
		CreateMap<ItemDto, ItemViewModel>();
	}
}