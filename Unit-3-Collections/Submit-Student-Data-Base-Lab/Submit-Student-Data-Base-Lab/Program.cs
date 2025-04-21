// namespace Submit_Student_Data_Base_Lab;

// class Program
// {
    // static void Main(string[] args)
    // {
        // Console.WriteLine("Hello, World!");
    // }
// }


using System;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays to store student data (same size!)
            string[] names = { "Alice Johnson", "Jimmy Scrambles", "Sasha King" };
            string[] hometowns = { "Detroit", "Grand Rapids", "Lansing" };
            string[] favoriteFoods = { "Pizza", "Tacos", "Sushi" };

            Console.WriteLine("Welcome to the Student Database!\n");

            bool keepGoing = true;

            while (keepGoing)
            {
                // Ask user for a student number
                Console.Write($"Which student would you like to learn about? (Enter a number 1-{names.Length}): ");
                string input = Console.ReadLine();
                int index;

                // Validate that the input is a number and within range
                if (!int.TryParse(input, out index) || index < 1 || index > names.Length)
                {
                    Console.WriteLine("That student does not exist. Please try again.\n");
                    continue;
                }

                // Adjust for zero-based index
                index--;

                // Show the student's name
                Console.WriteLine($"\nStudent {index + 1} is {names[index]}.");

                // Ask what the user wants to know
                string category = "";
                bool validCategory = false;

                while (!validCategory)
                {
                    Console.Write("What would you like to know? Enter \"hometown\" or \"favorite food\": ");
                    category = Console.ReadLine().ToLower();

                    if (category == "hometown")
                    {
                        Console.WriteLine($"{names[index]} is from {hometowns[index]}.");
                        validCategory = true;
                    }
                    else if (category == "favorite food")
                    {
                        Console.WriteLine($"{names[index]}'s favorite food is {favoriteFoods[index]}.");
                        validCategory = true;
                    }
                    else
                    {
                        Console.WriteLine("That category does not exist. Please try again.");
                    }
                }

                // Ask if they want to continue
                Console.Write("\nWould you like to learn about another student? (y/n): ");
                string again = Console.ReadLine().ToLower();

                if (again != "y")
                {
                    keepGoing = false;
                    Console.WriteLine("\nThanks!");
                }

                Console.WriteLine(); // Blank line for spacing
            }
        }
    }
}