using Candy_SUT21.Models;
using Candy_SUT21.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Candy_SUT21.Controllers
{
	public class ShoppingCartController : Controller
	{
		private readonly ICandyRepository _candyRepository;
		private readonly ShoppingCart _shoppingCart;
		private readonly AppDbContext _appDbContext;

		public ShoppingCartController(ICandyRepository candyRepository, ShoppingCart shoppingCart, AppDbContext appDbContext)
		{
			_candyRepository = candyRepository;
			_shoppingCart = shoppingCart;
			_appDbContext = appDbContext;
		}

		public IActionResult Index()
		{
			_shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();
			var shoppingCartViewModel = new ShoppingCartViewModel
			{
				ShoppingCart = _shoppingCart,
				ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
			};

			return View(shoppingCartViewModel);
		}

		public RedirectToActionResult AddToShoppingCart(int candyID)
		{
			var selectedCandy = _candyRepository.GetAllCandy.FirstOrDefault(c => c.CandyId == candyID);
			if (selectedCandy != null)
			{
				_shoppingCart.AddToCart(selectedCandy, 1);
			}
			return RedirectToAction("Index");
		}

		public RedirectToActionResult RemoveFromShoppingCart(int candyID)
		{
			var selectedCandy = _candyRepository.GetAllCandy.FirstOrDefault(c => c.CandyId == candyID);
			if (selectedCandy != null)
			{
				_shoppingCart.RemoveFromCart(selectedCandy);
			}

			return RedirectToAction("Index");
		}

		public decimal GetShoppingCartTotal()
		{
			return _shoppingCart.GetShoppingCartTotal();
		}

		public RedirectToActionResult ClearCart()
		{
			_shoppingCart.ClearCart();
			return RedirectToAction("Index");
		}
	}
}
