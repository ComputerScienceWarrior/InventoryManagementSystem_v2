using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem_v2
{
	class InventoryManager
	{
		//fields
		List<InventoryItem> inventory = new List<InventoryItem>();

		//constructors
		public InventoryManager(){}

		//methods
		public void DisplayProducts()
		{
			if (inventory.Count == 0)
			{
				System.Windows.Forms.MessageBox.Show("No products to display!");
			}
			else
			{
				System.Windows.Forms.MessageBox.Show("Displaying Inventory Contents..");
			}
		}

		public void AddProduct(InventoryItem item)
		{
			inventory.Add(item);
		}

		public void RemoveProduct(InventoryItem item)
		{
			if (inventory.Contains(item))
			{
				inventory.Remove(item);
			}
			else
			{
				System.Windows.Forms.MessageBox.Show("Item does not exist!");
			}
		}
	}
}
