using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_level1
{
    internal class clsMethods
    {
        static void PrintMyName()
        {
            Console.WriteLine("Ahmed Mady");
        }
        public static void Methods()
        {
            PrintMyName();
            Console.ReadKey();
        }

        static void PrintMyInfo(string Name, Nullable<byte> Age = null, string Address = "No Address")
        {
            Console.WriteLine("Name = {0} , Age = {1}, Address = {2}", Name, Age, Address);
        }

        public static void ParametersAndArguments()
        {
            PrintMyInfo("AHMED MADY");
            PrintMyInfo("AHMED MADY", 27);
            PrintMyInfo("AHMED MADY", 27, "Egypt");
            Console.ReadKey();
        }
        static string GetMyName()
        {
            return "Ahmed Mady";

        }
        public static void ReturnValues()
        {
            Console.WriteLine("My Name is {0}", GetMyName());
            Console.ReadLine();
        }
        static void MyMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }
        public static void Test()
        {
            //see the order of sending parameters is not important.
            MyMethod(child3: "Omar", child1: "Saqer", child2: "Hamza");
            Console.ReadKey();
        }
        //public static void Test() { Console.ReadLine(); }
    }
}
