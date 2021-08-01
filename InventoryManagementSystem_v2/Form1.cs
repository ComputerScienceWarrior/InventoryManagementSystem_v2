using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem_v2
{
	public partial class MainScreen : Form
	{
		InventoryManager inventory = new InventoryManager(new List<InventoryItem>(), 0);
		public MainScreen()
		{
			InitializeComponent();
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			string name = ItemName.Text;
			decimal price = 0.00M;
			int quantity = 0;
			
			if (name != "")
			{
				//If price and quantity are valid..
				if(decimal.TryParse(ItemPrice.Text, out price) && int.TryParse(ItemQuantity.Text, out quantity))
				{
					inventory.AddProduct(new InventoryItem(name, price, quantity));
				}
				//if quantity is left blank but price is not..
				else if (decimal.TryParse(ItemPrice.Text, out price))
				{
					inventory.AddProduct(new InventoryItem(name, price));
				}
				//if price is left blank but quantity is not..
				else if (int.TryParse(ItemQuantity.Text, out quantity))
				{
					inventory.AddProduct(new InventoryItem(name, quantity));
				}
				//if all else if false, just add in product with 'name' only.
				else
				{
					inventory.AddProduct(new InventoryItem(name));
				}
				MessageBox.Show($"Successfully added {name} to inventory!");
				ItemName.Text = "";
				ItemPrice.Text = "";
				ItemQuantity.Text = "";
			}
			else
			{
				MessageBox.Show("Name cannot be left empty.");
			}
		}

		private void RemoveButton_Click(object sender, EventArgs e)
		{
			if (InventoryDisplayList.SelectedIndex != -1)
			{
				inventory.RemoveProduct(InventoryDisplayList.SelectedIndex); //remove by selected index in list
				MessageBox.Show("Product Removed!");
				InventoryDisplayList.Items.RemoveAt(InventoryDisplayList.SelectedIndex);
			}
			else
			{
				MessageBox.Show("No Product Selected.");
			}
		}

		private void UpdateButton_Click(object sender, EventArgs e)
		{
			if (ItemName.Text != "")
			{
				if (InventoryDisplayList.SelectedIndex != -1)
				{
					InventoryItem newItem = new InventoryItem(ItemName.Text);
					inventory.UpdateProduct(InventoryDisplayList.SelectedIndex, newItem);
					InventoryDisplayList.Items.Clear();
					foreach (InventoryItem item in inventory.inventory_items)
					{
						InventoryDisplayList.Items.Add(item.name);
					}
				}
				else
				{
					MessageBox.Show("No Value selected to update.");
				}
			}
			else
			{
				MessageBox.Show("There was no value entered in the 'Name' text box to update.");
			}
			
		}

		private void DisplayButton_Click(object sender, EventArgs e)
		{
			InventoryDisplayList.Items.Clear();
			foreach (InventoryItem item in inventory.inventory_items)
			{
				InventoryDisplayList.Items.Add(item.name);
			}
		}

		private void ClearListButton_Click(object sender, EventArgs e)
		{
			InventoryDisplayList.Items.Clear();
		}

		private void NameSearchButton_Click(object sender, EventArgs e)
		{
			List<string> results = inventory.FindProductByName(NameQuery.Text);
			if (results == null)
			{
				MessageBox.Show($"{NameQuery.Text} not found in inventory.");
			}
			else
			{
				MessageBox.Show($"Found item {NameQuery.Text.ToLower()} in inventory.");
				InventoryDisplayList.Items.Add(results[0]);
			}
		}

		private void PriceSearchButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show(PriceQuery.Text);
		}

		private void QuantitySearchButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show(QuantityQuery.Text);
		}
	}
}
