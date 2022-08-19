using System;

namespace Assignment2
{
    internal class meter
    {
       public static void Main2()
        {
            double meter, feet;
            Console.WriteLine("Enter feet :");
            feet = Convert.ToInt32(Console.ReadLine());
            meter = feet / 3.2808399;
            Console.WriteLine("\nFeet in meter : " + meter);
            Console.ReadKey();
        }
    
    }
}
