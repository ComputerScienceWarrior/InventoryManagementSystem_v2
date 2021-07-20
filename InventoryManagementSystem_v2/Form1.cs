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
				//inventory.RemoveProduct() //remove by selected index in list
			}
			else
			{
				inventory.RemoveProduct(ItemName.Text);
			}
		}

		private void UpdateButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Clicked Update Button!");
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Clicked Search Button!");
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
	}
}
