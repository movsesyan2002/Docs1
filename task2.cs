// Task 2: Working with Variables and Literals
// Elements: simple types
// Task: Declare and initialize the following variables:
// A person's age (int)
// The price of a book (double)
// If they are a student (bool)
// A single character (char)
// Print all values using Console.WriteLine().

using System;
using System.Globalization;
using System.Text;

class Program {
    static void Main(string[] args) 
    {   
        
        int age = int.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());
        bool check = bool.Parse(Console.ReadLine()); 
        char key = char.Parse(Console.ReadLine());
        Console.WriteLine($"the results are:\n{age}\n{price}\n{check}\n{key}");
        

    }
}