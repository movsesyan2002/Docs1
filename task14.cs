// Task 14:  Find the Type of Triangle
// Elements: simple types, without loops

// Task: 
// Ask the user for three sides of a triangle.
// Determine if it is:
// Equilateral (all sides equal)
// Isosceles (two sides equal)
// Scalene (no sides equal)


using System;

class Program {

    static void Main(string[] args) {
        

        Console.WriteLine("enter triagel sides");
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());

        if (first.Equals(second) && second.Equals(third)) 
        {
             Console.WriteLine($"the triagle is Equilateral");
        }
        else if (first.Equals(second) || second.Equals(third) || third.Equals(first))
        {
            Console.WriteLine($"the triagle is Isosceles");
        }
        else 
        {
            Console.WriteLine($"the triagle is Scalene");
        }

      
    }
}