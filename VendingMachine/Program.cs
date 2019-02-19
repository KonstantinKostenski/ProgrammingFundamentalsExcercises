using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double totalMoney = 0;

            while (command != "Start")
            {
                double coin = double.Parse(command);
                
                if (coin != 0.1 || coin != 0.2 || coin != 0.5 || coin != 1 || coin != 2)
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                else
                {
                    totalMoney += coin;
                }

                command = Console.ReadLine();
            }

            while (true)
            {

            }
        }
    }
}
