﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Food
{
	class Order
	{
		private List<Product> product;

		public List<Product> Product
		{
			get { return product; }
			set { product = value; }
		}


		private double price;

		public double Price
		{
			get { return price; }
			set { price = value; }
		}

		public Order()
		{
			List<Product> products = new List<Product>();
		}
	}
}
