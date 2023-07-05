using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class ExceptionHandling
    {
        public void Exception_handling()
        {
            try
            {
                Console.WriteLine("Enter the 1st number : ");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the 2nd number : ");
                int y = int.Parse(Console.ReadLine());

                int z = x / y;
                Console.WriteLine("the result is : " + z);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex1)
            {
                Console.WriteLine("Input must be numbric");
            }
            catch(Exception ex2)
            {
                Console.WriteLine(ex2.Message); //any other system exception can be handled here
            }
            finally
            {
                Console.WriteLine("end of the program");
            }
            
        }
    }
}
