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
		public List<InventoryItem> inventory_items;
		public int count;
		//constructors
		public InventoryManager(List<InventoryItem> inventory, int count)
		{
			this.inventory_items = inventory;
			this.count = count;
		}

		//methods
		public void DisplayProducts()
		{
			foreach (InventoryItem item in this.inventory_items)
			{
				System.Windows.Forms.MessageBox.Show(item.name);
			}
		}

		public void AddProduct(InventoryItem item)
		{
			inventory_items.Add(item);
			this.count += 1;
		}

		public void RemoveProduct(InventoryItem item)
		{
			if (inventory_items.Contains(item))
			{
				inventory_items.Remove(item);
			}
			else
			{
				System.Windows.Forms.MessageBox.Show("Item does not exist!");
			}
		}
	}
}
