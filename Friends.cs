using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp1
{
    public class Friends
    {
        //problems 2
        public static void friendsName()
        {
            string[] friendsName = { "Ram", "Shyam", "Mohan", "Gauri", "Ramesh" };

            for (int i = 0; i < friendsName.Length; i++)
            {
                Console.WriteLine(friendsName[i]);
            }
        }


        // Problem 3
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

        // problems 4

        public static void upperAndLowerCase()
        {
            Console.Write("enter the place where you have visited most : ");
            string visitedPlace = Console.ReadLine();

            Console.WriteLine("Uppercase :" + visitedPlace.ToUpper());
            Console.WriteLine("Lowercase :" + visitedPlace.ToLower());
        }

        // Problems 5

        public static void problem5()
        {
            Console.Write("Enter a number : ");
            string allNumbers = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" " + allNumbers);
            }

        }

        //problem 6

       //public static void problem6(string[])
       // {
       //     // Check if the command line argument is provided
       //     if (name.Length == 0)
       //     {
       //         Console.WriteLine("No command line argument provided.");
       //         return;
       //     }

       //     // Join the different parts of the command line argument
       //     string fullName = string.Join(" ", name);

       //     // Print the number of parts in the name
       //     int numberOfParts = name.Length;
       //     Console.WriteLine("Number of parts in the name: " + numberOfParts);

       //     // Print the joined name
       //     Console.WriteLine("Joined name: " + fullName);
       // }


        // problems 7
        public static void problem7()
        {
            Random random = new Random();

            // Generate and store 5 random numbers between 10 and 50
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = random.Next(10, 51);
            }

            Console.WriteLine("Generated numbers are : ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(numbers[i] + " "); // printing the random no. in one line 
            }
            Console.WriteLine();

            
            double sum = 0; //here it will store all sum value
            for (int i = 0; i < 5; i++)
            {
                sum += numbers[i];
            }

            double average = sum / 5;

            // Print the average
            Console.WriteLine("Average: " + average);
        }

        // problem 8
        public static void problem8()
        {
            Console.Write("Enter the diameter of the circle: ");
            double diameter = double.Parse(Console.ReadLine());

            double radius = diameter / 2;

            double perimeterOfaCircle = 2 * Math.PI * radius;  //2*pie*r

            double areaOfaCircle = Math.PI * Math.Pow(radius, 2); //pie*rsq

            // Print the perimeter and area
            Console.WriteLine("Perimeter of the circle: " + perimeterOfaCircle);
            Console.WriteLine("Area of the circle: " + areaOfaCircle);
        }

        //problem 9

        public static void problem9()
        {
            Console.Write("Input a year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Input a month [1-12]: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Input a day [1-31]: ");
            int day = int.Parse(Console.ReadLine());

            DateTime currentDate = new DateTime(year, month, day);

            DateTime nextDate = currentDate.AddDays(1); //adding 1 day in current date 

            // Format the next date as "yyyy-MM-dd"
            string formattedNextDate = nextDate.ToString("yyyy-MM-dd");

            // Print the next date
            Console.WriteLine("The next date is [yyyy-MM-dd]: " + formattedNextDate);
        }

        // problem 10 
        public static void problem10()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }

            stopwatch.Stop();

            // Get the elapsed time
            TimeSpan elapsedTime = stopwatch.Elapsed;

            // printing the elapsed time
            Console.WriteLine("Execution Time is : " + elapsedTime);
        }

        // problem 11

        public static void problem11()
        {
            string numbers = ""; // it will store the no with , seperated

            for (int i = 2000; i <= 3200; i++)
            {
                if (i % 7 == 0 && i % 5 != 0)
                {
                    numbers += i + ","; // storing the number
                }
            }

            if (!string.IsNullOrEmpty(numbers))
            {
                numbers = numbers.TrimEnd(','); // it will removing the comma in last if the number will end 
            }

            Console.WriteLine(numbers);
        }

        // problem 12

        public static void problem12()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            long factorial = FactorialFunction(number);

            // Print the factorial
            Console.WriteLine("Factorial of " + number + " is: " + factorial);
        }

        //
        private static long FactorialFunction(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }

            long result = 1; // variable 
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }

        //problem 13
        public static void PrintNumbers(int number)
        {
            if (number <= 100)
            {
                Console.WriteLine(number);
                PrintNumbers(number + 1);
            }
        }

        // problem 16
        public static void problem16()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            bool isAPresent = input.Contains('a');
            bool isEPresent = input.Contains('e');
            bool isPPresent = input.Contains('p');
            if (isAPresent && isEPresent && isPPresent)
            {
                Console.WriteLine("All Present");
            }
            else if (isAPresent || isEPresent || isPPresent)
            {
                Console.WriteLine("One or more - Present");
            }
            else
            {
                Console.WriteLine("None Present");
            }
        }

        // problem 17
        public static void avgOfFloat()
        {
            double[] arr = { 1.1, 2.7, 6.9, 2.8, 18.3 };

            int i = 0;
            double sum = 0;
            double average = 0.0d;

            for (i = 0; i < arr.Length; i++)
            {
                sum += arr[(int)i];
            }

            average = (double)sum / arr.Length;

            Console.WriteLine("Average of Array elements: " + average);
        }

        // problem 19
        public static void shiftingAllZeros()
        {
            int[] Arraynum = { 5, 6, 0, 4, 6, 0, 9, 0, 8 };
            int n = Arraynum.Length;
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (Arraynum[i] != 0)
                {
                    int temp = Arraynum[j];
                    Arraynum[j] = Arraynum[i];
                    Arraynum[i] = temp;
                    j++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(Arraynum[i]);
                Console.Write(" ");
            }

        }

        //problem 24
        public static void secondLargest()
        {
            int max = 0;
            int secondmax = 0;
            int[] arr = { 2, 11, 7, 12, 4 };

            for (int r = 0; r < arr.Length; r++)
            {
                if (max < arr[r])
                {
                    max = arr[r];
                }
                Console.Write(" " + arr[r] + "\n");
            }

            for (int r = 0; r < arr.Length; r++)
            {
                if (secondmax < arr[r] && arr[r] < max)
                {
                    secondmax = arr[r];
                }
            }
            Console.WriteLine("second largest number is : " + secondmax);
        }

        // problem 29
        public static void primeNumber()
        {
            for (int number = 1; number <= 100; number++)
            {
                int count = 0;
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)  //prime no. is divide by 1 and itself 
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.Write(number +" ");
                }
            }
        }


        // problem 27
       public static void ConvertDays(int days)
        {
            int years = days / 365;
            int remainingDays = days % 365;
            int months = remainingDays / 30;
            remainingDays %= 30;
            int weeks = remainingDays / 7;

            Console.WriteLine("Years: " + years);
            Console.WriteLine("Months: " + months);
            Console.WriteLine("Weeks: " + weeks);
           
        }
    }
}
