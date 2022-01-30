using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What do you want to convert?  \n 1= inches to centimeters  \n 2 = centimeters to inches");
            int convertype = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Write the value you want to converted: \n");
            int value = Convert.ToInt32(Console.ReadLine());
            if (convertype == 1)
            {
                Console.WriteLine(value + " inches equal to " + 2.54 * value + " in cm ");
            } else if (convertype == 2)
            {
                Console.WriteLine(value + " cm qual to "+ value / 2.54 + " inches ");
            } else
            {
                Console.WriteLine("Please write the correct convert type");
            }
        }
    }
}