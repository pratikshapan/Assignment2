﻿using System;

namespace Assignment2
{
    internal class Prime
    {
        public static void Main6()
        {
            int num;
            Console.WriteLine("Enter the num");
            num = Convert.ToInt32(Console.ReadLine());


            if (num == 2)
            {
                Console.WriteLine("number is a prime");
            }
            else if (num % 2 == 0 || num % 3 == 0 || num % 5 == 0 || num % 7 == 0)
            {
                Console.WriteLine("number is not a prime");
                 
            }
            else
            {
                Console.WriteLine("number is a prime");
            }
        }
    }
}
