using System;
using System.Collections.Generic;  // Give me access to the systems generic collections stuff

namespace Day_2_Dictionary_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*********************************************************
             * Example use of a Dictionary with array/List value
             *********************************************************/
                
            // Ask the user for a name and a grade
            // Store them in a Dictionary
            
            // Dictionary to hold name (key) and grade (value)
            //         key     value
            //         type    type    name      = new Dictionary<key-type, value>();
            Dictionary<string, double> gradeBook = new Dictionary<string, double>();
            
            // Lets add  students and grades until the user indicates they are done  
            //Loop until the user satisfies a condition instead of a specific # of times 
            // Replace the for loop with either a while-loop or do-while()
            //Do we want to loop at least once? Yes - do-while
            //Is Ok to loop 0-times? Yes - while loop; No - do-while loop 
           //
           // In this case we have to ask the user at least once to enter some data
            // How do we want the user to let us know they are done?
            //create  an on/off switch\
            ////Prompt = ask if they are done
            /// set a condition based on what they tel us
            for (int i = 0; i < 3; i++)
           do
           {
                // Ask the user for the student name and grade
                Console.Write("Enter student name: ");
                string studentName = Console.ReadLine(); // Get student name// Ask the user for the student name
                Console.Write("Enter grade: ");
                double grade = Double.Parse(Console.ReadLine()); // Get student grade

                // Add the data to our Dictionary
                // Dictionary[key}     = value;
                gradeBook[studentName] = grade; // gradeBook.Add(studentName, grade) // may cause an exception
            }
            
            // Display the entrys in our Dictionary
            // Use a KeyValuePair type to get an entry from teh Dictionary
            foreach (KeyValuePair<string, double> anEntry in gradeBook)
            {
                Console.WriteLine(gradeBook[anEntry.Key] + " has a grade of " + anEntry.Value);
            }
            
            Console.WriteLine("Please press enter to end program...");
            Console.Read();
        }
    }
}







//namespace Day_2_Dictionary_Example;

//class Program
//{
 //   static void Main(string[] args)
   // {
     //   Console.WriteLine("Hello, World!");
    //}
//}