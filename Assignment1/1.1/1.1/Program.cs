using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write a color: ");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "yellow":
                    Console.WriteLine("Banana");
                    break;
                case "red":
                    Console.WriteLine("Apple");
                    break;
                case "orange":
                    Console.WriteLine("Orange");
                    break;
                default :
                    Console.WriteLine("Unknown fruit");
                    break;
            }
        }
        }
    }
