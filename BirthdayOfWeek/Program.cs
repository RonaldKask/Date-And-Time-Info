using System;

namespace BirthdayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What year were you born?");
            int usersYear = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What number month were you born?");
            int usersMonth = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What number day were you born?");
            int usersDay = Int32.Parse(Console.ReadLine());

            DateTime birthDate = new DateTime(usersYear, usersMonth, usersDay);
            var dayOfTheWeek = birthDate.DayOfWeek;
            Console.WriteLine($"You were born on {dayOfTheWeek}");
        }
    }
}
