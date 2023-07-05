using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class CustomException
    {
        public class OddNumberException : Exception
        {
            //Overriding the Message property
            public override string Message
            {
                get
                {
                    return "Divisor Cannot be Odd Number";
                }
            }
            //Overriding the HelpLink Property
            public override string HelpLink
            {
                get
                {
                    return "Get More Information from here: https://dotnettutorials.net/lesson/create-custom-exception-csharp/";
                }
            }
        }
    }
}
