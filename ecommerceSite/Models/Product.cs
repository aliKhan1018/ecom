using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ecommerceSite.Models
{
	public class Product
	{
		[Key]
		public int ID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public float Price { get; set; }

		public int BrandID { get; set; }
		public virtual Brand Brand { get; set; }

	}
}