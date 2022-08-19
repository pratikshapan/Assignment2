using System;


namespace Assignment2
{
    internal class HelloBye
    {
        public static void Main8()
        {
            int num;
            Console.Write("Enter the Number: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 5 == 0)

            {

                Console.WriteLine("Hello");

            }

            else

            {

                Console.WriteLine("Bye");
            }
        }
    }
}
