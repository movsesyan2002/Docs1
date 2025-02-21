// Task 17: Set or Clear the K-th Bit of a Number
// Elements: simple types, without loops, bitwise operators
// Task: 
// Ask the user to specify the operation (set or clear).
// Take the number and K.
// Do the operation and print the output.



using System;

class Program {

    static void Main(string[] args) {
        
        Console.WriteLine("enter clear or set");
        string operation = Console.ReadLine();
        Console.WriteLine("take the number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("take the index");
        int k = int.Parse(Console.ReadLine());

        if (k > 31) {
            Console.WriteLine("invalid index");
        }
        else if (string.Compare(operation, "clear") == 0) 
        {   
            int indexnum = number & 1 << k;
            indexnum = indexnum >> k;
            if (indexnum == 1) {
                number = number ^ 1 << k;
                Console.WriteLine($"{number}");
            }
            else {
                Console.WriteLine("index val is 0");
            }
        }
        else if (string.Compare(operation,"set") == 0) {
            int indexnum = number & 1 << k;
            indexnum = indexnum >> k;
            if (indexnum == 0) {
                number = number | 1 << k;
                Console.WriteLine($"{number}");
            }
            else
            {
                Console.WriteLine("the index val is 1");
            }
        }

     
    }
}