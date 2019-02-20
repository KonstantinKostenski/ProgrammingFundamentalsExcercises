using System;

namespace VendingMachine
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double totalMoney = 0;

            while (command != "Start")
            {
                double coin = double.Parse(command);
                
                if (coin != 0.1 && coin != 0.2 && coin != 0.5 && coin != 1 && coin != 2)
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
                command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                switch (command)
                {
                    case "Nuts":
                        if (totalMoney >= 2.0)
                        {
                            totalMoney -= 2.0;
                            Console.WriteLine("Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (totalMoney >= 0.7)
                        {
                            totalMoney -= 0.7;
                            Console.WriteLine("Purchased water");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (totalMoney >= 1.5)
                        {
                            totalMoney -= 1.5;
                            Console.WriteLine("Purchased crisps");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (totalMoney >= 0.8)
                        {
                            totalMoney -= 0.8;
                            Console.WriteLine("Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (totalMoney >= 1.0)
                        {
                            totalMoney -= 1.0;
                            Console.WriteLine("Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }

            }

            Console.WriteLine($"Change: {totalMoney:f2}");
        }
    }
}
