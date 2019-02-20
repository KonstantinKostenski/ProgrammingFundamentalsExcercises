using System;

namespace task1
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double moneyAmount = double.Parse(Console.ReadLine());
            int studentsNumber = int.Parse(Console.ReadLine());
            double pricePerSword = double.Parse(Console.ReadLine());
            double pricePerRobe = double.Parse(Console.ReadLine());
            double pricePerBelt = double.Parse(Console.ReadLine());
            double sabersTotalPrice = (pricePerSword * studentsNumber) + (Math.Ceiling((0.1 * studentsNumber)) * pricePerSword);
            double robesTotalPrice = studentsNumber * pricePerRobe;
            double beltsTotalPrice = 0;

            if (studentsNumber > 6)
            {
                beltsTotalPrice = (pricePerBelt * studentsNumber) - (studentsNumber / 6 * pricePerBelt);
            }
            else
            {
                beltsTotalPrice = pricePerBelt * studentsNumber;
            }

            double totalTotalPrice = sabersTotalPrice + robesTotalPrice + beltsTotalPrice;

            if (totalTotalPrice > moneyAmount)
            {
                Console.WriteLine($"Ivan Cho will need {Math.Abs(totalTotalPrice - moneyAmount):f2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {totalTotalPrice:f2}lv.");
            }
        }
    }
}