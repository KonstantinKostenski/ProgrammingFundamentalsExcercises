using System;

namespace StrongNumber
{
    class StartUp
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            long numberCopy = number;
            long digit = 0;
            long factorial = 0;
            long factorialSum = 0;

            while (number != 0)
            {
                digit = number % 10;
                factorial = 1;

                if (digit == 0)
                {
                    factorialSum += factorial;
                    continue;
                }

                for (long i = 2; i <= digit; i++)
                {
                    factorial *= i;
                }

                factorialSum += factorial;

                number /= 10;
            }

            if (factorialSum == numberCopy)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
