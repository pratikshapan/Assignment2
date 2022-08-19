using System;


namespace Assignment2
{
    internal class Grade
    {
        public static void Main10()
        {
            int percentage;
            Console.Write("Input the Percentage : ");
            percentage = Convert.ToInt32(Console.ReadLine());
            if (percentage > 90)
            {
                Console.WriteLine("Grade A");
            }
            else if (percentage > 80 && percentage <= 90)
            {
                Console.WriteLine("Grade B");
            }
            else if (percentage >= 60 && percentage <= 80)
            {
                Console.WriteLine("Grade C ");
            }
            else if(percentage < 60)
            {
                Console.WriteLine("Grade D");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
