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
        static void SingleLineMultipleLinesComments()
        {  //this is a single line comment 
            Console.Write("My Name is Mohammed Abu-Hadhoud ");
            /*

             This is 
             a multiple line
             comment.

             */
            Console.ReadKey();
        }
        static void Vairables()
        {
            string name = "ahmed mady";
            Console.WriteLine(name);
            int x = 12, y = 13;
            //wrong
            Console.WriteLine("x + y = " + x + y);
            //correct
            Console.WriteLine("x + y = " + (x + y));
            double MyDouble = 22.333d;
            Console.WriteLine("MyDouble = " + MyDouble);
            float MyFloat = 22.333f;
            Console.WriteLine("MyFloat = " + MyFloat);
            char myChar = '#';
            Console.WriteLine("myChar = " + myChar);
            bool myBool = true;
            Console.WriteLine("myBool = " + myBool);

            Console.ReadLine();
        }
        static void ImplicitlyTypedVariables()
        {
            var x = 122;
            var y = 22.55f;
            var z = "ahmed";
            Console.WriteLine("x={0} , y={1} , z={2}", x, y, z);
            Console.ReadLine();
        }
        //static void Test() { Console.ReadLine(); }
        //static void Test() { Console.ReadLine(); }

        static void Main(string[] args)
        {
            //Console.WriteLine("hi, ahmed mady");
            //Console.ReadKey();
            /////////////////////////////////////////////
            //Output();
            //FormattedString();
            //EscapeCharacters();
            //SingleLineMultipleLinesComments();
            //Vairables();
            ImplicitlyTypedVariables();
        }
    }
}
