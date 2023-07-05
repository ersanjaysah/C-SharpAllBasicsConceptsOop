using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Problem2
    {
       public static void Number()
       {
            Console.Write("Enter the first decimal number: ");
            decimal num1 = decimal.Parse(Console.ReadLine());

            Console.Write("Enter the second decimal number: ");
            decimal num2 = decimal.Parse(Console.ReadLine());

            // square of sum of two number
            decimal sumResult = (num1 + num2) * (num1 + num2);

            // square of difference of two number
            decimal diffResult = (num1 - num2) * (num1 - num2);

            Console.WriteLine("Square of the sum: " + sumResult);
            Console.WriteLine("Square of the difference: " + diffResult);
        }
    }
}
