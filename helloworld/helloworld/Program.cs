using System;
using System.Collections.Generic;

namespace helloworld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello World" + name + "...");
            Console.WriteLine("Hey, are you excited about learning C# ! :D");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine("Cool, me too!");
            } else if (answer == "no")
            {
                Console.WriteLine("Oh, sorry to hear that.");
            } else
            {
                Console.WriteLine("Sorry, I dont understand");
            }
            Console.WriteLine("Lets count ten times, 0 to 9!");
            for (int i=0; i<10; i++)
            {
                Console.WriteLine($"Counting .....{i}");
            }
            //Creating an array with default values:
            int[] arrayOfIntergers = new[] { 4, 6, 70, 345, -4 };
            // Doint the same as a List:
            List<int> listOfIntegers = new List<int>();
            listOfIntegers.Add(4);
            listOfIntegers.Add(6);
            listOfIntegers.Add(70);
        }
    }
}
