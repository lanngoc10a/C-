using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is the name of the city?");
            string name = Console.ReadLine();
            Console.WriteLine("Is " + name + " a capital ('true' or 'false')?");
            bool capital = bool.Parse(Console.ReadLine());
            Console.WriteLine("What is the number of inhabitants?");
            int inhabitants = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the tax revenue per inhabitant?");
            double revenue = double.Parse(Console.ReadLine());
            if ((capital & (inhabitants >= 100000)) || ((inhabitants > 200000) & (revenue >= 1000000000)))
            {
                Console.WriteLine(name + " is metropolis");
            }
            else
            {
                Console.WriteLine(name + " is not metropolis");
            }
        }
    }
}
