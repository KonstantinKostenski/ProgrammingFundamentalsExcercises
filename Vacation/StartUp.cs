using System;

namespace Vacation
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int peopleNumber = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;

            switch (groupType)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 8.45; 
                            break;
                        case "Saturday":
                            price = 9.80;
                            break;
                        case "Sunday":
                            price = 10.46;
                            break;
                    }
                    break;
                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 10.90;
                            break;
                        case "Saturday":
                            price = 15.60;
                            break;
                        case "Sunday":
                            price = 16;
                            break;
                    }
                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 15;
                            break;
                        case "Saturday":
                            price = 20;
                            break;
                        case "Sunday":
                            price = 22.50;
                            break;
                    }
                    break;
            }

            if (groupType == "Students" && peopleNumber >= 30)
            {
                price *= 0.85;
            }

            if (groupType == "Business" && peopleNumber >= 100 )
            {
                peopleNumber -= 10;
            }

            if (groupType == "Regular" && peopleNumber >= 10 && peopleNumber <= 20)
            {
                price *= 0.95;
            }

            Console.WriteLine($"Total price: {peopleNumber * price:F2}");
        }
    }
}
