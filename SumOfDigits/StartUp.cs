using System;

namespace SumOfDigits
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberCopy = number;
            int digitsSum = 0;

            while (number != 0)
            {
                int digit = number % 10;
                digitsSum += digit;
                number /= 10;
            }

            Console.WriteLine(digitsSum);
        }
    }
}
