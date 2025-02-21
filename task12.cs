// Task 12: Check Leap Year
// Elements: simple types, without loops

// Task:
// Take an integer input and.
// Determine if it is a leap year.
//  Hint: A year is a leap year if It is divisible by 400, or It is divisible by 4 but not by 100.


using System;

class Program {

    static void Main(string[] args) {
       
        Console.WriteLine("enter checking leap year");
        int leapyear = int.Parse(Console.ReadLine());
        if ((leapyear % 400 == 0 || leapyear % 4 == 0) && leapyear % 100 != 0) 
        {
            Console.WriteLine($"the year {leapyear} is leap");
        }
        else
        {
            Console.WriteLine($"the year {leapyear} is not leap");
        }
        
    }
}