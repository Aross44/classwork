// namespace Linq_Lab;

// class Program
// {
    // static void Main(string[] args)
    // {
        // Console.WriteLine("Hello, World!");
    // }
// }


    using System;
    using System.Linq;  // You need this for LINQ to work

    namespace LinqAssignment
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Create the array of numbers
                int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };

                // Find the minimum value using LINQ
                int minValue = nums.Min(); // Finds the smallest number
                Console.WriteLine("Minimum value: " + minValue);

                // Find the maximum value using LINQ
                int maxValue = nums.Max(); // Finds the largest number
                Console.WriteLine("Maximum value: " + maxValue);

                // Find the maximum value less than 10,000
                int maxUnder10k = nums.Where(n => n < 10000).Max(); 
                // Filter values less than 10,000, then find the max
                Console.WriteLine("Maximum value less than 10,000: " + maxUnder10k);

                // Find all values between 10 and 100
                var between10And100 = nums.Where(n => n >= 10 && n <= 100);
                Console.WriteLine("Values between 10 and 100:");
                foreach (var num in between10And100)
                {
                    Console.WriteLine(num);
                }

                // Find all values between 100000 and 999999 (inclusive)
                var sixDigitNums = nums.Where(n => n >= 100000 && n <= 999999);
                Console.WriteLine("Values between 100,000 and 999,999:");
                foreach (var num in sixDigitNums)
                {
                    Console.WriteLine(num);
                }

                // Count all even numbers
                int evenCount = nums.Count(n => n % 2 == 0); // n % 2 == 0 means it's even
                Console.WriteLine("Count of even numbers: " + evenCount);
            }
        }
    }