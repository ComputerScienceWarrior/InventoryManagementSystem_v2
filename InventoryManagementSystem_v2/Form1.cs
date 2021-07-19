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
		InventoryManager inventory = new InventoryManager();
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
					InventoryItem inventoryItem = new InventoryItem(name, price, quantity);
					inventory.AddProduct(inventoryItem);
				}
				//if quantity is left blank but price is not..
				else if (decimal.TryParse(ItemPrice.Text, out price))
				{
					InventoryItem inventoryItem = new InventoryItem(name, price);
					inventory.AddProduct(inventoryItem);
				}
				//if price is left blank but quantity is not..
				else if (int.TryParse(ItemQuantity.Text, out quantity))
				{
					InventoryItem inventoryItem = new InventoryItem(name, quantity);
					inventory.AddProduct(inventoryItem);
				}
				//if all else if false, just add in product with 'name' only.
				else
				{
					InventoryItem inventoryItem = new InventoryItem(name);
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
			MessageBox.Show("Clicked Remove Button!");
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
			inventory.DisplayProducts();
		}
	}
}
