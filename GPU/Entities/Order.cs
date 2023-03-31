﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Order:BaseEntity
	{
		public int UserId { get; set; }
		public User User { get; set; }
		public int Count { get; set; }

		public ICollection<Product> Products { get; set; }

	}
}
