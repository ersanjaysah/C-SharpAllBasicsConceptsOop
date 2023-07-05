using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class ClassAndClassMembers
    {
       public string fruit = "Banana"; //by default all the fields are private
       public int number = 20;

        public void newMethod()
        {
            Console.WriteLine("these are all the members of the class which can be access by creating an object");
        }
    }
}
