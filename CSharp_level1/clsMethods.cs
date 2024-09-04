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

        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
    }
}
