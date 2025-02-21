// Task 11: Check If a Number Is Positive, Negative, or Zero 
// Elements: simple types, without loops

// Task:
// Take an integer input and.
// Determine if it is positive, negative, or zero.
// Example Input:
// Enter the number: 10 

// Output:
// The number 10 is positive.


using System;

class Program {

    static void Main(string[] args) {

        Console.WriteLine("enter checking number");
        int checkingnumber = int.Parse(Console.ReadLine());
        if (checkingnumber < 0) 
        {
            Console.WriteLine($"the number {checkingnumber} is negative");
        }
        else if (checkingnumber > 0) 
        {
            Console.WriteLine($"the number {checkingnumber} is positive");
        }

        else
        {
            Console.WriteLine($"the number {checkingnumber} is zero");
        }

        
    }
}