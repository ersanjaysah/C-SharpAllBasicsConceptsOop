using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class InheritanceChild: Inheritance
    {
        public void sbiAtm()
        {
            Console.WriteLine("this is the atm of sbi Bank");
        }

        public void pnbAtm()
        {
            Console.WriteLine("this is the atm of pnb Bank");
        }
    }
}
