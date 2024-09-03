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
            DateTime unixEpoch = DateTimeConverter.unixEpochGregorian;

            // Convert DateTime to various units
            long ticks = DateTimeConverter.ConvertToTicks(dt, unixEpoch);
            long seconds = DateTimeConverter.ConvertToSeconds(dt, unixEpoch);
            double minutes = DateTimeConverter.ConvertToMinutes(dt, unixEpoch);
            double hours = DateTimeConverter.ConvertToHours(dt, unixEpoch);
            double days = DateTimeConverter.ConvertToDays(dt, unixEpoch);
            double weeks = DateTimeConverter.ConvertToWeeks(dt, unixEpoch);
            double months = DateTimeConverter.ConvertToMonths(dt, unixEpoch);
            double years = DateTimeConverter.ConvertToYears(dt, unixEpoch);

            Console.WriteLine("tick ===>>  100-nanosecond \nthere are 10 million ticks in one second \nsince January 1, 0001, at 00:00:00.000 in the Gregorian calendar. \n\n");
            Console.WriteLine("ticks ===>> " + ticks);
            Console.WriteLine("Second ===>> " + seconds);
            Console.WriteLine("Minute ===>> " + minutes);
            Console.WriteLine("Hour ===>> " + hours);
            Console.WriteLine("Day ===>> " + days);
            Console.WriteLine("Month ===>> " + months);
            Console.WriteLine("Year ===>> " + years);
            Console.WriteLine("==============================================================================");
            Console.ReadKey();
        }
        public static void DateTimeStaticFields()
        {
            DateTime currentDateTime = DateTime.Now;  //returns current date and time
            DateTime todaysDate = DateTime.Today; // returns today's date
            DateTime currentDateTimeUTC = DateTime.UtcNow;// returns current UTC date and time الوقت الحالى بتوقيت جرينتش
            DateTime maxDateTimeValue = DateTime.MaxValue; // returns max value of DateTime
            DateTime minDateTimeValue = DateTime.MinValue; // returns min value of DateTime

            Console.WriteLine("currentDateTime: " + currentDateTime);
            Console.WriteLine("Today: " + todaysDate);
            Console.WriteLine("currentDateTimeUTC: " + currentDateTimeUTC);
            Console.WriteLine("minDateTimeValue: " + minDateTimeValue);
            Console.WriteLine("maxDateTimeValue: " + maxDateTimeValue);

            Console.ReadKey();
        }
        public static void @TimeSpan()
        {
            DateTime dt = new DateTime(2024, 9, 3);
            // Hours, Minutes, Seconds
            TimeSpan ts = new TimeSpan(38, 13, 33);
            Console.WriteLine("======================================");
            Console.WriteLine(dt);
            Console.WriteLine(dt.Year);
            Console.WriteLine(dt.Month);
            Console.WriteLine(dt.Day);
            Console.WriteLine(dt.DayOfWeek);
            Console.WriteLine("======================================");
            Console.WriteLine(ts);
            Console.WriteLine(ts.Days);
            Console.WriteLine(ts.Hours);
            Console.WriteLine(ts.Minutes);
            Console.WriteLine(ts.Seconds);
            Console.WriteLine("======================================");
            //this will add time span to the date.
            DateTime newDate = dt.Add(ts);
            Console.WriteLine(newDate);
            Console.WriteLine("======================================");

            Console.ReadKey();
        }
        public static void SubtractionOfTwoDatesResultsInTimeSpan()
        {
            DateTime dt1 = new DateTime().AddDays(2);
            DateTime dt2 = DateTime.Now;
            TimeSpan result = dt2.Subtract(dt1);
            DateTime result2 = new DateTime().Add(dt2.Subtract(dt1));

            Console.WriteLine(result);
            Console.WriteLine(result2);

            Console.ReadKey();
        }
        public static void OperatorsDateTime()
        {
            DateTime dt1 = new DateTime(2015, 12, 20);
            DateTime dt2 = new DateTime(2016, 12, 31, 5, 10, 20);
            TimeSpan time = new TimeSpan(10, 5, 25, 50);
            //DateTime + TimeSpan
            Console.WriteLine(dt2 + time); // 1/10/2017 10:36:10 AM
            Console.WriteLine(dt2 - time); // 20/12/2016 11:44:30
            Console.WriteLine(dt2 - dt1); //377.05:10:20
            Console.WriteLine(dt1 == dt2); //False
            Console.WriteLine(dt1 != dt2); //True
            Console.WriteLine(dt1 > dt2); //False
            Console.WriteLine(dt1 < dt2); //True
            Console.WriteLine(dt1 >= dt2); //False
            Console.WriteLine(dt1 <= dt2);//True

            Console.ReadKey();
        }
        //public static void Test() { Console.ReadLine(); }

    }

    internal class DateTimeConverter
    {
        // Specify the Unix epoch
        public static DateTime unixEpoch1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        public static DateTime Now = DateTime.Now.ToUniversalTime();
        public static DateTime unixEpochGregorian = new DateTime().ToUniversalTime();

        // Convert DateTime to total seconds since a specified epoch
        public static long ConvertToSeconds(DateTime dateTime, DateTime epoch)
        {
            return (long)(dateTime.ToUniversalTime() - epoch).TotalSeconds;
        }

        // Convert DateTime to total ticks since a specified epoch
        public static long ConvertToTicks(DateTime dateTime, DateTime epoch)
        {
            return (dateTime.ToUniversalTime() - epoch).Ticks;
        }

        // Convert DateTime to total days since a specified epoch
        public static double ConvertToDays(DateTime dateTime, DateTime epoch)
        {
            return (dateTime.ToUniversalTime() - epoch).TotalDays;
        }

        // Convert DateTime to total years since a specified epoch
        public static double ConvertToYears(DateTime dateTime, DateTime epoch)
        {
            return (dateTime.ToUniversalTime() - epoch).TotalDays / 365.25; // Accounts for leap years
        }

        // Convert DateTime to total weeks since a specified epoch
        public static double ConvertToWeeks(DateTime dateTime, DateTime epoch)
        {
            return (dateTime.ToUniversalTime() - epoch).TotalDays / 7;
        }

        // Convert DateTime to total minutes since a specified epoch
        public static double ConvertToMinutes(DateTime dateTime, DateTime epoch)
        {
            return (dateTime.ToUniversalTime() - epoch).TotalMinutes;
        }

        // Convert DateTime to total hours since a specified epoch
        public static double ConvertToHours(DateTime dateTime, DateTime epoch)
        {
            return (dateTime.ToUniversalTime() - epoch).TotalHours;
        }

        // Convert DateTime to total months since a specified epoch
        public static int ConvertToMonths(DateTime dateTime, DateTime epoch)
        {
            int years = dateTime.Year - epoch.Year;
            int months = dateTime.Month - epoch.Month;

            // Total months calculation
            return years * 12 + months;
        }
    }
}
