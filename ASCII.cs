﻿using System;

namespace Assignment2
{
    internal class ASCII
    {
        public static void Main3()
        {
            char c;
            Console.WriteLine("Enter a character: ");
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\nASCII Value of " + c + " " + Convert.ToInt32(c));
           // Console.ReadKey();
        }
    }
}
