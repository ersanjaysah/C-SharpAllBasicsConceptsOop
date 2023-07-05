using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class AbstractChild : AbstractParent
    {
        public override void car() //abstract method implemented here by using override keyword
        {
            Console.WriteLine("this this car from abstract child calss");
        }
    }
}
