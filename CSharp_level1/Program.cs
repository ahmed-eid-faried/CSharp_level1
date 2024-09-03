﻿using System;
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
        static void NumbersDatatypes()
        {  //Byte

            byte b1 = 255;
            //  byte b2 = -128;// compile-time error: Constant value '-128' cannot be converted to a 'byte'
            sbyte sb1 = -128;
            sbyte sb2 = 127;
            Console.WriteLine("\nByte:");
            Console.WriteLine("Min={0} , Max={1}", Byte.MinValue, Byte.MaxValue);


            Console.WriteLine("\nSByte:");
            Console.WriteLine("Min={0} , Max={1}", SByte.MinValue, SByte.MaxValue);

            //Short
            short s1 = -32768;
            short s2 = 32767;
            // short s3 = 35000;//Compile-time error: Constant value '35000' cannot be converted to a 'short'

            ushort us1 = 65535;
            //  ushort us2 = -32000; //Compile-time error: Constant value '-32000' cannot be converted to a 'ushort'

            Console.WriteLine("\nShort:");
            Console.WriteLine("Min={0} , Max={1}", Int16.MinValue, Int16.MaxValue);

            Console.WriteLine("\nUShort:");
            Console.WriteLine("Min={0} , Max={1}", UInt16.MinValue, UInt16.MaxValue);

            //int
            int i = -2147483648;
            int j = 2147483647;
            //  int k = 4294967295; //Compile-time error: Cannot implicitly convert type 'uint' to 'int'.

            uint ui1 = 4294967295;
            // uint ui2 = -1; //Compile-time error: Constant value '-1' cannot be converted to a 'uint'

            Console.WriteLine("\nInt:");
            Console.WriteLine("Min={0} , Max={1}", Int32.MinValue, Int32.MaxValue);

            Console.WriteLine("\nUInt:");
            Console.WriteLine("Min={0} , Max={1}", UInt32.MinValue, UInt32.MaxValue);

            //Long
            long l1 = -9223372036854775808;
            long l2 = 9223372036854775807;

            ulong ul1 = 18223372036854775808ul;
            ulong ul2 = 18223372036854775808UL;

            Console.WriteLine("\nLong:");
            Console.WriteLine("Min={0} , Max={1}", Int64.MinValue, Int64.MaxValue);

            Console.WriteLine("\nULong:");
            Console.WriteLine("Min={0} , Max={1}", UInt64.MinValue, UInt64.MaxValue);


            //Float
            float f1 = 123456.5F;
            float f2 = 1.123456f;

            Console.WriteLine("\nFloat:");
            Console.WriteLine("Min={0} , Max={1}", float.MinValue, float.MaxValue);


            //double
            double d1 = 12345678912345.5d;
            double d2 = 1.123456789123456d;

            Console.WriteLine("\nDouble:");
            Console.WriteLine("Min={0} , Max={1}", double.MinValue, double.MaxValue);



            //Decimal
            //The decimal type has more precision and a smaller range
            //than both float and double,
            //and so it is appropriate for financial and monetary calculations.
            decimal d3 = 123456789123456789123456789.5m;
            decimal d4 = 1.1234567891345679123456789123m;

            Console.WriteLine("\nDecimal:");
            Console.WriteLine("Min={0} , Max={1}", decimal.MinValue, decimal.MaxValue);


            //Scientific Notation
            //Use e or E to indicate the power of 10 
            //as exponent part of scientific notation with float, double or decimal.

            double d = 0.12e2;
            Console.WriteLine(d);  // 12;

            float f = 123.45e-2f;
            Console.WriteLine(f);  // 1.2345

            decimal m = 1.2e6m;
            Console.WriteLine(m);// 1200000



            //hex & Binary
            int hex = 0x2F;
            int binary = 0b_0010_1111;

            Console.WriteLine(hex);
            Console.WriteLine(binary);

            Console.ReadKey();
        }
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
            //ImplicitlyTypedVariables();
            NumbersDatatypes();
        }
    }
}