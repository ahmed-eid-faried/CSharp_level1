using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_level1
{
    internal class Program
    {
        static void Output()
        {
            Console.WriteLine("========================WriteLine=========================");
            Console.WriteLine("Hello World!");
            Console.WriteLine("My Name is Ahmed Mady");
            Console.WriteLine("I am Learning C#");
            Console.WriteLine("It is an easy language to learn :-)");
            Console.WriteLine("The sum of 30 + 20 is " + (30 + 20));
            Console.WriteLine("The sum of 30 + 20 is " + 30 + 20 + " without brackets");
            Console.WriteLine("=========================Write=============================");
            Console.Write("Hello World!");
            Console.Write("My Name is Ahmed Mady");
            Console.Write("I am Learning C#");
            Console.Write("It is an easy language to learn :-)");
            Console.WriteLine("\n==========================================================");
            Console.ReadKey();

        }




        static void Main(string[] args)
        {
            //Console.WriteLine("hi, ahmed mady");
            //Console.ReadKey();
            Output();
        }
    }
}
