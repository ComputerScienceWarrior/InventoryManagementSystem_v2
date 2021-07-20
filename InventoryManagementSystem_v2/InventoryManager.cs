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

		public void AddProduct(InventoryItem item)
		{
			inventory_items.Add(item);
			this.count += 1;
		}

		public void RemoveProduct(string name)
		{
			foreach (InventoryItem item in this.inventory_items)
			{
				if (item.name == name)
				{
					this.inventory_items.Remove(item);
					System.Windows.Forms.MessageBox.Show($"{name} removed from inventory.");
					break;
				}
				else
				{
					System.Windows.Forms.MessageBox.Show($"{name} does not exist in the inventory.");
					break;
				}
			}
		}
	}
}
