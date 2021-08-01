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
		//constructors
		public InventoryManager() { }
		public InventoryManager(List<InventoryItem> inventory, int count)
		{
			inventory_items = inventory;
		}

		//class methods
		public void AddProduct(InventoryItem item)
		{
			inventory_items.Add(item);
		}

		//RemoveProduct is for a ListView selection.
		public void RemoveProduct(int index)
		{
			inventory_items.Remove(inventory_items[index]);
		}

		public void UpdateProduct(int index, InventoryItem newItem)
		{
			inventory_items[index] = newItem;
			System.Windows.Forms.MessageBox.Show($"Successfully updated to {newItem.name}.");
		}

		public List<string> FindProductByName(string queryItem)
		{
			List<string> results = new List<string>();
			foreach(InventoryItem itm in inventory_items)
			{
				if (itm.name.ToLower() == queryItem.ToLower())
				{
					results.Add(queryItem.ToLower());
					return results;
				}
			}
			return null;
		}
	}
}
