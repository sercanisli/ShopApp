using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
	public class ShippingDetails
	{
		[Required]
		public string Name { get; set; }
		[Required]
		public string SurName { get; set; }
		[Required]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }
		[Required]
		public string City { get; set; }
		[Required]
		public string Address { get; set; }
		[Required]
		[Range(15,75)]
		public int Age { get; set; }
	}
}
