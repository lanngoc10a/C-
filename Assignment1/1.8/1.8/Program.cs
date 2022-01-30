using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[9];
            Console.WriteLine("Lets count 9 to 1!");
            for (int i = 0; i < 9; i++)
            {
                numbers[i] = i + 1;
            }
            for (int i = 8; i >= 0; i--) { 
                Console.WriteLine($"Counting .....{numbers[i]}");
        }
        }
    }
}
