using System;
using System.Collections;
using static ConsoleApp1.CustomException;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Friends.friendsName();

            // Friends.Number();

            // Friends.upperAndLowerCase();

            //Friends.problem5();

            // Friends.problem7();

            // Friends.problem8();

            // Friends.problem9();

            //Friends.problem10();

            // Friends.problem11();

            //Friends.problem12();

            //Friends.PrintNumbers(1);

            //  Friends.problem16();

            //Console.WriteLine("implementation of prime number");
            // Friends.primeNumber();


            //Console.Write("Enter the number of days: ");
            //int days = Convert.ToInt32(Console.ReadLine());
            //Friends.ConvertDays(days);

            //Console.WriteLine("implementation of second largest number from an array");
            // Friends.secondLargest();

            // Console.WriteLine("implementation of avg of an array");
            //Friends.avgOfFloat();


            // Console.WriteLine("implementation of sifting all zeros at last ");
            //Friends.shiftingAllZeros();

            // *************************************************  OOPs  *********************************************

            //ClassAndClassMembers classAndClassMembers = new ClassAndClassMembers();
            //Console.WriteLine(classAndClassMembers.fruit="Guava");
            //Console.WriteLine(classAndClassMembers.number);
            //classAndClassMembers.newMethod();

            //Console.WriteLine("implementation of constructor");
            //Constructors constructors = new Constructors();
            //constructors.fname = "sanjay";
            //constructors.lname = "sah";
            //Console.WriteLine(constructors.fname+" " +constructors.lname);

            //Properties properties = new Properties();
            //properties.fname = "sanjay";
            //properties.lname = "sah";
            //Console.WriteLine(properties.fname);
            //Console.WriteLine(properties.lname);

            //Console.WriteLine("implementation of inheritance");
            //InheritanceChild bankATM = new InheritanceChild();
            //Console.WriteLine(bankATM.pnbbank);
            //Console.WriteLine(bankATM.sbibank);
            //bankATM.pnbAtm();
            //bankATM.sbiAtm();

            //Console.WriteLine("implementation of polymorphism");
            //PolymorphismBaseClass polymorphismBaseClass = new PolymorphismBaseClass();
            //PolymorphismBaseClass polyderivedclass = new PolimorphismDerived();
            //PolymorphismBaseClass bmwclass = new bmwclss();
            //polymorphismBaseClass.carBMW();
            //polyderivedclass.carBMW();
            //bmwclass.carBMW();

            //Console.WriteLine("implementation of abstraction class");
            //AbstractChild abstractChild = new AbstractChild();
            //abstractChild.carParts();
            //abstractChild.car();

            //Console.WriteLine("implementation of interface class");
            //InterfaceChild interfaceChild = new InterfaceChild();
            //interfaceChild.bank();
            //interfaceChild.car();

            //Console.WriteLine("implementation of multiple interface");
            //childInterface childInterface = new childInterface();
            //childInterface.mobilecalling();
            //childInterface.mobileSMS();
            //childInterface.mobileGame();

            //Console.WriteLine("implementation of Stack(LIFO) ");
            //DS_Stack_LIFO dS_Stack_LIFO = new DS_Stack_LIFO();
            //dS_Stack_LIFO.StackLifo();


            //Console.WriteLine("implementation of Queue(FIFO) ");
            //DS_Queue_FIFO dS_Queue_FIFO = new DS_Queue_FIFO();
            //dS_Queue_FIFO.QueueFIFO();

            //******************************* implementation of Hash Table **********************************
            //Hashtable ht = new Hashtable();
            //ht.Add("id",222);
            //ht.Add("name","sanjay");
            //ht.Add("salary",250000);
            //ht.Add("designation","SD");
            //ht.Add("company","banglore");

            //Console.WriteLine("Total no. of added value is : "+ht.Count);
            //Console.WriteLine("Employee Designation is : " + ht["designation"]);
            //foreach(object key in ht.Keys)
            //{
            //    Console.Write(key+ "   ");
            //}
            //Console.WriteLine();
            //foreach (object value in ht.Values)
            //{
            //    Console.Write(value+ "   ");
            //}

            // we have more method of hash table like Clear(), contains(), containsKey(), containsValue(), GetHashCode()
         // **************************************** End of Hash table ******************************************

            //Console.WriteLine("implementation of exception handling ");
            //ExceptionHandling exceptionHandling = new ExceptionHandling();
            //exceptionHandling.Exception_handling();

         // ****************************** Custom Exception started ********************************************   
            //Console.WriteLine("implementation of custom exception handling ");
            //int Number1, Number2, Result;
            //try
            //{
            //    Console.WriteLine("Enter First Number:");
            //    Number1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter Second Number:");
            //    Number2 = int.Parse(Console.ReadLine());
            //    if (Number2 % 2 > 0)
            //    {
            //        throw new OddNumberException();
            //    }
            //    Result = Number1 / Number2;
            //    Console.WriteLine(Result);
            //}
            //catch (OddNumberException one)
            //{
            //    Console.WriteLine($"Message: {one.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("End of the Program");
            //}

        // ******************************* End of custom exception *********************************************
            
        }
    }
}
