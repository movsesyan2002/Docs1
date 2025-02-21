// Task 20: Create a Jagged Array and Fill It with Numbers 
// Elements: simple types, without loops, jagged array
// Task: 
// Create a jagged integer array 
// Fill it with numbers.
// Print the array.


using System;

class Program {

    static void Main(string[] args) {
        
        int[][] jaggedarray = new int[3][];
        jaggedarray[0] = new int[] {1,2,3,5};
        jaggedarray[1] = new int[] {1,5};
        jaggedarray[2] = new int[] {1,2,87,2,34,5};

        Console.WriteLine("jagged array is");
        for (int i = 0;  i < 3; i++) 
        {
            for (int j = 0; j < jaggedarray[i].Length; j++)
            {
                Console.Write($"{jaggedarray[i][j]} ");
            }
            Console.WriteLine();
        }
        
    }
}