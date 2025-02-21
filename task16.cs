// Task 16:  Find BMI (Body Mass Index)
// Elements: simple types, without loops

// Task: 
// Take the weight (kg) and height (m) as inputs.
// Calculate BMI using a given formula (BMI = weight / height^2).
// Categorize the result and print the output:
// BMI < 18.5 → Underweight
// 18.5 - 24.9 → Normal weight
// 25 - 29.9 → Overweight
// BMI ≥ 30 → Obese


using System;

class Program {

    static void Main(string[] args) {
       
        Console.WriteLine("enter weight");
        float weight = Single.Parse(Console.ReadLine());
        Console.WriteLine("enter height");
        float height = Single.Parse(Console.ReadLine()); 

        float bmi = weight / (height * height);

        if (bmi < 18.5) {
            Console.WriteLine("Underweight");
        }
        else if (bmi >= 18.5 && bmi < 24.9) {
            Console.WriteLine("Normal weight");
        }
        else if (bmi >= 25 && bmi < 29.9) {
            Console.WriteLine("Overweight");
        }
        else if (bmi >= 30) {
            Console.WriteLine("Obese");
        }

        
    }
}