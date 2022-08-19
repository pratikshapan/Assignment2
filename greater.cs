using System;


namespace Assignment2
{
     class greater
    {
        public static void Main()
        {
            int num1, num2, num3;
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
                if (num1 > num3)
                    Console.WriteLine("Num1 is greater");
                else
                    if (num3 > num2)
                    Console.WriteLine("Num3 is greater");
                else
                    Console.WriteLine("Num2 is greater");
            else
                Console.WriteLine("Num2 is greater");
        }
    }
}
  