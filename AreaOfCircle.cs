using System;


namespace Assignment2
{
    internal class AreaOfCircle
    {
        public static void Main4()
        {
            Console.Write("Enter Radius: ");
            double Radious = Convert.ToDouble(Console.ReadLine());
            double Area = Math.PI * Radious * Radious;
            Console.WriteLine("Area of circle: " + Area);
            Console.ReadKey();
        }
    }
}
