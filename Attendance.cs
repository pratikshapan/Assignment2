using System;


namespace Assignment2
{
    internal class Attendance
    {
		public static void Main12()
		{
			double a, b, p;
			Console.WriteLine("Total number of Working Days ");
			a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Total number of days for absent");
			b = Convert.ToInt32(Console.ReadLine());

			p = a / b * 100;

			if (p <= 75)
			{
				Console.WriteLine("Student will not able to Sit in Exam" + p);
			}
			else
			{
				Console.WriteLine("student is allowed to sit in exam");
				Console.WriteLine();
			}

		}
	}
}
