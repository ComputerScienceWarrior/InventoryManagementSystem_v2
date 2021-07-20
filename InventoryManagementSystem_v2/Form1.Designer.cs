
namespace InventoryManagementSystem_v2
{
	partial class MainScreen
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.UserInfoPanel = new System.Windows.Forms.Panel();
			this.UserImage = new System.Windows.Forms.PictureBox();
			this.UsernameLabel = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SearchButton = new System.Windows.Forms.Button();
			this.DisplayButton = new System.Windows.Forms.Button();
			this.UpdateButton = new System.Windows.Forms.Button();
			this.RemoveButton = new System.Windows.Forms.Button();
			this.AddButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.ItemQuantityLabel = new System.Windows.Forms.Label();
			this.ItemPriceLabel = new System.Windows.Forms.Label();
			this.ItemNameLabel = new System.Windows.Forms.Label();
			this.ItemQuantity = new System.Windows.Forms.TextBox();
			this.ItemPrice = new System.Windows.Forms.TextBox();
			this.ItemName = new System.Windows.Forms.TextBox();
			this.InventoryDisplayList = new System.Windows.Forms.ListBox();
			this.InventoryDisplayBox = new System.Windows.Forms.GroupBox();
			this.ClearListButton = new System.Windows.Forms.Button();
			this.UserInfoPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.UserImage)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.InventoryDisplayBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// UserInfoPanel
			// 
			this.UserInfoPanel.Controls.Add(this.UserImage);
			this.UserInfoPanel.Controls.Add(this.UsernameLabel);
			this.UserInfoPanel.Location = new System.Drawing.Point(1025, 12);
			this.UserInfoPanel.Margin = new System.Windows.Forms.Padding(4);
			this.UserInfoPanel.Name = "UserInfoPanel";
			this.UserInfoPanel.Size = new System.Drawing.Size(238, 208);
			this.UserInfoPanel.TabIndex = 1;
			// 
			// UserImage
			// 
			this.UserImage.BackgroundImage = global::InventoryManagementSystem_v2.Properties.Resources.baseline_account_circle_black_24dp;
			this.UserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.UserImage.Location = new System.Drawing.Point(107, 6);
			this.UserImage.Margin = new System.Windows.Forms.Padding(4);
			this.UserImage.Name = "UserImage";
			this.UserImage.Size = new System.Drawing.Size(127, 54);
			this.UserImage.TabIndex = 1;
			this.UserImage.TabStop = false;
			// 
			// UsernameLabel
			// 
			this.UsernameLabel.AutoSize = true;
			this.UsernameLabel.ForeColor = System.Drawing.SystemColors.Control;
			this.UsernameLabel.Location = new System.Drawing.Point(129, 64);
			this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.UsernameLabel.Name = "UsernameLabel";
			this.UsernameLabel.Size = new System.Drawing.Size(105, 18);
			this.UsernameLabel.TabIndex = 0;
			this.UsernameLabel.Text = "<Username>";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.SearchButton);
			this.groupBox1.Controls.Add(this.UpdateButton);
			this.groupBox1.Controls.Add(this.RemoveButton);
			this.groupBox1.Controls.Add(this.AddButton);
			this.groupBox1.Location = new System.Drawing.Point(11, 325);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(329, 250);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Inventory Options";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(74, 21);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(181, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "Select an option Below";
			// 
			// SearchButton
			// 
			this.SearchButton.Location = new System.Drawing.Point(19, 200);
			this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(288, 26);
			this.SearchButton.TabIndex = 4;
			this.SearchButton.Text = "Search";
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// DisplayButton
			// 
			this.DisplayButton.Location = new System.Drawing.Point(17, 250);
			this.DisplayButton.Margin = new System.Windows.Forms.Padding(4);
			this.DisplayButton.Name = "DisplayButton";
			this.DisplayButton.Size = new System.Drawing.Size(247, 26);
			this.DisplayButton.TabIndex = 3;
			this.DisplayButton.Text = "Display Inventory";
			this.DisplayButton.UseVisualStyleBackColor = true;
			this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
			// 
			// UpdateButton
			// 
			this.UpdateButton.Location = new System.Drawing.Point(19, 144);
			this.UpdateButton.Margin = new System.Windows.Forms.Padding(4);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new System.Drawing.Size(288, 26);
			this.UpdateButton.TabIndex = 2;
			this.UpdateButton.Text = "Update";
			this.UpdateButton.UseVisualStyleBackColor = true;
			this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// RemoveButton
			// 
			this.RemoveButton.Location = new System.Drawing.Point(19, 95);
			this.RemoveButton.Margin = new System.Windows.Forms.Padding(4);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new System.Drawing.Size(288, 26);
			this.RemoveButton.TabIndex = 1;
			this.RemoveButton.Text = "Remove";
			this.RemoveButton.UseVisualStyleBackColor = true;
			this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(19, 44);
			this.AddButton.Margin = new System.Windows.Forms.Padding(4);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(288, 26);
			this.AddButton.TabIndex = 0;
			this.AddButton.Text = "Add";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Location = new System.Drawing.Point(1, 1);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(354, 589);
			this.panel1.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.ItemQuantityLabel);
			this.groupBox2.Controls.Add(this.ItemPriceLabel);
			this.groupBox2.Controls.Add(this.ItemNameLabel);
			this.groupBox2.Controls.Add(this.ItemQuantity);
			this.groupBox2.Controls.Add(this.ItemPrice);
			this.groupBox2.Controls.Add(this.ItemName);
			this.groupBox2.Location = new System.Drawing.Point(11, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(329, 306);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Inventory Item Fields";
			// 
			// ItemQuantityLabel
			// 
			this.ItemQuantityLabel.AutoSize = true;
			this.ItemQuantityLabel.ForeColor = System.Drawing.SystemColors.Control;
			this.ItemQuantityLabel.Location = new System.Drawing.Point(17, 207);
			this.ItemQuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ItemQuantityLabel.Name = "ItemQuantityLabel";
			this.ItemQuantityLabel.Size = new System.Drawing.Size(112, 18);
			this.ItemQuantityLabel.TabIndex = 8;
			this.ItemQuantityLabel.Text = "Item Quantity:";
			// 
			// ItemPriceLabel
			// 
			this.ItemPriceLabel.AutoSize = true;
			this.ItemPriceLabel.ForeColor = System.Drawing.SystemColors.Control;
			this.ItemPriceLabel.Location = new System.Drawing.Point(17, 135);
			this.ItemPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ItemPriceLabel.Name = "ItemPriceLabel";
			this.ItemPriceLabel.Size = new System.Drawing.Size(89, 18);
			this.ItemPriceLabel.TabIndex = 7;
			this.ItemPriceLabel.Text = "Item Price:";
			// 
			// ItemNameLabel
			// 
			this.ItemNameLabel.AutoSize = true;
			this.ItemNameLabel.ForeColor = System.Drawing.SystemColors.Control;
			this.ItemNameLabel.Location = new System.Drawing.Point(17, 63);
			this.ItemNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ItemNameLabel.Name = "ItemNameLabel";
			this.ItemNameLabel.Size = new System.Drawing.Size(94, 18);
			this.ItemNameLabel.TabIndex = 5;
			this.ItemNameLabel.Text = "Item Name:";
			// 
			// ItemQuantity
			// 
			this.ItemQuantity.Location = new System.Drawing.Point(20, 228);
			this.ItemQuantity.Name = "ItemQuantity";
			this.ItemQuantity.Size = new System.Drawing.Size(288, 24);
			this.ItemQuantity.TabIndex = 6;
			// 
			// ItemPrice
			// 
			this.ItemPrice.Location = new System.Drawing.Point(20, 156);
			this.ItemPrice.Name = "ItemPrice";
			this.ItemPrice.Size = new System.Drawing.Size(288, 24);
			this.ItemPrice.TabIndex = 5;
			// 
			// ItemName
			// 
			this.ItemName.Location = new System.Drawing.Point(19, 84);
			this.ItemName.Name = "ItemName";
			this.ItemName.Size = new System.Drawing.Size(288, 24);
			this.ItemName.TabIndex = 4;
			// 
			// InventoryDisplayList
			// 
			this.InventoryDisplayList.FormattingEnabled = true;
			this.InventoryDisplayList.ItemHeight = 18;
			this.InventoryDisplayList.Location = new System.Drawing.Point(17, 23);
			this.InventoryDisplayList.Name = "InventoryDisplayList";
			this.InventoryDisplayList.Size = new System.Drawing.Size(490, 220);
			this.InventoryDisplayList.TabIndex = 2;
			// 
			// InventoryDisplayBox
			// 
			this.InventoryDisplayBox.Controls.Add(this.ClearListButton);
			this.InventoryDisplayBox.Controls.Add(this.InventoryDisplayList);
			this.InventoryDisplayBox.Controls.Add(this.DisplayButton);
			this.InventoryDisplayBox.Location = new System.Drawing.Point(376, 18);
			this.InventoryDisplayBox.Name = "InventoryDisplayBox";
			this.InventoryDisplayBox.Size = new System.Drawing.Size(526, 301);
			this.InventoryDisplayBox.TabIndex = 3;
			this.InventoryDisplayBox.TabStop = false;
			this.InventoryDisplayBox.Text = "Listed Inventory";
			// 
			// ClearListButton
			// 
			this.ClearListButton.Location = new System.Drawing.Point(272, 250);
			this.ClearListButton.Margin = new System.Windows.Forms.Padding(4);
			this.ClearListButton.Name = "ClearListButton";
			this.ClearListButton.Size = new System.Drawing.Size(235, 26);
			this.ClearListButton.TabIndex = 5;
			this.ClearListButton.Text = "Clear List";
			this.ClearListButton.UseVisualStyleBackColor = true;
			this.ClearListButton.Click += new System.EventHandler(this.ClearListButton_Click);
			// 
			// MainScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.ClientSize = new System.Drawing.Size(1276, 589);
			this.Controls.Add(this.InventoryDisplayBox);
			this.Controls.Add(this.UserInfoPanel);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainScreen";
			this.Text = "Inventory Manager";
			this.UserInfoPanel.ResumeLayout(false);
			this.UserInfoPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.UserImage)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.InventoryDisplayBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel UserInfoPanel;
		private System.Windows.Forms.Label UsernameLabel;
		private System.Windows.Forms.PictureBox UserImage;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button SearchButton;
		private System.Windows.Forms.Button DisplayButton;
		private System.Windows.Forms.Button UpdateButton;
		private System.Windows.Forms.Button RemoveButton;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label ItemNameLabel;
		private System.Windows.Forms.TextBox ItemQuantity;
		private System.Windows.Forms.TextBox ItemPrice;
		private System.Windows.Forms.TextBox ItemName;
		private System.Windows.Forms.Label ItemQuantityLabel;
		private System.Windows.Forms.Label ItemPriceLabel;
		private System.Windows.Forms.ListBox InventoryDisplayList;
		private System.Windows.Forms.GroupBox InventoryDisplayBox;
		private System.Windows.Forms.Button ClearListButton;
	}
}

