using System;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current month is: " + DateTime.Now.Month);
            Console.WriteLine("There are " + DateTime.DaysInMonth(2020, 05) + " days this month");
        }
    }
}
