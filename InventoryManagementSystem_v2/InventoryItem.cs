using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem_v2
{
	class InventoryItem
	{
		//class fields
		public string name;
		public decimal price;
		public int quantity;
		
		//various overloaded constructors
		public InventoryItem(){}
		public InventoryItem(string name)
		{
			this.name = name;
			price = 0.00M;
			quantity = 0;
		}
		public InventoryItem(string name, decimal price)
		{
			this.name = name;
			this.price = price;
			quantity = 0;
		}
		public InventoryItem(string name, int quantity)
		{
			this.name = name;
			price = 0.00M;
			this.quantity = quantity;
		}
		public InventoryItem(string name, decimal price, int quantity)
		{
			this.name = name;
			price = 0.00M;
			this.quantity = quantity;
		}

		public string toString()
		{
			return this.name + " | " + this.price + " | " + this.quantity;
		}

	}
}
