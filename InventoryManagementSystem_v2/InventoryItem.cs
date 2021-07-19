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
		private string name;
		private decimal price;
		private int quantity;
		
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
	}
}
