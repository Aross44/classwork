using System;

namespace PacticeAssesment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing IsTheSame
            Console.WriteLine("Calling IsTheSame(5,5) expecting true, it returns: " + IsTheSame(5, 5));
            Console.WriteLine("Calling IsTheSame(4,5) expecting false, it returns: " + IsTheSame(4, 5));

            // Testing Subtract
            Console.WriteLine("Calling Subtract (4,5) expecting -1, it returns : " + Subtract(4, 5));
            Console.WriteLine("Calling Subtract (5,4) expecting 1, it returns : " + Subtract(5, 4));
            Console.WriteLine("Calling Subtract (5,5) expecting 0, it returns : " + Subtract(5, 5));

            // Testing FindBuildingType
            Console.WriteLine("Calling FindBuildingType(1) returns: " + FindBuildingType(1));
            Console.WriteLine("Calling FindBuildingType(3) returns: " + FindBuildingType(3));
            Console.WriteLine("Calling FindBuildingType(4) returns: " + FindBuildingType(4));
            Console.WriteLine("Calling FindBuildingType(10) returns: " + FindBuildingType(10));
            Console.WriteLine("Calling FindBuildingType(11) returns: " + FindBuildingType(11));
            Console.WriteLine("Calling FindBuildingType(49) returns: " + FindBuildingType(49));
            Console.WriteLine("Calling FindBuildingType(50) returns: " + FindBuildingType(50));

            // Testing IsPassing
            Console.WriteLine("Calling IsPassing(66) expecting true: " + IsPassing(66));
            Console.WriteLine("Calling IsPassing(65) expecting false: " + IsPassing(65));

            // Testing AverageGrades
            Console.WriteLine("Calling AverageGrades(70, 80, 90) expecting 80: " + AverageGrades(70, 80, 90));

            // Testing OddOrEvenAndPassing
            Console.WriteLine("Calling OddOrEvenAndPassing(66) expecting Even and Passing: " + OddOrEvenAndPassing(66));
            Console.WriteLine("Calling OddOrEvenAndPassing(65) expecting Odd and Not Passing: " + OddOrEvenAndPassing(65));
        }

        static bool IsTheSame(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        static string FindBuildingType(int num1)
        {
            if (num1 <= 3)
            {
                return "This is a house!";
            }
            else if (num1 >= 4 && num1 <= 10)
            {
                return "This is an office building!";
            }
            else if (num1 >= 11 && num1 <= 49)
            {
                return "This is a skyscraper!";
            }
            else // num1 >= 50
            {
                return "This is a SUPER skyscraper!";
            }
        }

        // 1. Method signature setup correctly
        static bool IsPassing(int num)
        {
            // 2 & 3. Return true when num > 65, false otherwise
            return num > 65;
        }

        // 4. Method signature setup correctly
        static double AverageGrades(double grade1, double grade2, double grade3)
        {
            // 5. Returns average of 3 grades
            return (grade1 + grade2 + grade3) / 3;
        }

        // 6. Method signature setup correctly
        static string OddOrEvenAndPassing(int grade)
        {
            // 7. Determine even or odd
            bool isEven = grade % 2 == 0;

            // 8. Call IsPassing correctly
            bool passing = IsPassing(grade);

            // 9 & 10. Use result of IsPassing and return correct string
            if (isEven && passing)
            {
                return "Even and Passing";
            }
            else if (isEven && !passing)
            {
                return "Even and Not Passing";
            }
            else if (!isEven && passing)
            {
                return "Odd and Passing";
            }
            else
            {
                return "Odd and Not Passing";
            }
        }
    }
}