using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal interface IMultipleInterfaceParent1
    {
        public void mobilecalling();

        public void mobileSMS();
    }

    internal interface IMultipleInterfaceParent2
    {
        public void mobileGame();
    }

    class childInterface : IMultipleInterfaceParent1, IMultipleInterfaceParent2
    {
        public void mobilecalling()
        {
            Console.WriteLine("people can able to call by mobile by dialing number");
        }

        public void mobileGame()
        {
            Console.WriteLine("in mobile game there are inbuilt game");
        }

        public void mobileSMS()
        {
            Console.WriteLine("you can send msg to other by text");
        }
    }
}
