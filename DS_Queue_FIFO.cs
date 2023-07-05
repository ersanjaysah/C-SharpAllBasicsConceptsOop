using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class DS_Queue_FIFO
    {
        public void QueueFIFO()
        {
            Queue obj = new Queue();
            obj.Enqueue("SANJAY");
            obj.Enqueue(1);
            obj.Enqueue(100);
            obj.Enqueue(null);
            obj.Enqueue(2.4);
            obj.Enqueue("Sah123");

            foreach (var item in obj)
            {
                Console.Write(item + " "); // SANJAY 1 100 null 2.4 Sah123
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Total elements present in Queue: {0} ", obj.Count);

            obj.Dequeue(); //SANJAY
            obj.Dequeue(); // 1

            Console.WriteLine();
            Console.WriteLine("After Dequing the element from the Queue ");
            foreach (var item in obj)
            {
                Console.Write(item + " "); //  100 null 2.4 Sah123
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Total elements present after Dequing : {0} ", obj.Count); // 4


        }
    }
}
