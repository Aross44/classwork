namespace Day_2_For_Each__Example;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to an Example of a For-Each Loop");
        // Ask the user to enter a sentence 
        // (series of words seperated by whitespace space, tab, something you cant see)
        //Display each word in the sentence 
        
        Console.WriteLine("Please enter a sentence");
        string sentence = Console.ReadLine();     //Get what they type and put it in a string 
        
        // .split () will extract parts of a string into a array based on character inside ()
        // string[] splitSentence = sentence. Split (" "); // split the sentence into words
        string[] splitSentence = sentence.Split(" ");
           
        // Display each word in each word in the sentence - arrayName . Legnth returns the number of elements    
        // for (int i = 0; i < splitSentence.Length; i)     // To process an array use .Length to get # of elements
        for (int i = 0;  i < splitSentence.Count; i++)     // To process a List use .Count to get a # of elements 
        {
         //Note: to add 1 to i and use in the string we have to put it in ()
         // .Writeline() treats everything you give it as a string
         // + for a string means concatenate 
         //     + for a numeric means add 
         //     i+1 in the output for a WriteLine,
         //     it thinks i want to take the value of i and stick a 1 after it
         //(i+1) - () indicate do this first - add 1 to i and then use it in WriteLine output
         //
            
            
            
            Console.WriteLine("Word #: " + (i+1) + "is:" + splitSentence[i]);
        }
        //for

    // for-each loop can also process arrays and Lists 
    //
    // Syntax: foreach(datatype variable-name in array-or-List)
    //          datatype is the type in the array or List
    //          use the variable name inside the foreach loop to access an element in the array 
    //
    //Foreach goes through the array or List from start to end assigning each element to the variable
    // 
    //for-loop vs for-each
    //Both can process an array or List from beginning to end 
    // for-loop can start and end at any element by setting int i= and changing the condition
    // for-each Always processes from the beginning to end 
    //for-loop you know what element you're process by using the value in i 
    // for-each you do not know which element number you're processing
    foreach (string aWord in splitSentence) ;
    {
        Console.WriteLine(aWord);    //what's the difference between a for loop vs for each loop
    }
    
    // Display all the words using a do-While loop 
    //
    // do
    //{
    //loop processing
    // We always do the loop process at least once
    //      because the condition is checked at the end of the loop process
   
    // Define a variable to keep track of the element in the array/list we are processing 
    // We will use it as an index into array or List
    int currentElementNumber = 0;   // in a for-loop this is i

    do
    {
        Console.WriteLine("Word #: " + (i+1) + "is:" + splitSentence[currentElementNumber]);
        currentElementNumber++; // increment our index variable to move through the array or list 
    } while (currentElementNumber < splitSentence.Count); // loop until we process all elements 

    }
    
    
} 