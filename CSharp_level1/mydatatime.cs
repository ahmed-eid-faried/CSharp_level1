using System;

namespace CSharp_level1
{
    internal class MyDateTime
    {

        public static void KDateTime()
        {

            //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime();

            //assigns year, month, day
            DateTime dt2 = new DateTime(2024, 9, 3);

            //assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2024, 9, 3, 12, 48, 30);

            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2024, 9, 3, 12, 48, 30, DateTimeKind.Utc);

            //assigns current date time
            DateTime dt5 = DateTime.Now;

            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);
            Console.WriteLine(dt4);
            Console.WriteLine(dt5);

            Console.ReadKey();
        }
        public static void CurrentDatetime()
        {
            //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime();

            dt1 = DateTime.Now;
            Console.WriteLine(dt1);

            DateTime dt2 = DateTime.Now;
            Console.WriteLine(dt2);

            Console.WriteLine(DateTime.Now);

            Console.ReadKey();
        }

        public static void TicksAndLimits()
        {
            //number of 100-nanosecond intervals that have elapsed
            //since January 1, 0001, at 00:00:00.000 in the Gregorian calendar. 

            Console.WriteLine("==============================================================================");
            Console.Write("MinValue ===>> " + DateTime.MinValue + "  ===>> ");  //min value 
            Console.WriteLine(DateTime.MinValue.Ticks);  //min value of ticks
            Console.WriteLine("==============================================================================");
            Console.Write("MaxValue ===>> " + DateTime.MaxValue + "  ===>> "); // max value 
            Console.WriteLine(DateTime.MaxValue.Ticks); // max value of ticks
            Console.WriteLine("==============================================================================");
            DateTime dt = DateTime.Now;
            Console.Write("tick ===>>  100-nanosecond");
            Console.Write("ticks ===>> " + dt.Ticks);
            Console.Write("Second ===>> " + dt.Second);
            Console.Write("Minute ===>> " + dt.Minute);
            Console.Write("Hour ===>> " + dt.Hour);
            Console.Write("Day ===>> " + dt.Day);
            Console.Write("Month ===>> " + dt.Month);
            Console.Write("Year ===>> " + dt.Year);
            Console.WriteLine("==============================================================================");
            Console.ReadKey();
        }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }

    }
}
