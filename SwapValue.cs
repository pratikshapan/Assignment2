using System;
namespace Assignment2
{
    class SwapValue
    {
        public static void Main()
        {
            int number1, number2, swap;
            Console.Write("\nInput the First Number : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            swap = number1;
            number1 = number2;
            number2 = swap;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + number1);
            Console.Write("\nSecond Number : " + number2);
            Console.Read();
        }
    }
}