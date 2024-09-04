using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_level1
{
    internal class Arrays
    {
        public static void ArraysAreBound()
        {
            int[] ints = { 1, 2, 3 };
            ints[0] = 1;
            ints[1] = 2;
            ints[2] = 3;
            //ints[3] = 4;  //Index was outside the bounds of the array.
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write(ints[i] + " ");

            }
            Console.ReadLine();
        }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
    }
}
