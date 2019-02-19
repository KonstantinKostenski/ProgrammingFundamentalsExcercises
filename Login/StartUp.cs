using System;

namespace Login
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string login = Console.ReadLine();
            string password = "";
            bool equals = false;
            int numberOfTries = 0;

            while (true)
            {
                password = Console.ReadLine();
                numberOfTries++;
                int counter = 0;

                if (login.Length != password.Length)
                {
                    break;
                }

                for (int i = login.Length - 1; i >= 0; i--)
                {
                    equals = login[i] == password[counter];
                    counter++;
                }

                if (numberOfTries == 4)
                {
                    Console.WriteLine($"User {login} blocked!");
                    break;
                }

                if (equals)
                {
                    Console.WriteLine($"User {login} logged in.");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
}
