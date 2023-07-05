using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class AbstractParent
    {
        public abstract void car(); //without body
        public void carParts()
        {
            Console.WriteLine("this is cars parts"); // with body
        }

    }
}
