using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write the name of 2 different people  \n One at a time, press [Enter] after each name: ");
            string name1 = Console.ReadLine();
            //Console.WriteLine(name1);
            string name2 = Console.ReadLine();
            // Console.WriteLine(name2);
            Console.WriteLine("Write the age of: " + name1);
            int age1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the age of: " + name2);
            int age2 = Convert.ToInt32(Console.ReadLine());
            if (age1 > age2)
            {
                Console.WriteLine(name1 + " is older than " + name2);
            }
            else if (age1 < age2)
            {
                Console.WriteLine(name2 + " is older than " + name1);
            }
            else if (age1 == age2)
            {
                Console.WriteLine(name1 + " is equal to " + name2);
            }
            else
            {
                Console.WriteLine("Write the correct input!");
            }
        }
    }
}
