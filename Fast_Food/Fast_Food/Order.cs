using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Food
{
	class Order
	{
		private Product product;

		public Product Product
		{
			get { return product; }
			set { product = value; }
		}


		private int price;

		public int Price
		{
			get { return price; }
			set { price = value; }
		}

		public Order()
		{
			Product product = new Product();
		}
	}
}
