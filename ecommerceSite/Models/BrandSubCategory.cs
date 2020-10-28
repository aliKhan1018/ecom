using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ecommerceSite.Models
{
	public class BrandSubCategory
	{
		[Key]
		public int ID { get; set; }

		public int BrandID { get; set; }
		public virtual Brand Brand { get; set; }

		public int SubCategoryID { get; set; }
		public virtual SubCategory SubCategory { get; set; }
	}
}