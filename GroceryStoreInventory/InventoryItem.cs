using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreInventory
{
    public class InventoryItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }

        
        public InventoryItem(string name, decimal price, int quantity, string category)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Category = category;
        }
    }
}
