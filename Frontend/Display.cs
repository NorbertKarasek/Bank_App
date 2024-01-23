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
            Console.WriteLine("**** Witamy w banku ****");
            Console.WriteLine("");
            Console.WriteLine("Zachęcamy do wydawania siana\n\n");
        }
        public static void DisplayMenu()
        {
            Console.WriteLine("1. Zaloguj się");
            Console.WriteLine("2. Lista klientów");
            Console.WriteLine("3. Zakończ");
        }

        public static void DisplayLoggedUser(Account user)
        {
            Console.Clear();
            Console.WriteLine($"Zalogowano na {user.UserName}");
        }
        public static void LoggedInMenu(Account user)
        {

            Console.WriteLine("\n1. Stan Konta");
            Console.WriteLine("2. Zrób przelew");
            Console.WriteLine("3. Wyloguj się\n");
        }

        public static void DisplayClients()
        {
            Console.Clear();
            Console.WriteLine("ID | USER NAME | ACCOUNT NUMBER");
            foreach (var client in Account.accounts)
            {
                Console.WriteLine($"{client.Id} | {client.UserName} | {client.AccountNumber}");
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
            Console.WriteLine("Nie masz wystarczających środków");
        }

        public static void SuccesfullTransfer(Account sender, Account recipient)
        {
            Console.Clear();
            Console.WriteLine($"Przelew udany. Stany kont: {sender.UserName}: {sender.Balance}, {recipient.UserName}: {recipient.Balance}");
        }
        public static void WrongChoice()
        {
            Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");
        }

        public static void LogOff()
        {
            Console.Clear();
            Console.WriteLine("Pomyślnie wylogowano");
        }
    }
}
