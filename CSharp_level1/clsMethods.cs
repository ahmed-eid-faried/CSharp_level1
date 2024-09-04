using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_level1
{
    internal class clsMethods
    {
        //////////////////////////////////////////////////////////////////////
        static void PrintMyName()
        {
            Console.WriteLine("Ahmed Mady");
        }
        public static void Methods()
        {
            PrintMyName();
            Console.ReadKey();
        }
        //////////////////////////////////////////////////////////////////////
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
        //////////////////////////////////////////////////////////////////////
        static string GetMyName()
        {
            return "Ahmed Mady";

        }
        public static void ReturnValues()
        {
            Console.WriteLine("My Name is {0}", GetMyName());
            Console.ReadLine();
        }
        /////////////////////////////////////////////////////////////////////
        static void MyMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }
        public static void NamedArguments()
        {
            //see the order of sending parameters is not important.
            MyMethod("Omar", "Saqer", "AHMED");
            //NamedArguments
            MyMethod(child3: "Omar", child2: "Saqer", child1: "AHMED");
            Console.ReadKey();
        }
        //////////////////////////////////////////////////////////////////////
        static int Sum(int Num1, int Num2)

        {
            return Num1 + Num2;
        }
        static int Sum(int Num1, int Num2, int Num3)

        {
            return Num1 + Num2 + Num3;
        }
        static int Sum(int Num1, int Num2, int Num3, int Num4)

        {
            return Num1 + Num2 + Num3 + Num4;
        }
        public static void SumOverloading()
        {
            //we have 3 diffrent methods but with the same name.
            Console.WriteLine(Sum(10, 20));
            Console.WriteLine(Sum(10, 20, 30));
            Console.WriteLine(Sum(10, 20, 30, 40));
            Console.ReadKey();
        }
        //////////////////////////////////////////////////////////////////////
    }
}
