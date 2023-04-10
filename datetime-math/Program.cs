using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datetimeValue;

            datetimeValue = DateTime.Now;

            Console.WriteLine("The current date and time is {0}", datetimeValue);

            Console.WriteLine("The current date is {0}", datetimeValue.Date);

            Console.WriteLine("The current time is {0}", datetimeValue.TimeOfDay);

            Console.WriteLine("The current day of the week is {0}", datetimeValue.DayOfWeek);

            Console.WriteLine("The current year is {0}", datetimeValue.Year);

            Console.WriteLine("Add 3 days to the current date: {0}", datetimeValue.AddDays(3));

            Console.WriteLine("Add 3 months to the current date: {0}", datetimeValue.AddMonths(3));

            Console.WriteLine("Add 3 years to the current date: {0}", datetimeValue.AddYears(3));

            Console.WriteLine("Add 3 hours to the current time: {0}", datetimeValue.AddHours(3));


            //datetime Formats

            //days
            
            Console.WriteLine("The Current day of the week is {0}", datetimeValue.ToString("d"));

            Console.WriteLine("The Current day of the week is {0}", datetimeValue.ToString("dd"));

            Console.WriteLine("The Current day of the week is {0}", datetimeValue.ToString("ddd"));

            Console.WriteLine("The Current day of the week is {0}", datetimeValue.ToString("dddd"));


            //months

            Console.WriteLine("The Current month is {0}", datetimeValue.ToString("M")); // 04/01/2020

            Console.WriteLine("The Current month is {0}", datetimeValue.ToString("MM")); //04

            Console.WriteLine("The Current month is {0}", datetimeValue.ToString("MMM")); //Apr

            Console.WriteLine("The Current month is {0}", datetimeValue.ToString("MMMM")); //April



            // math operations

            Console.WriteLine("Sin 90: "+Math.Sin(90));

            Console.WriteLine("Cos 90: "+Math.Cos(90));

            Console.WriteLine("Tan 90: "+Math.Tan(90));

            Console.WriteLine("Sqrt 90: "+Math.Sqrt(90));

            Console.WriteLine("Abs -90: "+Math.Abs(-90));


        }
    }
}