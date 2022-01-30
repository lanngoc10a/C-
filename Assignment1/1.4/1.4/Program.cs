using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			string initials = "LNN";
			int population = 95000000;
            long people = 7779000000L;
            string day = "Sunday";
			short weeks = 14;
			double pi = 3.14159265359;

            Console.WriteLine("My initials: " + initials);
            Console.WriteLine("Population in my country: " + population);
            Console.WriteLine("Population on earth: " + people);
            Console.WriteLine("The week day of today: " + day);
            Console.WriteLine("Duration in weeks of the C# .NET course: " + weeks);
            Console.WriteLine("The mathematical number PI: " + pi);
        }
    }
}

//int in C#=> System.Int32=>from -2,147,483,648 to 2,147,483,647.

//long in C#=> System.Int64 =>from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807