using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace ShopAppWebUI.Models
{
    public class ProductAddViewModel
    {
		public Product Product { get; set; }
		public List<Category> Categories { get; internal set; }
	}
}
