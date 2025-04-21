// namespace Basic_String_Processing;

// class Program
// {
    // static void Main(string[] args)
    // {
        // Console.WriteLine("Hello, World!");
    // }
// }


    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> textEntries = new List<string>();  // This holds all user entries
            string userInput;
            string response;

            do
            {
                Console.Write("Enter some text: ");
                userInput = Console.ReadLine();

                // Add what the user typed to the list
                textEntries.Add(userInput);

                // Join all items in the list and print them in one line
                Console.WriteLine("You have entered: " + string.Join(" ", textEntries));

                Console.Write("Would you like to continue (y/n)? ");
                response = Console.ReadLine().ToLower();
            }
            while (response == "y");

            Console.WriteLine("Goodbye!");
        }
    }