using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_level1
{
    internal class ControlFlow
    {
        public static void IfElseIfAndNestedIfStatement()
        {
            int x = 10; int y = 20;

            //if then statement
            if (x == 10 && y <= 20)
            {
                Console.WriteLine("yes x = 10 and y<=20");
            }



            //if then else statement
            if (x == 11)
            {
                Console.WriteLine("yes x = 11 ");
            }
            else
            {
                Console.WriteLine("yes x != 11 ");
            }


            //if else if statement
            int number = 12;
            if (number < 5)
            {
                Console.WriteLine("{0} is less than 5", number);
            }
            else if (number > 5)
            {
                Console.WriteLine("{0} is greater than 5", number);
            }
            else
            {
                Console.WriteLine("{0} is equal to 5");
            }


            Console.ReadKey();
        }
        public static void SwitchStatement()
        {
            //switch statement with grouped cases
            char ch;
            Console.WriteLine("Enter a letter");
            ch = Convert.ToChar(Console.ReadLine());
            switch (Char.ToLower(ch))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Not a vowel");
                    break;
            }
            Console.WriteLine("===============================================");
            char ch2;
            Console.WriteLine("Enter a letter?");
            ch2 = Convert.ToChar(Console.ReadLine());

            switch (Char.ToLower(ch2))
            {
                case 'a':
                    Console.WriteLine("Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Not a vowel");
                    break;
            }


            Console.ReadKey();
        }
        public static void SimpleCalculator()
        {
            //Simple Calculator

            char op;
            double first, second, result;

            Console.Write("Enter first number: ");
            first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            second = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operator (+, -, *, /): ");
            op = (char)Console.Read();
            switch (op)
            {
                case '+':
                    result = first + second;
                    Console.WriteLine("{0} + {1} = {2}", first, second, result);
                    break;

                case '-':
                    result = first - second;
                    Console.WriteLine("{0} - {1} = {2}", first, second, result);
                    break;

                case '*':
                    result = first * second;
                    Console.WriteLine("{0} * {1} = {2}", first, second, result);
                    break;

                case '/':
                    result = first / second;
                    Console.WriteLine("{0} / {1} = {2}", first, second, result);
                    break;

                default:
                    Console.WriteLine("Invalid Operator");
                    break;

            }

            Console.ReadKey();
        }
        public static void StringCompare()
        {
            Console.Write("Name1: ");
            string Name1 = Console.ReadLine().ToLower();
            Console.Write("\nName2: ");
            string Name2 = Console.ReadLine().ToLower();

            switch (Name1 == Name2)
            {
                case true:
                    Console.WriteLine("Yes Name Matched!");
                    break;
                default:
                    Console.WriteLine("No Name Matched!");
                    break;

            }

            Console.ReadKey();
        }
        public static void TernaryOperator()
        {
            double number; bool isEven;
            Console.Write("Number: ");
            number = Convert.ToDouble(Console.ReadLine());
            isEven = (number % 2 == 0) ? true : false;
            Console.WriteLine("\nisEven  ===>> " + isEven);

            Console.ReadLine();
        }
        public static void ForLoop()
        {
            Console.WriteLine("\nForward Loop:");
            //forward loop
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nBackword Loop:");
            //backword loop
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nNested Loops:");
            //forward loop
            for (int i = 1; i <= 10; i++)

            {
                for (int j = 0; j < 10; j++)

                {

                    Console.WriteLine("i={0} and j={1}", i, j);

                }

            }
            Console.ReadKey();
        }
        public static void WhileLoop()
        {
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("C# while Loop: Iteration {0}", i);
                i++;
            }

            Console.ReadKey();
        }
        public static void DoWhileLoop()
        {
            int i = 1;
            do
            {
                Console.WriteLine("C# while Loop: Iteration {0}", i);
                i++;

            } while (i <= 5);

            Console.ReadKey();
        }
        public static void BreakStatement()
        {
            int i = 1;
            do
            {
                Console.WriteLine("C# while Loop: Iteration {0}", i);
                if (i == 3) break;
                i++;
            } while (i <= 5);

            Console.ReadKey();
        }
        public static void ContinueStatement()
        {
            int i = 0;
            do
            {
                i++;
                if (i == 3) continue;
                Console.WriteLine("C# while Loop: Iteration {0}", i);
            } while (i < 5);

            Console.ReadKey();
        }

    }

}
