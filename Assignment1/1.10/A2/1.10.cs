using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many numbers in the Fibonacci sequence you would like to calculate?");
            int sequence_length = int.Parse(Console.ReadLine());
            int[] numbers = new int[sequence_length];

            numbers[0] = 0;
            numbers[1] = 1;


            for (int i = 2; i < sequence_length; i++)
            {
                numbers[i] = numbers[i - 1] + numbers[i - 2];
                //Console.WriteLine($"Counting .....{numbers[i]}");

            }
            Console.WriteLine("The sequence is: " + string.Join(" ", numbers));
        }
    }
}
