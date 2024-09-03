using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            Console.WriteLine("Min={0} , Max={1}", short.MinValue, short.MaxValue);
            Console.WriteLine("Min={0} , Max={1}", Int16.MinValue, Int16.MaxValue);

            Console.WriteLine("\nUShort:");
            Console.WriteLine("Min={0} , Max={1}", ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("Min={0} , Max={1}", UInt16.MinValue, UInt16.MaxValue);

            //int
            int i = -2147483648;
            int j = 2147483647;
            //  int k = 4294967295; //Compile-time error: Cannot implicitly convert type 'uint' to 'int'.

            uint ui1 = 4294967295;
            // uint ui2 = -1; //Compile-time error: Constant value '-1' cannot be converted to a 'uint'

            Console.WriteLine("\nInt:");
            Console.WriteLine("Min={0} , Max={1}", int.MinValue, int.MaxValue);
            Console.WriteLine("Min={0} , Max={1}", Int32.MinValue, Int32.MaxValue);

            Console.WriteLine("\nUInt:");
            Console.WriteLine("Min={0} , Max={1}", uint.MinValue, uint.MaxValue);
            Console.WriteLine("Min={0} , Max={1}", UInt32.MinValue, UInt32.MaxValue);

            //Long
            long l1 = -9223372036854775808;
            long l2 = 9223372036854775807;

            ulong ul1 = 18223372036854775808ul;
            ulong ul2 = 18223372036854775808UL;

            Console.WriteLine("\nLong:");
            Console.WriteLine("Min={0} , Max={1}", long.MinValue, long.MaxValue);
            Console.WriteLine("Min={0} , Max={1}", Int64.MinValue, Int64.MaxValue);

            Console.WriteLine("\nULong:");
            Console.WriteLine("Min={0} , Max={1}", ulong.MinValue, ulong.MaxValue);
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
        static void DefaultValues()
        {
            //get default value using default(type)
            int i = default(int); // 0
            float f = default(float);// 0
            decimal d = default(decimal);// 0
            bool b = default(bool);// false
            char c = default(char);// '\0'

            // C# 7.1 onwards
            //get default value using default
            int i2 = default; // 0
            float f2 = default;// 0
            decimal d2 = default;// 0
            bool b2 = default;// false
            char c2 = default;// '\0'

            Console.WriteLine("{0} , {1} , {2} , {3} , {4} , {5} , {6} , {7} , {8} , {9} ",
               i, f, d, b, c, i2, f2, d2, b2, c2);
            Console.ReadKey();
        }
        enum enWeekDays
        {
            Monday,     // 0
            Tuesday,    // 1
            Wednesday,  // 2
            Thursday,   // 3
            Friday,     // 4
            Saturday,   // 5
            Sunday      // 6
        }
        //if you set a value , it will auto number everything after it.
        enum enCategories
        {
            Electronics,    // 0
            Food,           // 1
            Automotive = 6, // 6
            Arts,           // 7
            BeautyCare,     // 8
            Fashion = 's'       // s
        }
        //Enum can have any numarical data type byte, sbyte, short, ushort, int, uint, long, or ulong
        //but not string
        enum enCategories2 : byte
        {
            Electronics = 1,
            Food = 5,
            Automotive = 6,
            Arts = 10,
            BeautyCare = 11,
            Fashion = 15
        }
        static void Enums()
        {
            enWeekDays WeekDays;
            WeekDays = enWeekDays.Friday;
            Console.WriteLine(WeekDays);

            enCategories Fashion;
            Fashion = enCategories.Fashion;
            Console.WriteLine(Fashion);

            enCategories2 Electronics2;
            Electronics2 = enCategories2.Electronics;
            Console.WriteLine(Electronics2);
            Console.ReadKey();
        }
        static void NullableEx()
        {
            //  Nullable<int> can be assigned any value
            //  from -2147483648 to 2147483647, or a null value.

            Nullable<int> i = null;
            int? i2 = null;
            Console.WriteLine("Nullable value is = \"" + i + "\"");
            Console.WriteLine("Nullable value is = \"" + i2 + "\"");
            Console.ReadKey();
        }
        static void AnonymousType()
        {
            //you dont specify any type here , automatically will be specified
            var student = new { Id = 30, FirstName = "AHMED", LastName = "MADY" };

            Console.WriteLine("\nExample1:\n");
            Console.WriteLine(student.Id); //output: 20
            Console.WriteLine(student.FirstName); //output: Mohammed
            Console.WriteLine(student.LastName); //output: Abu-Hadhoud

            //You can print like this:
            Console.WriteLine(student);


            //anonymous types are read-only
            //you cannot change the values of properties as they are read-only.

            // student.Id = 2;//Error: cannot chage value
            // student.FirstName = "Ali";//Error: cannot chage value


            //An anonymous type's property can include another anonymous type.
            var student2 = new
            {
                Id = 1,
                FirstName = "Ahmed",
                LastName = "Mady",
                Address = new
                {
                    Id = 1,
                    City = "Cairo",
                    Country = "Egypt",
                }
            };

            Console.WriteLine("\nExample2:\n");
            Console.WriteLine(student2.Id);
            Console.WriteLine(student2.FirstName);
            Console.WriteLine(student2.LastName);

            Console.WriteLine(student2.Address.Id);
            Console.WriteLine(student2.Address.City);
            Console.WriteLine(student2.Address.Country);
            Console.WriteLine(student2.Address);



            Console.ReadKey();
        }
        struct stStudent
        {
            public string FirstName;
            public string LastName;
            public byte Age;
        }
        static void @struct()
        { //A struct object can be created with or without the new operator,
            //same as primitive type variables.

            stStudent Student;
            stStudent Student2 = new stStudent();


            Student.FirstName = "Ahmed";
            Student.LastName = "MADY";
            Student.Age = 27;


            Console.WriteLine(Student.FirstName);
            Console.WriteLine(Student.LastName);
            Console.WriteLine(Student.Age);


            Student2.FirstName = "Ali";
            Student2.LastName = "Ahmed";
            Student2.Age = 28;

            Console.WriteLine(Student2.FirstName);
            Console.WriteLine(Student2.LastName);
            Console.WriteLine(Student2.Age);

            Console.ReadKey();
        }
        static void @DynamicType()
        {
            dynamic MyDynamicVar = 100;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = "Hello World!!";
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = true;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = DateTime.Now;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            Console.ReadKey();
        }
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
            //EscapeCharacters();
            //SingleLineMultipleLinesComments();
            //Vairables();
            //ImplicitlyTypedVariables();
            //NumbersDatatypes();
            //DefaultValues();
            //Enums();
            //NullableEx();
            //AnonymousType();
            //@struct();
            //@DynamicType();
            //////////////////////////////////////////////
            //MyDateTime.KDateTime();
            MyDateTime.CurrentDatetime();
        }
    }
}
