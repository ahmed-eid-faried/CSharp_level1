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
            Console.WriteLine("tick ===>>  100-nanosecond");
            Console.WriteLine("ticks ===>> " + dt.Ticks);
            Console.WriteLine("Second ===>> " + dt.Second);
            Console.WriteLine("Minute ===>> " + dt.Minute);
            Console.WriteLine("Hour ===>> " + dt.Hour);
            Console.WriteLine("Day ===>> " + dt.Day);
            Console.WriteLine("Month ===>> " + dt.Month);
            Console.WriteLine("Year ===>> " + dt.Year);
            Console.WriteLine("==============================================================================");
            Console.ReadKey();
        }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }
        //public static void Test() { Console.ReadLine(); }

    }

    internal class DateTimeConverter
    {
        public DateTime unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        // Convert DateTime to total seconds since Unix epoch
        public static long ConvertToSeconds(DateTime dateTime)
        {
            return (long)(dateTime.ToUniversalTime() - unixEpoch).TotalSeconds;
        }

        // Convert DateTime to total ticks since Unix epoch
        public static long ConvertToTicks(DateTime dateTime)
        {
            return (dateTime.ToUniversalTime() - unixEpoch).Ticks;
        }

        // Convert DateTime to total days since Unix epoch
        public static double ConvertToDays(DateTime dateTime)
        {
            return (dateTime.ToUniversalTime() - unixEpoch).TotalDays;
        }

        // Convert DateTime to total years since Unix epoch
        public static double ConvertToYears(DateTime dateTime)
        {
            return (dateTime.ToUniversalTime() - unixEpoch).TotalDays / 365.25; // Accounts for leap years
        }

        // Convert DateTime to total weeks since Unix epoch
        public static double ConvertToWeeks(DateTime dateTime)
        {
            return (dateTime.ToUniversalTime() - unixEpoch).TotalDays / 7;
        }

        // Convert DateTime to total minutes since Unix epoch
        public static double ConvertToMinutes(DateTime dateTime)
        {
            return (dateTime.ToUniversalTime() - unixEpoch).TotalMinutes;
        }

        // Convert DateTime to total hours since Unix epoch
        public static double ConvertToHours(DateTime dateTime)
        {
            return (dateTime.ToUniversalTime() - unixEpoch).TotalHours;
        }
    }
}
