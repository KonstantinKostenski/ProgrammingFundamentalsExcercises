using System;

namespace Division
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number % 10 == 0)
            {
                Console.WriteLine("The number is divisible by 10");
                return;
            }
            if (number % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
                return;
            }
            if (number % 6 == 0)
            {
                Console.WriteLine("The number is divisible by 6");
                return;
            }
            if (number % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is divisible by 2");
                return;
            }
            Console.WriteLine("Not divisible");
        }
    }
}
