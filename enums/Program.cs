using System;

namespace enums
{
    class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek today = DayOfWeek.Friday;
            int todayAsInt = (int)today;

            Console.WriteLine(todayAsInt);
            Console.WriteLine(today);
        }
    }
}
