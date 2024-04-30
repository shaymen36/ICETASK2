using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreInventory
{
    public static class InputValidator
    {
        public static bool IsValidPrice(string price)
        {
            return decimal.TryParse(price, out _);
        }

        public static bool IsValidQuantity(string quantity)
        {
            return int.TryParse(quantity, out _);
        }
    }
}


