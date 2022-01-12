using Final.Models.Dto;
using WebApplication2.Models.Entities;

namespace Final.Models.ItemProductViewModel;

public class CreateItemProductViewModel
{
	public int ProductId { get; set; }
	public Product Product { get; set; }
	
	public int ItemId { get; set; }
	public Item Item { get; set; }
}