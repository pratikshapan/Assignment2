using System;
namespace Assignment2
{
    internal class Month
    {
        public static void Main11()
        {
            int month;
            Console.Write("Input the month : ");
            month = Convert.ToInt32(Console.ReadLine());
            if (month == 1)
                Console.WriteLine("January");
            else if (month == 2)
                Console.WriteLine("February");
            else if (month == 3)
                Console.WriteLine("March");
            else if (month == 4)
                Console.WriteLine("April");
            else if (month == 5)
                Console.WriteLine("May");
            else if (month == 6)
                Console.WriteLine("June");
            else if (month == 7)
                Console.WriteLine("July");
            else if (month == 8)
                Console.WriteLine("August");
            else if (month == 9)
                Console.WriteLine("Septeber");
            else if (month == 10)
                Console.WriteLine("October");
            else if (month == 11)
                Console.WriteLine("November");
            else if (month == 12)
                Console.WriteLine("December");
            else if (month > 12)
                Console.WriteLine("Sorry I need a number from 1-12.");
            else if (month <= 12)
                Console.WriteLine("The month is " + month);
        }
    }
}
