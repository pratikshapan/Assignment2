using System;

namespace Assignment2
{
    internal class Divisibleby5
    {
        public static void Main7()
        {
            int num;
            Console.Write("Enter the Number: ");
            num = Convert.ToInt32(Console.ReadLine());
            if ((num % 5 == 0) && (num % 11 == 0))
            {
                Console.WriteLine("Number is divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine("Number is not divisible by 5 and 11");
            }
        }
    }
}
