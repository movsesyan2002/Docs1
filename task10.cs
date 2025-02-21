// // Task 10: Simple Calculator
// // Elements: simple types, without loops,  switch-case

// // Task:
// // Ask the user to enter two numbers.
// // Ask for an operator (+, -, *, /).
// // Perform the calculation using switch-case.
// // Example Input:

// // Enter first number: 10 Enter second number: 5 Enter operation (+, -, *, /): *

// // Output:
// // Result: 50


class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        char extension = char.Parse(Console.ReadLine());

        switch (extension) 
        {
            case '+':
            Console.WriteLine($"{number + number2}");
            break;
            case '-':
            Console.WriteLine($"{number - number2}");
            break;
            case '*':
            Console.WriteLine($"{number * number2}");
            break;
            case '/':
            Console.WriteLine($"{number / number2}");
            break;

            default:
            Console.WriteLine("invalid input");
            break ;
        }
    }
}        