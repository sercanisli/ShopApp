using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using ShopAppWebUI.ExtensionMethods;

namespace ShopAppWebUI.Services
{
	public class CartSessionService : ICartSessionService
	{
		private IHttpContextAccessor _httpContextAccessor;

		public CartSessionService(IHttpContextAccessor httpContextAccessor)
		{
			_httpContextAccessor = httpContextAccessor;
		}
		public Cart GetCart()
		{
			Cart cartToChech = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
			if (cartToChech == null)
			{
				_httpContextAccessor.HttpContext.Session.SetObject("cart", new Cart());
				cartToChech = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
			}

			return cartToChech;
		}

		public void SetCart(Cart cart)
		{
				_httpContextAccessor.HttpContext.Session.SetObject("cart", cart);
		}
	}
}
