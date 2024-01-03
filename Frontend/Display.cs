using Bank_App.Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        public static void LoggedInMenu(Account user)
        {
            Console.WriteLine($"Zalogowano na {user.UserName}");
            Console.WriteLine("1. Stan Konta");
            Console.WriteLine("2. Zrób przelew");
            Console.WriteLine("3. Wyloguj się");
        }

        public static void DisplayClients()
        {
            Console.WriteLine("ID | USER NAME | ACCOUNT NUMBER");
            foreach (var client in Account.accounts)
            {
                Console.WriteLine($"{client.Id} | {client.UserName} | {client.AccountNumber}");
            }
        }

        public static void DisplayBalance(Account user)
        {
            Console.WriteLine($"Stan konta to {user.Balance}");
        }

        public static void LogInScreen()
        {
            Console.Write("\nAby się zalogować podaj nr konta: ");
        }

        public static void GetRecipient()
        {
            Console.WriteLine("Podaj nr konta odbiorcy: ");
        }

        public static void GetAmount()
        {
            Console.WriteLine("Podaj kwotę przelewu: ");
        }
        
        public static void InsufficientFunds()
        {
            Console.WriteLine("Nie masz wystarczających środków");
        }

        public static void SuccesfullTransfer(Account sender, Account recipient)
        {
            Console.WriteLine($"Przelew udany. Stany kont: {sender.UserName}: {sender.Balance}, {recipient.UserName}: {recipient.Balance}");
        }
        public static void WrongChoice()
        {
            Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");
        }

    }
}
