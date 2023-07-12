using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using ShopAppWebUI.Models;
using ShopAppWebUI.Services;

namespace ShopAppWebUI.ViewComponents
{
	public class CartSummaryViewComponent:ViewComponent
	{
		private ICartSessionService _cartSessionService;

		public CartSummaryViewComponent(ICartSessionService cartSessionService)
		{
			_cartSessionService = cartSessionService;
		}

		public ViewViewComponentResult Invoke()
		{
			var model = new CartSummaryViewModel
			{
				Cart = _cartSessionService.GetCart() //sessiondan gelen cart nesnemi ataım.
			};
			return View(model);
		}
	}
}
