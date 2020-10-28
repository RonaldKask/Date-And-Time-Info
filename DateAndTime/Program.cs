using System;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            Console.WriteLine($"Today: {today}");
            int yearToday = today.Year;
            Console.WriteLine($"Current year from today {yearToday}");
            var weekDayToday = today.DayOfWeek;
            Console.WriteLine($"It's currently {weekDayToday}");
            Console.WriteLine("-------------------------");

            DateTime todayDetails = DateTime.Now;
            Console.WriteLine($"Today in details: {todayDetails}");
            DateTime utc = DateTime.UtcNow;
            Console.WriteLine($"The universal central time is {utc}");

            //DateTime(year, month, day, hour, minute)

            DateTime christmasEve = new DateTime(2020, 12, 24);
            var christmasDayOfWeek = christmasEve.DayOfWeek;
            Console.WriteLine($"Christmas eve is on {christmasDayOfWeek}");
        }
    }
}
