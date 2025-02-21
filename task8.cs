// Task 8: Even or Odd Using Conditional Operator
// Elements: simple types, Ternary operator
// Task: Ask the user for a number and check if it’s even or odd using the ternary operator.

// Example Output:

// Enter a number: 7 
// 7 is an odd number.


class Program {
    static void Main(string[] args) 
    {   
        
        Console.WriteLine("input the number");
        int number = int.Parse(Console.ReadLine());
        string result;
        result = (number % 2 == 0) ? "number is even" : "number is odd";
        Console.WriteLine(result);
        
    }
}