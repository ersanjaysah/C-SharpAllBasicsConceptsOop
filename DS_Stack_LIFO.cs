using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class DS_Stack_LIFO
    {
        public void StackLifo()
        {
            Stack obj = new Stack();

            obj.Push("car");
            obj.Push(50);
            obj.Push(null);
            obj.Push("1000");
            obj.Push("EMPLOYEE");

            Console.WriteLine("current value in stack is : ");
            foreach (var item in obj)
            {
                Console.Write(item + " "); // EMPLOYEE 1000 null 50 car
            }
            Console.WriteLine();

            obj.Push('P');
            obj.Push('Q');

            Console.WriteLine();
            Console.WriteLine("Now current value after adding in stack is : ");
            foreach (var item in obj)
            {
                Console.Write(item + " "); // Q P EMPLOYEE 1000 null 50 car
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Element at top of stack: " + obj.Peek()); //Q

            Console.WriteLine();
            Console.WriteLine("Removing the element from Stack "); 
            obj.Pop(); // Q
            obj.Pop(); // P
            obj.Pop(); // EMPLOYEE
            Console.WriteLine("Current stack is : ");
            foreach (var item in obj)
            {
                Console.Write(item + " "); // 1000 null 50 car
            }
            Console.WriteLine();
            Console.WriteLine("Total elements present after Pop : {0} ", obj.Count); // 4
        }
    }
}
