using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace ShopAppWebUI.Services
{
	public interface ICartSessionService
	{
		Cart GetCart();
		void SetCart(Cart cart);
	}
}
