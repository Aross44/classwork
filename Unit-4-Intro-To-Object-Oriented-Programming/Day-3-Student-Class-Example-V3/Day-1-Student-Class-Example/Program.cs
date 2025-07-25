﻿using System.ComponentModel.DataAnnotations;

namespace Day_1_Student_Class_Example;

class Program
{
    // This is an application program - Uses Objects of a class to do work
    // It instantiates and uses objects to perform processing
    // Every application has exactly one method called Main()
    
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Student Class Example");
        
    // Instantiate (define) a Student class object       
    // A class is data type
    // Define an object of a class liek any other variable with a slight difference
    
    // data-type name = initializer;  int sum = 0;
    
    // A class is instantiated with the new keyword 
    //         is initialized using one of its constructors
    // className name = new className(initializers);
    
    // We need to be sure have all the data we want to store in our object
    // Before we instantiate the object
    List<double> scores = new List<double>();
    scores.Add(100);
    scores.Add(90);
    scores.Add(80);

    List<double> scores2 = new List<double>();
    scores2.Add(100);
    scores2.Add(100);
    scores2.Add(100);

// Defining an object of a class is very similar to defining any other datatype

//  data
//  type name = initial-value;
    int    x  = 10;
    
    // Instantiate a Student using the data we want to store in the Student object
//  ClassName objName = new ClassName(initial-name, initial-scores)    
    Student aStudent  = new Student("Frank", scores);     // Calling the 2-arg ctor that takes a name and scores
    Student aStudent2 = new Student("Marquise", scores2); // Calling the 2-arg ctor that takes a name and scores
<<<<<<< HEAD
    
    // Display the Student object we created
    // Console.WriteLine() does not now how to display an object of our class
    Console.WriteLine("aStudent: " + aStudent);
    
    // Use the Student class method to diaplay Student class object
    //
    // object.method() <--- Object oriented notations 
    //Console.WriteLine() displays strings on the screen
    // it  expects you everything you ask it to display to be a string 
    // If given a non-string value, It tries to convert it to a string 
    //The way it trys to convert to 
    // 1. Looks at the datatype of what you are trying to display 
    //2. It determines if there is a method availible to convert the data type to a string 
    //      data type to a string:
   //     primative types (int, double, bool etc) all have methods to
   //     convert them to strings
   // 
   //     objects must have a method defined in their class to 
   //             return a string version of it's data
   //     the method it looks for is called TooString()
   //
   //     if a class does not have a ToString() method 
   //     C# returns Namespace.ClassName for any object of the class
=======
        
    // Display the Student object we created
    // Console.WriteLine() does not now how to display an object of our class
    Console.WriteLine("aStudent: " + aStudent);
    // Console.WriteLine() displays strings on the screen
    // It expects everything you ask it to display to be a string
    // If given a non-string value, it trys to convert it to a string
    // The way it trys to convert to a string:
    //
    //   1. Looks at the datatype of what you are trying to display
    //   2. It determines if there is a method available to convert the
    //         data type to a string
    //
    //      primitive types (int, double, bool etc) al have methods to
    //      convert them to strings
    //
    //      objects must have a method defined in their class to
    //              return a string version of its data
    //
    //      the method it looks for is called ToString()
    //
    //      if a class does not have a ToString() method
    //         C# returns Namespace.ClassName for any object of the class
    
    
    
    
>>>>>>> d7911bb22c68dc0f64264c999a3dd97a50672135
    
    // Use the Student class method to display Student class object
    //
    // object.method() <--- object oriented notations
    aStudent.ShowStudent();
    aStudent2.ShowStudent();
<<<<<<< HEAD

    List<double> newScores = new List<double>();
    newScores.Add(0);
    astudent.SetTestScores(newscores);
    aStudent.ShowTestScores();
=======
    
>>>>>>> d7911bb22c68dc0f64264c999a3dd97a50672135
    // Define a student with no scores
    Student johnTheStudent = new Student("John"); 
    johnTheStudent.ShowStudent();  // Display the data in the Student Object
    
    // Add some scores to johnTheStudent
    johnTheStudent.AddScore(86);
    johnTheStudent.AddScore(90);
    johnTheStudent.AddScore(20);
    johnTheStudent.AddScore(67.5);
    johnTheStudent.AddScore(99.1);
    
    johnTheStudent.ShowStudent();  // Display the data in the Student Object
    
    johnTheStudent.AddScore(0);
    johnTheStudent.AddScore(10);
    johnTheStudent.ShowStudent();  // Display the data in the Student Object
    
    Console.WriteLine($"\nThe sum of scores: {johnTheStudent.SumOfScores()}");
    Console.WriteLine($"\nThe avg of scores: {johnTheStudent.AvgOfScores()}");
<<<<<<< HEAD

   // I want to see just the name of a student
    //Console.WriteLine(aStudent.studentName);


    public string GetStudentName()
    {
        return studentName; //return the value in this private data number
    }

    public List<double> GetTestScores()
    {
        return GetTestScores; // return the value in this private data member 
    }

    public void SetStudentName(string newName)
    {
        studentName = newName;
    }

    public void SetTestScores(List<double> newScores)
    {
        testScores = newScores;
        
    }
/***********************************************************************************************************************
**********************************************************************************************************************/


// WE need to provide a ToString() method  to return a string repres 


// We need a method to allow the user to add scores to our testScores List 
// Every method requires a method signature and a body 
// Method signature: access return 
//                  type    type   MethodName(parameters)
// Method body: inside { } following method signature 
        public void AddScore(double score) // Accept a scoreand return nothing 
        {
            testScores.Add(score);
        }

//Allow the user to get the sum of the scores   



=======
    
    // I want see just the name of a Student
    // Use have to a getter (if it exists) to access the data

    Console.WriteLine($"aStudent object has the name {aStudent.GetStudentName()}");
    Console.WriteLine($"aStudent2 object has the name {aStudent2.GetStudentName()}");
    
    // Change the name of aStudent
    aStudent.SetStudentName("Pete");
    aStudent.ShowStudent();

    List<double> newScores = new List<double>();
    newScores.Add(0);
    aStudent.SetTestScores(newScores);
    aStudent.ShowStudent();
>>>>>>> d7911bb22c68dc0f64264c999a3dd97a50672135
    }
}