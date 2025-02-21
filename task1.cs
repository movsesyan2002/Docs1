// Task 1: Basic C# Program
// Elements: simple types
// Task: Write a simple C# console application that prints:
// Your full name
// Your favorite programming language
// The current year (use DateTime.Now.Year)
// Print all values using Console.WriteLine().
// Example Output:
// Hello, my name is John Doe. 
// My favorite programming language is C#. 
// The current year is 2025.

using System;
using System.Globalization;
using System.Text;

class Program {
    static void Main(string[] args) 
    {   
        
        string name = "David";
        string favorite = "My favorite language is C#";
        Console.WriteLine($"My name is {name}\n{favorite}\nThe current year is {DateTime.Now.Year}");  
        
    
    }
}
