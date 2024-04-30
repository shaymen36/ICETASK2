using GroceryStoreInventory;
using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GroceryStoreInventoryInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GroceryStore groceryStore = new GroceryStore();

                // Adding items to the inventory
                InventoryItem apple = new InventoryItem("Apple", 0.99m, 50, "Fruits");
                InventoryItem milk = new InventoryItem("Milk", 2.49m, 30, "Dairy");
                InventoryItem bread = new InventoryItem("Bread", 1.99m, 20, "Bakery");

                groceryStore.Inventory.AddItem(apple);
                groceryStore.Inventory.AddItem(milk);
                groceryStore.Inventory.AddItem(bread);

                // Displaying inventory
                Console.WriteLine("Inventory:");
                groceryStore.Inventory.DisplayInventory();

                // Removing an item from the inventory
                groceryStore.Inventory.RemoveItem(milk);

                // Displaying inventory after removing an item
                Console.WriteLine("Inventory after removing Milk:");
                groceryStore.Inventory.DisplayInventory();
            }
            catch (Exception ex)
            {
                ErrorHandler.HandleError(ex);
            }
        }
    }
}
