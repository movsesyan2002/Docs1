// Task 6: Working with Operators
// Elements: simple types
// Task: Write a program that:
// Asks for two numbers.
// Prints the sum, difference, product, quotient, and remainder.
// Uses relational operators to check if the first number is greater than the second.
// Example Output:

// Sum: 15 
// Difference: 5 
// Product: 50 
// Quotient: 2 
// Remainder: 0 
// Is first number greater? True

using System;
using System.Globalization;
using System.Text;

class Program {
    static void Main(string[] args) 
    {   

        int number1;
        string? strnum = Console.ReadLine();
        Console.WriteLine(strnum);
        if (Int32.TryParse(strnum, out number1) == false) 
        {   
            Console.WriteLine("invalid input first number");
        }

        strnum = Console.ReadLine();
        int number2;
        if (Int32.TryParse(strnum, out number2) == false)
        {
            Console.WriteLine("invalid input second number");
        }

        Console.WriteLine($"the sum is {number1 + number2}\nthe devide is {number1 - number2}\nthe mul is {number1 * number2}\nthe quatos is {number1 / number2}\n Is first number is greater {number1 > number2}");
        

        
    }
}