﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ecommerceSite.Models
{
	public class SubCategory
	{
		[Key]
		public int ID { get; set; }
		public string Name { get; set; }

		public int CategoryID { get; set; }
		public virtual Category Category { get; set; }
	}
}