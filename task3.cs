// Task 3: Array Manipulation
// Elements: simple types, without loops
// Task:
// Declare an integer array with 5 elements.
// Fill it with user input.
// Print the sum of all elements.
// Example Input:

// Enter number 1: 10 
// Enter number 2: 20 
// Enter number 3: 30 
// Enter number 4: 40 
// Enter number 5: 50

using System;
using System.Globalization;
using System.Text;

class Program {
    static void Main(string[] args) 
    {   
        
        int[] array = new int[5];
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"enter number {i + 1}:");
            string? num = Console.ReadLine();
            if (Int32.TryParse(num, out array[i]) == false) 
            {  
                Console.WriteLine("invalid input");
                break;
            }
            sum += array[i];
        }

        Console.WriteLine($"sum of elements is {sum}\n");
       
    }
}