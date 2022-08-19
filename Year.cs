using System;

namespace Assignment2
{
    internal class Year
    {
        public static void Main5()
        {
            int days, years, weeks;
            Console.WriteLine("Enter days:");
            days = Convert.ToInt32(Console.ReadLine());
            years = (days / 365);
            weeks = (days % 365) / 7;
            days = days - ((years * 365) + (weeks * 7));
            Console.WriteLine("Years : " + years);
            Console.WriteLine("weeks : " + weeks);
            Console.WriteLine("Days : " + days);

            Console.ReadKey();
        }
    }
}
