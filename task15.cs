// Task 15: Check Uppercase or Lowercase
// Elements: simple types, without loops

// Task: 
// Ask the user to enter a character.
// Determine if it is uppercase, lowercase, or neither.
//  Hint: Use char.IsUpper() and char.IsLower().


using System;

class Program {

    static void Main(string[] args) {
       

        Console.WriteLine("enter char");
        char symbol = char.Parse(Console.ReadLine());
        if (char.IsUpper(symbol)) 
        {
            Console.WriteLine("symbol is uppercase");
        }
        else if (char.IsLower(symbol)) 
        {
            Console.WriteLine("symbol is lowercase");
        }
        else {
            Console.WriteLine("symbol is neiter");
        }

    }
}