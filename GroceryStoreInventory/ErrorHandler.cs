using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreInventory
{
    public static class ErrorHandler
    {
        public static void HandleError(Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

}


