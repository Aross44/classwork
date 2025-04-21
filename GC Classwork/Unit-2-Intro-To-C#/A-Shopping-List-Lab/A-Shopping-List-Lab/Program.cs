//namespace A_Shopping_List_Lab;
//
//class Program
//{
  //  static void Main(string[] args)
    //{
      //  Console.WriteLine("Hello, World!");
    //}
//}
using System;
using System.Collections.Generic;

namespace ShoppingListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Chirpus Market!\n");

            // (✔️) Dictionary<string, decimal> for menu
            Dictionary<string, decimal> menu = new Dictionary<string, decimal>()
            {
                {"apple", 0.99m},
                {"banana", 0.59m},
                {"cauliflower", 1.59m},
                {"dragonfruit", 2.19m},
                {"elderberry", 1.79m},
                {"figs", 2.09m},
                {"grapefruit", 1.99m},
                {"honeydew", 3.49m}
            };

            // (✔️) List<string> for shopping list
            List<string> shoppingList = new List<string>();

            bool shopping = true;

            while (shopping)
            {
                // (✔️) Display the menu
                Console.WriteLine("Item            Price");
                Console.WriteLine("==============================");
                foreach (var item in menu)
                {
                    Console.WriteLine($"{item.Key.PadRight(15)} ${item.Value:F2}");
                }

                Console.Write("\nWhat item would you like to order? ");
                string input = Console.ReadLine().ToLower();

                // (✔️) Validation: item exists
                if (menu.ContainsKey(input))
                {
                    shoppingList.Add(input); // (✔️) Add to shopping list
                    Console.WriteLine($"Adding {input} to cart at ${menu[input]:F2}");
                }
                else
                {
                    Console.WriteLine("Sorry, we don't have those. Please try again.\n");
                    continue; // Restart the loop without asking to continue
                }

                // (✔️) Ask if they want to keep going
                Console.Write("\nWould you like to order anything else (y/n)? ");
                string answer = Console.ReadLine().ToLower();

                if (answer != "y")
                {
                    shopping = false;
                }
            }

            // (✔️) Show final receipt
            Console.WriteLine("\nThanks for your order!");
            Console.WriteLine("Here's what you got:\n");

            decimal total = 0;

            Console.WriteLine("Item            Price");
            Console.WriteLine("==============================");

            foreach (string itemName in shoppingList)
            {
                decimal price = menu[itemName];
                Console.WriteLine($"{itemName.PadRight(15)} ${price:F2}");
                total += price; // (✔️) Sum from List + Dictionary
            }

            if (shoppingList.Count > 0)
            {
                double average = (double)total / shoppingList.Count;
                Console.WriteLine($"\nTotal: ${total:F2}");
                Console.WriteLine($"Average price per item: ${average:F2}");
            }

            Console.WriteLine("\n--- Ending program ---");
        }
    }
}