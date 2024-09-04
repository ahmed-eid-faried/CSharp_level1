using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_level1
{
    internal class UserInput
    {
        public static void ReadLine()
        {
            // Type your username and press enter
            Console.WriteLine("Enter username?");

            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);

            Console.ReadKey();
        }
        public static void UserInputAndNumbers()
        {
            Console.WriteLine("Enter your age?");
            //if you dont convert you will get error, and if you enter string you will get error
            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
            Console.ReadKey();
        }
    }
}
