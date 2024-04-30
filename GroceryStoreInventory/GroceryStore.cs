using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreInventory
{
    public class GroceryStore
    {
        public Inventory Inventory { get; }

        public GroceryStore()
        {
            Inventory = new Inventory();
        }
    }
}

