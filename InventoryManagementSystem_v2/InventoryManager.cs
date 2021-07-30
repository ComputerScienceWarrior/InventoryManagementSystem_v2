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
		public InventoryManager() { }
		public InventoryManager(List<InventoryItem> inventory, int count)
		{
			inventory_items = inventory;
			this.count = count;
		}

		//class methods
		public void AddProduct(InventoryItem item)
		{
			inventory_items.Add(item);
			count += 1;
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
				if (itm.name == queryItem)
				{
					results.Add(queryItem);
				}
			}
			return results;
		}

		public List<string> FindProductByPrice(string queryPrice)
		{
			decimal p = 0.00M;
			List<string> results = new List<string>();
			foreach(InventoryItem itm in inventory_items)
			{
				if(decimal.TryParse(queryPrice, out p))
				{
					System.Windows.Forms.MessageBox.Show(p.ToString(), queryPrice);
					if (itm.price.ToString() == p.ToString())
					{
						results.Add(itm.name); //CHANGE THIS TO ADDING 'toString()' method of each item to display all details of item in list.
					}
				}
				else
				{
					System.Windows.Forms.MessageBox.Show("You've enetered an incorrect value, try entering in the '0.00' format for price.");
				}
			}
			return results;
		}

		
	}
}
