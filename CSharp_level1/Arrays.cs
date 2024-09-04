﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_level1
{
    internal class Arrays
    {
        public static void ArraysAreBound()
        {
            int[] ints = { 1, 2, 3 };
            ints[0] = 1;
            ints[1] = 2;
            ints[2] = 3;
            //ints[3] = 4;  //Index was outside the bounds of the array.
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write(ints[i] + " ");
            }
            Console.ReadLine();
        }
        public static void ArrayDeclaration()
        {
            // declare an array
            int[] age;
            // allocate memory for array
            age = new int[30];
            Random rnd = new Random();
            for (int i = 0; i < age.Length; i++)
            {
                age[i] = rnd.Next(0, 113);// returns random integers >= 0 and < 113
            }

            for (int i = 0; i < age.Length; i++)
            {
                Console.Write(age[i] + " ");
            }

            Console.WriteLine("\n");
            int[] numbers = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine("\n");
            // declare an array
            int[] ints = new int[5];
            //initializing array
            ints[0] = 0;
            ints[1] = 5;
            ints[2] = 55;
            ints[3] = 555;
            ints[4] = 5555;
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write(ints[i] + " ");
            }

            Console.ReadLine();
        }
        public static void AccessArrayElements()
        {
            // create an array
            int[] numbers = { 1, 2, 3 };

            //access first element
            Console.WriteLine("Element in first index : " + numbers[0]);

            //access second element
            Console.WriteLine("Element in second index : " + numbers[1]);

            //access third element
            Console.WriteLine("Element in third index : " + numbers[2]);


            //through loop
            Console.WriteLine("\nAccess array using loop:\n");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Element in index {0} : {1} ", i, numbers[0]);
            }

            Console.ReadKey();
        }
        public static void TwoDimensionalArray()
        {
            //initializing 2D array
            int[,] numbers = { { 12, 13 }, { 55, 77 } };

            // access first element from the first row
            Console.WriteLine("Element at index [0, 0] : " + numbers[0, 0]);

            // access second element from first row
            Console.WriteLine("Element at index [0, 1] : " + numbers[0, 1]);

            // access first element from second row
            Console.WriteLine("Element at index [1, 0] : " + numbers[1, 0]);

            // access second element from second row
            Console.WriteLine("Element at index [1, 1] : " + numbers[1, 1]);

            Console.ReadKey();
        }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
    }
}
