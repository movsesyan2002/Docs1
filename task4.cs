// Task 4: String Operations
// Elements: simple types
// Task:
// Ask the user for their first and last name.
// Convert them to uppercase and print the full name.
// Print the total number of characters (excluding spaces).
// Example Input:

// First name: John 
// Last name: Doe
// Output:
// Full Name: JOHN DOE Character Count: 7

using System;
using System.Globalization;
using System.Text;

class Program {
    static void Main(string[] args) 
    {   
     
        Console.WriteLine("input name");
        string? name = Console.ReadLine();
        Console.WriteLine("input lastname");
        string? lastname = Console.ReadLine();
        string fullname = string.Concat(name, " ", lastname);
        fullname = fullname.ToUpper();
        Console.WriteLine($"{fullname}");
        Console.WriteLine($"the len is {(fullname.Replace(" ", "")).Length}");
        
    }
}