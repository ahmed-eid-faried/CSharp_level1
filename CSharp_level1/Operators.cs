using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_level1
{
    internal class Operators
    {
        public static void AssignmentOperators()
        {
            Console.WriteLine("================================");
            int x = 10;
            Console.WriteLine("x = " + x);
            Console.WriteLine("================================");
            Console.WriteLine("x += 5 ===>> x + 5 ===>> " + (x += 5));
            Console.WriteLine("x -= 5 ===>> x - 5 ===>> " + (x -= 5));
            Console.WriteLine("x *= 5 ===>> x * 5 ===>> " + (x *= 5));
            Console.WriteLine("x /= 5 ===>> x / 5 ===>> " + (x /= 5));
            Console.WriteLine("x %= 5 ===>> x % 5 ===>> " + (x %= 5));
            Console.WriteLine("================================");
            x = 10;
            Console.WriteLine("x = " + x);
            Console.WriteLine("============Bitwise=============");
            Console.WriteLine("x &= 5 ===>> x & 5 ===>> " + (x &= 5));
            Console.WriteLine("x |= 5 ===>> x | 5 ===>> " + (x |= 5));
            Console.WriteLine("x ^= 5 ===>> x ^ 5 ===>> " + (x ^= 5));
            Console.WriteLine("================================");
            x = 10;
            Console.WriteLine("x = " + x);
            Console.WriteLine("============Bitwise=============");
            Console.WriteLine("x <<= 5 ===>> x << 5 ===>> " + (x <<= 5));
            Console.WriteLine("x >>= 5 ===>> x >> 5 ===>> " + (x >>= 5));
            //Console.WriteLine("x => x*x ===>> Return x*x ===>> " + (x => x*x));
            Console.WriteLine("================================");

            Console.ReadLine();
        }
        public static void ArithmeticOperators()
        {

            int x = 51;
            int y = 10;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("======================");
            Console.WriteLine("x + y = " + (x + y));
            Console.WriteLine("x - y = " + (x - y));
            Console.WriteLine("x * y = " + (x * y));
            Console.WriteLine("x / y = " + (x / y));
            Console.WriteLine("x % y = " + (x % y));

            Console.ReadLine();
        }
        public static void RelationalOperators()
        {

            int x = 20;
            int y = 10;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("======================");
            Console.WriteLine("x == y = " + (x == y));
            Console.WriteLine("x != y = " + (x != y));
            Console.WriteLine("x > y = " + (x > y));
            Console.WriteLine("x >= y = " + (x >= y));
            Console.WriteLine("x < y = " + (x < y));
            Console.WriteLine("x <= y = " + (x <= y));

            Console.ReadLine();
        }

        public static void LogicalOperators()
        {
            Console.WriteLine("Op1 " + "  " + " Op2" + "   => " + ("And(&&)") + " " + (" OR(||) "));
            Console.WriteLine("=====================================================");
            bool x = true, y = true;
            Console.WriteLine(x.ToString().PadRight(5) + "  " + y.ToString().PadRight(5) + " => " + (x && y).ToString().PadRight(5) + "     " + (x || y).ToString().PadRight(5));
            Console.WriteLine("=====================================================");
            x = true; y = false;
            Console.WriteLine(x.ToString().PadRight(5) + "  " + y.ToString().PadRight(5) + " => " + (x && y).ToString().PadRight(5) + "     " + (x || y).ToString().PadRight(5));
            Console.WriteLine("=====================================================");
            x = false; y = true;
            Console.WriteLine(x.ToString().PadRight(5) + "  " + y.ToString().PadRight(5) + " => " + (x && y).ToString().PadRight(5) + "     " + (x || y).ToString().PadRight(5));
            Console.WriteLine("=====================================================");
            x = false; y = false;
            Console.WriteLine(x.ToString().PadRight(5) + "  " + y.ToString().PadRight(5) + " => " + (x && y).ToString().PadRight(5) + "     " + (x || y).ToString().PadRight(5));
            Console.WriteLine("=====================================================");
            Console.ReadLine();
        }
        public static void UnaryOperators()
        {
            int number = 10, result;
            bool flag = true;

            result = +number;
            Console.WriteLine("+number = " + result);

            result = -number;
            Console.WriteLine("-number = " + result);
            Console.WriteLine(("====================================="));
            result = ++number;
            Console.WriteLine("++number = " + result);

            result = --number;
            Console.WriteLine("--number = " + result);
            Console.WriteLine(("====================================="));
            Console.WriteLine("!flag = " + (!flag));
            Console.WriteLine(("====================================="));
            Console.WriteLine((number++));
            Console.WriteLine((number));

            Console.WriteLine((++number));
            Console.WriteLine((number));

            Console.WriteLine(("====================================="));
            Console.WriteLine((number--));
            Console.WriteLine((number));

            Console.WriteLine((--number));
            Console.WriteLine((number));

            Console.ReadKey();
        }
        public static void TernaryOperator()
        {
            int number = 12;
            string result;

            result = (number % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine("{0} is {1}", number, result);

            Console.ReadKey();
        }
        public static void BitwiseAndBitShiftOperators()
        {
            int x = 10;
            Console.WriteLine("x = " + x);
            Console.WriteLine("============Bitwise=============");
            // 1  &  1  ===>> 1
            // 1  &  0  ===>> 0
            // 0  &  1  ===>> 0
            // 0  &  0  ===>> 0
            Console.WriteLine("x & 5 ===>>  " + (x & 5));
            // 1  |  1  ===>> 1
            // 1  |  0  ===>> 1
            // 0  |  1  ===>> 1
            // 0  |  0  ===>> 0
            Console.WriteLine("x | 5 ===>>  " + (x | 5));
            // 1  ^  1  ===>> 0  //false==>  زى بعض
            // 1  ^  0  ===>> 1  //true ==>  مختلفين
            // 0  ^  1  ===>> 1  //true ==>  مختلفين
            // 0  ^  0  ===>> 0  //false==>  زى بعض
            Console.WriteLine("x ^ 5 ===>>  " + (x ^ 5));
            Console.WriteLine("================================");
            // 0  ===>> 1   // بيعكس الكل 
            // 1  ===>> 0   // بيعكس الكل 
            Console.WriteLine("  x ===>>  " + (x) + "  \n===>> " + ($"({Convert.ToString(x, 2).PadLeft(8, '0')} in binary)"));
            Console.WriteLine(" ~x ===>>  " + (~x) + "  \n===>> " + ($"({Convert.ToString(~x, 2).PadLeft(8, '0')} in binary)"));
            Console.WriteLine("================================");
            x = 10;
            Console.WriteLine("x = " + x);
            Console.WriteLine("==============Shift=============");
            Console.WriteLine("x << 5 ===>>  " + (x << 5));
            Console.WriteLine("x >> 5 ===>>  " + (x >> 5));
            Console.WriteLine("================================");

            Console.ReadLine();
        }
        public static void ExplainBitwiseXOR()
        {
            // Header for the table
            Console.WriteLine("Bit 1  Bit 2  Result (XOR)");
            Console.WriteLine("===========================");

            // Example 1: 0 XOR 0
            int bit1 = 0;
            int bit2 = 0;
            int result = bit1 ^ bit2;  // XOR operation
            Console.WriteLine($"{bit1}      {bit2}      {result}");

            // Example 2: 0 XOR 1
            bit1 = 0;
            bit2 = 1;
            result = bit1 ^ bit2;  // XOR operation
            Console.WriteLine($"{bit1}      {bit2}      {result}");

            // Example 3: 1 XOR 0
            bit1 = 1;
            bit2 = 0;
            result = bit1 ^ bit2;  // XOR operation
            Console.WriteLine($"{bit1}      {bit2}      {result}");

            // Example 4: 1 XOR 1
            bit1 = 1;
            bit2 = 1;
            result = bit1 ^ bit2;  // XOR operation
            Console.WriteLine($"{bit1}      {bit2}      {result}");

            // Additional example to show XOR in action with larger numbers
            int a = 5;  // 0101 in binary
            int b = 3;  // 0011 in binary
            int xorResult = a ^ b;  // 0110 in binary, which equals 6
            Console.WriteLine("\nExample with larger numbers:");
            Console.WriteLine($"a = {a} (0101 in binary)");
            Console.WriteLine($"b = {b} (0011 in binary)");
            Console.WriteLine($"a ^ b = {xorResult} (0110 in binary, which equals 6)");

            Console.ReadLine();
        }
        //public static void BitwiseComplement2()
        //{
        //    int number = 5;
        //    int result = ~number;
        //    Console.WriteLine("\nExample with 8-bit system using Two's Complement notation:");
        //    Console.WriteLine($"a = {number}  (0000 0101 in binary)");
        //    Console.WriteLine($"b = {~number} (1111 1010 in binary)");

        //    Console.WriteLine("Original number: " + number);   // Outputs: 5
        //    Console.WriteLine("Bitwise Complement: " + result); // Outputs: -6

        //    // Display binary representation
        //    Console.WriteLine("Binary of original number: " + Convert.ToString(number, 2).PadLeft(8, '0'));
        //    Console.WriteLine("Binary of complement: " + Convert.ToString(result, 2).PadLeft(8, '0'));

        //    Console.ReadLine();
        //}

        public static void BitwiseComplement()
        {
            int number = 5;
            int result = ~number;

            Console.WriteLine("\nExample with 32-bit system using Two's Complement notation:");
            Console.WriteLine($"a = {number}  ({Convert.ToString(number, 2).PadLeft(8, '0')} in binary)");
            Console.WriteLine($"b = {result} ({Convert.ToString(result, 2).PadLeft(32, '0')} in binary)");

            Console.WriteLine("Original number: " + number);   // Outputs: 5
            Console.WriteLine("Bitwise Complement: " + result); // Outputs: -6

            // Display binary representation
            Console.WriteLine("Binary of original number: " + Convert.ToString(number, 2).PadLeft(8, '0'));
            Console.WriteLine("Binary of complement: " + Convert.ToString(result, 2).PadLeft(32, '0'));

            Console.ReadLine();
        }
        public static void ShiftOperations()
        {
            int a = 5; // Binary: 0000 0101
            int b = a << 2; // Shift left by 2 positions
            int c = 20; // Binary: 0001 0100
            int d = c >> 2; // Shift right by 2 positions

            Console.WriteLine("Original number (a): " + a); // Outputs: 5
            Console.WriteLine("After left shift by 2 (a << 2): " + b); // Outputs: 20
            Console.WriteLine("Binary of a << 2: " + Convert.ToString(b, 2).PadLeft(8, '0')); // Binary: 00010100

            Console.WriteLine("Original number (c): " + c); // Outputs: 20
            Console.WriteLine("After right shift by 2 (c >> 2): " + d); // Outputs: 5
            Console.WriteLine("Binary of c >> 2: " + Convert.ToString(d, 2).PadLeft(8, '0')); // Binary: 00000101

            Console.ReadLine();
        }

    }

}
