using System;

namespace Date_Time
{
    class Program
    {
        void ShowTime()
        {
            DateTime currentDate = DateTime.Now;
            bool leapYear = DateTime.IsLeapYear(2020);

            Console.WriteLine(currentDate);
            Console.Write("2020 is a leapYear: ");
            Console.WriteLine(leapYear);
        }
        static void Main(string[] args)
        {
            Program myProgam = new Program();

            myProgam.ShowTime();
        }
    }
}
