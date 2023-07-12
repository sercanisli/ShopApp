using System.Collections.Generic;
using Entities.Concrete;

namespace ShopAppWebUI.Models
{
	public class ProductUpdateViewModel
	{
		public Product Product { get; set; }
		public List<Category> Categories { get; set; }
	}
}