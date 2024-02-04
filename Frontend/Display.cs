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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**** Witamy w banku ****");
            Console.WriteLine("");
            Console.WriteLine("Zachęcamy do wydawania siana\n\n");
        }
        public static void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("WYBIERZ OPCJĘ:");
            Console.WriteLine("1. Zaloguj się");
            Console.WriteLine("2. Lista klientów");
            Console.WriteLine("3. Zakończ\n");
        }

        public static void DisplayLoggedUser(Account user)
        {
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("* Pomyślnie zalogowano *");
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine($"Witamy {user.FirstName} {user.LastName}");
            Console.WriteLine($"Numer konta: {user.AccountNumber}");
        }
        public static void LoggedInMenu(Account user)
        {
            Console.WriteLine("\nWYBIERZ OPCJĘ:");
            Console.WriteLine("1. Stan Konta");
            Console.WriteLine("2. Zrób przelew");
            Console.WriteLine("3. Wyloguj się\n");
        }

        public static void DisplayClients()
        {
            Console.Clear();
            Console.WriteLine("ID | USER NAME | ACCOUNT NUMBER");
            foreach (var client in Account.accounts)
            {
                Console.WriteLine($"{client.Id} | {client.FirstName} {client.LastName} | {client.AccountNumber}");
            }
            Console.WriteLine("");
        }

        public static void DisplayBalance(Account user)
        {
            Console.Clear();
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nie masz wystarczających środków");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void SuccesfullTransfer(Account sender, Account recipient)
        {
            Console.Clear();
            Console.WriteLine($"Przelew udany. Stany kont: {sender.FirstName}: {sender.Balance}, {recipient.LastName}: {recipient.Balance}");
        }
        public static void WrongChoice()
        {
            Console.Clear();
            Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");
        }

        public static void LogOff()
        {
            Console.Clear();
            Console.WriteLine("Pomyślnie wylogowano");
        }
    }
}
