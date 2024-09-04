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

        static void PrintMyInfo(string Name, byte Age)
        {
            Console.WriteLine("Name= {0} , Age= {1}", Name, Age);
        }

        public static void ParametersAndArguments()
        {
            PrintMyInfo("AHMED MADY", 27);
            Console.ReadKey();
        }

        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
    }
}
