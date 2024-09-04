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
    
    }
}
