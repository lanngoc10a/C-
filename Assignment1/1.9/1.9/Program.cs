using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many dice would you like to roll");
            int numberOfDice = int.Parse(Console.ReadLine());
            var random = new Random();
            var sum = 0;
            for (int i = 1; i <= numberOfDice; i++)
            {
                
                int value = random.Next(1, 7);
                Console.WriteLine($"#Dice {i} is: "+ value);
                sum += value;
            }
            Console.WriteLine("The sum of all dice is: " + sum);
        }
    }
}
