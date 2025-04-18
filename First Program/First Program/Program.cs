using System.Runtime.Intrinsics.X86;

namespace First_Program;

// This program will ask for three numbers 
// Add them together and display the total 
// Programing Solution - Human thinking
// Identify the detailed steps 
//
// Ask for the numbers one at a time 
// Write - down each number as its given
// Add the numbers create a sum/total
// Tell the requester the total (display)
//
// Now that we have the steps in our solution 
// Identify any data/processes you need for the steps 
// 
// 1. A place to write down each number - a variable in a program
// 2. A place to hold the sum/total - a variable in a program 
// 3. A was to ask for the numbers - a method in a program (object. method())
// 4. A way to receive the numbers - a method in a program (object.method())
// 5. A way to report the sum/total - a method in a program (object.method())
//
// PLace the steps in the order and provide more detail if necessary
// We need to solve The problem
// 1. Ask for the numbers one at a time 
// a. Tell whatever is giving us the numbers to give me the first number 
// b. Receive the first number  from the sender
// c. Write down the first number
// d. tell whatever is giving us the number to gibe me the second number 
// e. Receive the second number from the sender 
// f. Write down the second number 
// g. Tell whatever is giving us the numbers to give me the third number 
// h. Receive the third number from the sender
// i. Write down the Third number 
//
// 2. Add the numbers together create a sum/total
// a. Add the first number to a sum/total
// b. Add the second number to a sum/total
// c. Add the third number to a sum/total
//
// 3. Tell the requester the sum/total (display)
//
// Write - down each number as its given                               //why do I need the hyphen in between write down 

class Program
{
    static void Main(string[] args)
    {
       /*****************************************************************
        *
        * Define my data the program needs at the top of the program
        *
        * Data may be defined anywhere before its used, it easier to
        * find at the top of the program
        * To define a variable to hold the numbers we need 
        *
        * Commonly used data types in C#
        *
        *  int     - Numeric data is a whole number between =/- 2 billion
        * long     - A whole number greater than =/- 2 billion
        * double   - numeric value with decimal places 
        * char     - a single alpha
        * string   - a series of alpha-numeric characters (words or sentence)
        * bool     - true or false value for conditions
        *
        * examples: 10 - int (or long)
        *            1.0-
        *           'a' char (note it is enclosed in ' ')
        *           "some words" - string (note is enclosed in " ")
        *
        * Variables names C# are usually spelled in camelCase; Use _ to separate words
        * (camelCase) means the first letter is lowercase all other words
        *                                           start with upper case 
        * It's always good to initialize variables when defining them so you
        * know what's in them 
       *************************************************************************/
       
       
       
       
       //Define the variables to hld the numbers we need to add 
       int number1 = 0; //Since we will be doing math it needs to be numeric
       int number2 = 0; //Since we will be doing math it needs to be numeric
       int number3 = 0; //Since we will be doing math it needs to be numeric
       
       
       
       // Define a variable to hold the sum of the numbers 
       int
           sum = 0;

       Console.WriteLine("--- Starting program ---");
       
       
       //Ask for the numbers one at a time using the C# Console object
       //   which represents the keyboard and screen
       // Console.Readline() returns a string from keyboard- cannot store in an int
       Console.WriteLine("You entered: " +number1);     //Asking for the number  
       string aline; //-------> //String to hold the line of input from the keyboard                           
       aline = Console.ReadLine();                  //Get a line from the keybboard //aline means the theResponse from whats being asked
       // We need an int value to store our numbers 
       // Console.Readline () only returns a string 
       //So we need to convert a string to an int
       // int.Parse(string) will convert a string to an int 
       number1 = int. Parse(aline);
           //Just to verify  we are getting data from the keyboard
           //Lets display it
          // '+' with a string it concatentates 
       
       
       
       
       
        ///Console.WriteLine("--- Starting program ---");
        
        Console.WriteLine("Please enter a number");
        aline = Console.ReadLine();                   //Reuse aline (The respose) defined above
        number2 = int.Parse(aline);
        
        Console.WriteLine("Please enter a number ");
        aline = Console.ReadLine();
        number3 = int.Parse(aline);
       
        //Add the numbers together create a sum/total
        sum = number1 + number2 + number3;
       // Alternate coding method - Choose the coding style that you like 
         //However you code as long as its correct 
         //sum = sum + number1;
         //sum = sum + number2;
         //sum = sum +number3;
        
        // Tell the requester the sum/total (display)
        Console.WriteLine("The sum is : " + sum); 
       
        
        
        
        
        Console. WriteLine("--- Ending program ---");
    }
}