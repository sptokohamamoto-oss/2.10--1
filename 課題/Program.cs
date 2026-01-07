using System;

    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 7;
            int num2 = 3;

        int sum = num1 + num2;
        Console.WriteLine($"{num1} +{num2} = {sum}");

        int difference = num1 - num2;
        Console.WriteLine($"{num1} - {num2} = {difference}");

        int Product = num1 * num2;
        Console.WriteLine($"{num1} * {num2} = {Product}");

        int quotient = num1 / num2;
        int remainder = num1 % num2;
        Console.WriteLine($"{num1} / {num2} = {quotient} 余り {remainder}");

               
        }

    }
