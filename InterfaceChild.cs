using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class InterfaceChild : Interface1
    {
        public void bank()
        {
            Console.WriteLine("this is from interface child class of bank method");
        }

        public void car()
        {
            Console.WriteLine("this is from interface child class of car method");
        }
    }
}
