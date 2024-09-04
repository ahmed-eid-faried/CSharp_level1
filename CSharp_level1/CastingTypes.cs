using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_level1
{
    internal class CastingTypes
    {
        //Type casting is when you assign a value of one data type to another type.
        //In C#, there are two types of casting:

        //Implicit Casting(automatically) - converting a smaller type to a larger type size
        //char -> int -> long -> float -> double
        public static void ImplicitCasting()
        {
            //Implicit casting is done automatically when passing a smaller size type to a larger size type
            int myInt = 17;
            double myDouble = myInt;       // Automatic casting: int to double
            Console.WriteLine(myInt);      // Outputs 17
            Console.WriteLine(myDouble);   // Outputs 17
            Console.WriteLine(myDouble + 0.3);
            Console.ReadKey();
        }

        //Explicit Casting(manually) - converting a larger type to a smaller size type
        //double -> float -> long -> int -> char
        public static void ExplicitCasting()
        {
            //Explicit casting must be done manually by placing the type in parentheses in front of the value.
            double myDouble = 17.88;
            int myInt = (int)myDouble;    // Manual casting: double to int
            Console.WriteLine(myDouble);   // Outputs 17.88
            Console.WriteLine(myInt);      // Outputs 17
            Console.ReadKey();
        }

        public static void TypeConversionMethods()
        {
            //It is also possible to convert data types explicitly by using built-in methods, such as Convert.ToBoolean,
            //Convert.ToDouble, Convert.ToString, 
            //Convert.ToInt32(int) and Convert.ToInt64(long)

            int myInt = 20;
            double myDouble = 7.25;
            bool myBool = true;
            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

            Console.ReadKey();
        }
        enum WeekDays
        {
            Monday = 0,
            Tuesday = 1,
            Wednesday = 2,
            Thursday,
            Friday,
            Saturday,
            Sunday = 6
        }
        public static void EnumsConversion()
        {
            Console.WriteLine(WeekDays.Friday); //output: Friday 
            int day = (int)WeekDays.Friday; // enum to int conversion
            Console.WriteLine(day); //output: 4 

            var wd = (WeekDays)5; // int to enum conversion
            Console.WriteLine(wd);//output: Saturday 

            Console.ReadKey();
        }
    }

}
