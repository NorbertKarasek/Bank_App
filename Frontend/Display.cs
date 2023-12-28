using Bank_App.Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.Frontend
{
    internal class Display
    {
        public static void DisplayWelcome()
        {
            Console.WriteLine("1. Zaloguj się");
            Console.WriteLine("2. Lista klientów");
            Console.WriteLine("3. Zakończ");
        }

        public static void DisplayClients()
        {
            Console.WriteLine("ID | USER NAME | ACCOUNT NUMBER");
            foreach (var client in Account.accounts)
            {
                Console.WriteLine($"{client.Id} | {client.UserName} | {client.AccountNumber}");
            }
        }

        public void DisplayBalance(Account user)
        {
            Console.WriteLine($"Stan konta to {user.Balance}");
        }

        public static string LogInScreen()
        {
            Console.Write("\nAby się zalogować podaj nr konta: ");
            string AccNr = Console.ReadLine();
            return AccNr;
        }

        public static void SuccesfulLogIn(Account user)
        {
            Console.WriteLine($"Witamy {user.UserName}");
        }

        public static void WrongChoice()
        {
            Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");
        }

    }
}
