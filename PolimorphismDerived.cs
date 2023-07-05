using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class PolimorphismDerived:PolymorphismBaseClass
    {
        public override void carBMW()
        {
            Console.WriteLine("this BMW is from clild class 1");
        }
    }

    internal class bmwclss:PolymorphismBaseClass
    {
        public override void carBMW()
        {
            Console.WriteLine("this BMW is from clild class 2");
        }

    }
}
