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
        static void FormattedString()
        {
            Console.WriteLine("Welcome to {0}", "Egypt");
            Console.WriteLine("Hi, My Name Is {0} And I Live In {1}.", "Ahmed Mady", "Egypt");
            Console.ReadLine();
        }
        static void EscapeCharacters()
        {
            Console.WriteLine("Useful Escape Characters:\n");

            //Newline
            Console.WriteLine("Newline:");
            Console.WriteLine("Welcome to \n Egypt\n");

            //Tab
            Console.WriteLine("Tab:");
            Console.WriteLine("Welcome to\tEgypt\n");

            //Backspace
            Console.WriteLine("Backspace:");
            Console.WriteLine("Welcome to \bEgypt\n");

            //Single quote
            Console.WriteLine("Single Quote:");
            Console.WriteLine("I\'m Ahmed Mady.\n");

            //Double quote
            Console.WriteLine("Double Quote:");
            Console.WriteLine("Welcome to \"Egypt\"\n");

            //Backslash
            Console.WriteLine("Backslash:");
            Console.WriteLine("Welcome to \\ Egypt\\\n");

            //Alert
            Console.WriteLine("Alert:");
            Console.WriteLine("\a");


            Console.ReadKey();
        }
        //static void Test() { Console.ReadLine(); }
        //static void Test() { Console.ReadLine(); }
        //static void Test() { Console.ReadLine(); }
        //static void Test() { Console.ReadLine(); }
        //static void Test() { Console.ReadLine(); }

        static void Main(string[] args)
        {
            //Console.WriteLine("hi, ahmed mady");
            //Console.ReadKey();
            /////////////////////////////////////////////
            //Output();
            //FormattedString();
            EscapeCharacters();
        }
    }
}
