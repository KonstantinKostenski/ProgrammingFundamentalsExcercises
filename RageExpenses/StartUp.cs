using System;

namespace RageExpenses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());
            decimal totalExpenses = 0m;
            int keyobardTrashTimes = 0;

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0 && i != 0)
                {
                    totalExpenses += headsetPrice;

                    if (i % 3 == 0)
                    {
                        totalExpenses += mousePrice + keyboardPrice;
                        keyobardTrashTimes++;

                        if (keyobardTrashTimes % 2 == 0)
                        {
                            totalExpenses += displayPrice;
                        }
                    }
                }
                else if (i % 3 == 0 && i != 0)
                {
                    totalExpenses += mousePrice;
                }
            }

            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
        }
    }
}
