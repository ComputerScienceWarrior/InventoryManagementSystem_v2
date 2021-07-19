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
			MessageBox.Show("Clicked Add Button!");
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
