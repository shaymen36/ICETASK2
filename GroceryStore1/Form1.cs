using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GroceryStore1
{
    public partial class Form1 : Form
    {
        private GroceryStoreInventory groceryStore;

        public Form1()
        {
            InitializeComponent();
            groceryStore = new GroceryStoreInventory();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);
            string category = txtCategory.Text;

            InventoryItem newItem = new InventoryItem(name, price, quantity, category);
            groceryStore.Inventory.AddItem(newItem);

            ClearInputFields();
            MessageBox.Show("Item added successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm(groceryStore.Inventory);
            inventoryForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm(groceryStore.Inventory);
            inventoryForm.ShowDialog();
        }
    }
}
