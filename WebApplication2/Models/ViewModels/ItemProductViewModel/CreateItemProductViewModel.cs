using WebApplication2.Models.Entities;

namespace WebApplication2.Models.ViewModels.ItemProductViewModel;

public class CreateItemProductViewModel
{
	public int ProductId { get; set; }
	public Product Product { get; set; }
	
	public int ItemId { get; set; }
	public Item Item { get; set; }
}