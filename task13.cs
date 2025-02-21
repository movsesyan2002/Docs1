// Task 13: Convert Days to Weeks and Days
// Elements: simple types, without loops

// Task:
// Take an integer input representing days.
// Convert it into weeks and remaining days.
// Example 
// Input: 10 

// Output: 1 week and 3 days


using System;

class Program {

    static void Main(string[] args) {
       

        Console.Write("enter day");
        int day = int.Parse(Console.ReadLine());
        Console.WriteLine($"{day / 7} week and {day % 7} days");


    }
}