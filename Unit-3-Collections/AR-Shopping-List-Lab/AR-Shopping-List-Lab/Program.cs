
   
   //using System;  // Gives access to basic commands like Console
//using System.Collections.Generic; // Gives access to Dictionary and List

namespace ShoppingListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Sanrio Market!\n");

            
            // Store selected items in a dictionary  down below with item names and there prices 
            //
            Dictionary<string, decimal> menu = new Dictionary<string, decimal>()
            {
                {"kuromi", 0.85m},
                {"mymelody", 0.70m},
                {"baku", 1.59m},
                {"pompompurin", 1.19m},
                {"hellokitty", 0.79m},
                {"daniel", 2.09m},
                {"chococat", 0.99m},
                {"cinnomanroll", 2.49m}
            };

            //  List to hold what the user chooses (just the names)
            List<string> shoppingList = new List<string>();

            bool shopping = true;  //This controls the loop

            while (shopping)  //  Loop until the user wants to stop
            {
                //  Display the menu to the user
                Console.WriteLine("Item            Price");
                Console.WriteLine("==============================");
                foreach (var item in menu)
                {
                    // item.Key = name, item.Value = price
                    Console.WriteLine($"{item.Key.PadRight(15)} ${item.Value:F2}");
                }

                //  Ask user to type what they want to buy
                Console.Write("\nWhat item would you like to order? ");
                string input = Console.ReadLine().ToLower(); // Make it lowercase to match dictionary

                //  Check if item exists in the menu
                if (menu.ContainsKey(input))
                {
                    shoppingList.Add(input); // Add item name to the shopping list
                    Console.WriteLine($"Adding {input} to cart at ${menu[input]:F2}");
                }
                else
                {
                    Console.WriteLine("Sorry, we don't have those. Please try again.\n");
                    continue; // Skip asking to continue — restart loop
                }

                //  Ask if they want to keep shopping
                Console.Write("\nWould you like to order anything else (y/n)? ");
                string answer = Console.ReadLine().ToLower();

                if (answer != "y")
                {
                    shopping = false; // This ends the while loop
                }
            }

            //  Show final order summary
            Console.WriteLine("\nThanks for your order!");
            Console.WriteLine("Here's what you got:\n");

            decimal total = 0; //  Track the total cost

            Console.WriteLine("Item            Price");
            Console.WriteLine("==============================");

            foreach (string itemName in shoppingList)
            {
                //  Use the item name to look up its price in the dictionary
                decimal price = menu[itemName];
                Console.WriteLine($"{itemName.PadRight(15)} ${price:F2}");
                total += price; // Add to total
            }

            //  Show total and average price per item
            if (shoppingList.Count > 0)
            {
                double average = (double)total / shoppingList.Count; // cast to get decimals
                Console.WriteLine($"\nTotal: ${total:F2}");
                Console.WriteLine($"Average price per item: ${average:F2}");
            }

            Console.WriteLine("\n--- Ending program ---");
        }
    }
}