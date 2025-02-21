// Task 5: Checking Palindrome String
// Elements: simple types, without loops
// Task: Write a program that asks the user for a word and checks if it's a palindrome (reads the same forward and backward).
// Example Input:
// Enter a word: radar
// Output:
// ‘radar’ is a palindrome.


using System;
using System.Globalization;
using System.Text;

class Program {
    static void Main(string[] args) 
    {   
    
        
        Console.WriteLine("input line");
        string? input = Console.ReadLine();
        if (input.SequenceEqual(input.Reverse()) == true) 
        {
            Console.WriteLine("is palindrome");
        }
        else
        {
            Console.WriteLine("not palindrome");
        }
        
    }
}