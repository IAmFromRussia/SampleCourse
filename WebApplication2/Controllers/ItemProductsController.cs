using AutoMapper;
using Final.Models.ItemProductViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models.Dto;
using WebApplication2.Models.Entities;
using WebApplication2.Models.Services;
using WebApplication2.Models.ViewModels.ItemProductViewModel;

namespace WebApplication2.Controllers;

public class ItemProductsController : Controller
{
	private readonly IMapper _mapper;
	private readonly IService<ItemProduct, ItemProductDto> _service;

	public ItemProductsController(IMapper mapper, IService<ItemProduct, ItemProductDto> service)
	{
		_mapper = mapper;
		_service = service;
	}

	[HttpGet]
	public async Task<IActionResult> Index()
	{
		var itemProducts =
			_mapper.Map<IEnumerable<ItemProductDto>, IEnumerable<ItemProductViewModel>>(await _service.GetAllAsync());
		return View(itemProducts);
	}

	[HttpGet]
	public IActionResult Create()
	{
		return View();
	}

	[HttpGet]
	public async Task<IActionResult> Edit(int? id)
	{
		if (id == null)
			return NotFound();

		var editModel = _mapper.Map<EditItemProductViewModel>(await _service.GetAsync((int) id));

		return View(editModel);
	}

	[HttpGet]
	public async Task<IActionResult> Delete(int? id)
	{
		if (id == null)
			return NotFound();

		var deleteModel = _mapper.Map<DeleteItemProductViewModel>(await _service.GetAsync((int) id));

		return View(deleteModel);
	}

	[HttpPost]
	[Authorize(Roles = Roles.Admin + "," + Roles.AcceptanceEngineer + "," + Roles.AccountantEngineer)]
	[ValidateAntiForgeryToken]
	public async Task<IActionResult> Create(CreateItemProductViewModel inputModel)
	{
		if (!ModelState.IsValid) return View(inputModel);

		await _service.SaveAsync(_mapper.Map<ItemProductDto>(inputModel));

		return RedirectToAction(nameof(Index));
	}

	[HttpPost]
	[Authorize(Roles = Roles.Admin + "," + Roles.AcceptanceEngineer + "," + Roles.AccountantEngineer)]
	[ValidateAntiForgeryToken]
	public async Task<IActionResult> Edit(int id, EditItemProductViewModel editViewModel)
	{
		if (!ModelState.IsValid) return View(editViewModel);

		var itemProduct = _mapper.Map<ItemProductDto>(editViewModel);
		itemProduct.ItemId = id;

		await _service.UpdateAsync(itemProduct);

		return RedirectToAction(nameof(Index));
	}

	[HttpPost]
	[Authorize(Roles = Roles.Admin)]
	[ValidateAntiForgeryToken]
	public async Task<IActionResult> DeleteConfirmed(int id)
	{
		var itemProduct = await _service.DeleteAsync(id);

		return RedirectToAction(nameof(Index));
	}
}