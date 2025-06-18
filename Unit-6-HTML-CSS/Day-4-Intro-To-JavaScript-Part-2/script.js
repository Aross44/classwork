/*
    Example of a multi-line comment just like in C#/Java
*/

// Single line comment

/*****************************************************************************
 * We test the JavaScript code using Inspect in the browser
 ****************************************************************************/

/**
 * Functions start with the word function.
 * They don't have a return type and the naming convention is camel-case.
 */
function variables() {
  // Declares a variable where the value cannot be changed
  const aVariable = 42;
  
  // console.log() - display data on the console (Console.WriteLine() or System.out.println()) 
  // JavaScript support interpolation to construct strings similar to C#
  //
  // Interpolation:  `words ${variable}`  C#: $(words {aVariable})
  console.log(`The value in aVariable is: ${aVariable}`)

  // Declares a variable those value can be changed

  let itBe = 87.4;
  console.log(`The value in itBe is: ${itBe}`)

  itBe = 1776;
  console.log(`The value in itBe is: ${itBe}`)

  // Declares a variable that will always be an array
  let stuff = ["things", 'Kevin', "Hello", 774.6]
  console.log(`The value in stuff is: ${stuff}`) // Display teh array as a variable - elements separated by ,
  console.log(stuff)    // display the array name is shows the array and it's elements in a dropdown
  console.table(stuff)

}

/**
 * Functions can also accept parameters.
 * Notice the parameters do not have types.
 * @param {Number} param1 The first number to display
 * @param {Number} param2 The second number to display
 */
function printParameters(param1, param2) {
  console.log(`The value of param1 is ${param1}`); 
  console.log(`The value of param2 is ${param2}`);
}

/**
 * Compares two values x and y.
 * == is loose equality - values are the same but the types dont matter
 * === is strict equality - values and the type mush be the same 
 * @param {Object} x
 * @param {Object} y
 */
function equality(x, y) {
  console.log(`x is ${typeof x}`);  // ttypeof will returnr the data type of the variable
  console.log(`y is ${typeof y}`);

  console.log(`x == y : ${x == y}`);
  console.log(`x === y : ${x === y}`); 
}

/**
 * Each value is inherently truthy or falsy.
 * Every value if used in a conditional statement will be true or false
 * false, 0, '', null, undefined, and NaN are always falsy
 * everything else is always truthy
 * @param {Object} x The object to check for truthy or falsy,
 */
function falsy(x) {
  if (x) {  // Use the parameter in a conditional statement
    console.log(`${x} is truthy`);
  } else {
    console.log(`${x} is falsy`);
  }
}

/**
 *  JavaScript Objects are Not the same as Object-Oreiented Objects  
 * 
 * Objects are simple key-value pairs
    - values can be primitive data types
    - values can be arrays
    - or they can be functions
 //JASON - JavaScript Object Notation - how we share data on between devices

    */
function objects() {
  const person = {         //JavaScript objects are enclosed in {}
    firstName: "James T.", // atributes are specified with the name : value
    lastName: "Kirk",      // multiple values are seperated by comas
    age: 42,               // Numbers are coded as human, non human are inside "" or ''
    employees: [           // Arrays are enclosed in []
      "Spock",             //elements in the array are seperated by comas 
      "McCoy",
      "Uhura",
      "Scotty"
    ]
  };

  // Log the object - display the object 
  console.log(person); // This will display the data in a pretty easy to read format
  console.log('person contains: ${person}') // This doesnt display thre data 
 console.table(person);  // Formatted display
 
  // Log the first and last name -accessing attributes in an object: objectName.attributeName
  console.log (`Person's first name: ${person.firstName}`)
  console.log (`    last name: ${person.lastName}`)

  console.log(formatPerson(person)) // call print person function to display a sentence about the data 
  // Log each employee- iterate/Go through an array of objects

  // Just like in C# and Java we use a for loop to go through an array

  //          arrayName.lenth is the numbers of element
  for (let i=0; i < person.employees.length; i ++) {
    console.log ('Emplyee #${i+1}: ${person.emloyees [i]}')
  }
};

/*
########################
Function Overloading
########################
 In C# and Java Function Overloading is when functions have the same name, but different parameters
 and the compiler determins which function to call based on the data types of the parameters

 In C#/Java function overloads are used for multiple constructors of a class

Function Overloading is not available in Javascript. If you declare a
function with the same name, more than one time in a script file, the
earlier ones are overridden and the most recent one will be used.
*/

function Add(num1, num2) {   // This function is overridden by the one defined below 
  return num1 + num2;       // it will never be called
}

function Add(num1, num2, num3) { // This functiom overrides any previously called same name function
  return num1 + num2 + num3;
}

/*
########################
Math Library
########################

A built-in `Math` object has properties and methods for mathematical constants and functions.
*/

function mathFunctions() {
  console.log("Math.PI : " + Math.PI);
  console.log("Math.LOG10E : " + Math.LOG10E);
  console.log("Math.abs(-10) : " + Math.abs(-10));
  console.log("Math.floor(1.99) : " + Math.floor(1.99));
  console.log("Math.ceil(1.01) : " + Math.ceil(1.01));
  console.log("Math.random() : " + Math.random());
 
}

/*
########################
String Methods
########################

The string data type has a lot of properties and methods similar to strings in Java/C#
*/

function stringFunctions(value) {
  console.log(`.length -  ${value.length}`);
  console.log(`.endsWith('World') - ${value.endsWith("World")}`);
  console.log(`.startsWith('Hello') - ${value.startsWith("Hello")}`);
  console.log(`.indexOf('Hello') - ${value.indexOf("Hello")}`);

  console.log(`.split(value,' ' ) - ${value.split(" ")}`)
  console.table(value.split(" "))

  //Both substring and substr start at  character 0 (sae as C#/Java)


  //Extract 5 chars starting at position 2 from the string using substr (start-pos, end - pos)
  // substr will return chars including the character at end-pos
 console.log(`value.substr(5,9)- ${value.substr(5,9)}`)


 //Extract chars 2 & 3 from the string using substr (start-pos, end - pos)
 // substring will return characters up to but not including the character at end-pos
 console.log(`value.substring(5,9)- ${value.substring(5,9)}`)
  /*
    Other Methods
        - split(string)
        - substr(number, number)
        - substring(number, number)
        - toLowerCase()
        - trim()
        - https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/String
    */
}

/*
##################################
Array Manipulation Functions
##################################
*/
function arrayFunctions(){

let stooges = [   //Define a JvaScript array
              `Moe`
              `Larry`
              `Curly`
              ]
console.table(stooges) //Display array as formated display
            
//JavaScript array is like a list in C# or ArrayList in Java

stooges.push ("Shemp") // Add an element to the end of the array
console.table(stooges) // Display array as formatted display


stooges.unshift("Curly Joe") //Add an element to the start of the array
console.table(stooges)      //Display array as formated display

//To insert into an array: splice (start-index.0,"new-elements")
stooges.unshift("3,0,"Groucho", "Chico","Harpo") //Add an element to the start of the array
console.table(stooges)      //Display array as formated display



}