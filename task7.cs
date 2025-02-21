// Task 7: Finding Maximum in an Array
// Elements: simple types, without loops
// Task:
// Create an integer array with 5 elements.
// Find and print the largest number.
// Example Output:

// The largest number in the array is: 98

using System;
using System.Globalization;
using System.Text;

class Program {
    static void Main(string[] args) 
    {   

        int[] array = {13, 654, 76, 848, 4};
        Console.WriteLine($"{array.Max()}");

    }
}