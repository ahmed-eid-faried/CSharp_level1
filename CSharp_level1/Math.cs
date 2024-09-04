using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_level1
{
    internal class clsMath
    {
        public static void MathMethods()
        {
            Console.WriteLine("Max of 5, 10 is: {0}", Math.Max(5, 10));
            Console.WriteLine("Min of 5, 10 is: {0}", Math.Min(5, 10));
            Console.WriteLine("Squir Root of 64 is: {0}", Math.Sqrt(64));
            Console.WriteLine("Absolute (positive) value of  -4.7 is: {0}", Math.Abs(-4.7));
            Console.WriteLine("Round of 9.99 is: {0}", Math.Round(9.99));

            Console.ReadKey();
        }
        public static void RandomFunction()
        {
            Random rnd = new Random();
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine("Random from 0 TO 100 ===>> " + rnd.Next(0, 100)); // returns random integers >= 0 and < 100
                Console.Write((char)65 + " ===>> ");
                Console.WriteLine((char)90);
                Console.WriteLine("Random from A TO Z ===>> 65 ===>> 90 ===>> " + (char)(rnd.Next(65, 91))); // returns random integers >= 0 and < 100
                Console.WriteLine("===================================================");
                Console.Write((char)97 + " ===>> ");
                Console.WriteLine((char)122);
                Console.WriteLine("Random from a TO z ===>> 97 ===>> 122 ===>> " + (char)(rnd.Next(97, 123))); // returns random integers >= 0 and < 100
                Console.ReadKey();

            }
        }
    }
}
