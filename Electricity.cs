using System;


namespace Assignment2
{
    internal class Electricity
    {
        public static void Main9()
        {
            int unit,a,b,c;
            Console.Write("Input the unit consumed by the customer : ");
            unit = Convert.ToInt32(Console.ReadLine());
            if(unit < 100)  
            {
              // a = unit * 0;
                Console.WriteLine("Bill is Free of Charge");
            }
            else if (unit >= 100 && unit < 200)
            {
                b = (unit - 100) * 5;
                Console.WriteLine("Bill is" + b);
            }
            if(unit >= 200)
            {
                a = (unit - 200);
                b = (unit - a);
                c = (b - 100);
                Console.WriteLine("Bill is" + (a*10+c*5));
            }

        }
    }
}
