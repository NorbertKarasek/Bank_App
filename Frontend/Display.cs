using Bank_App.Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.Frontend
{
    internal class Display
    {
        public void DisplayWelcome()
        {
            Console.WriteLine("Witamy w Banku\n");
            Console.WriteLine("1. Lista klientów");
            Console.WriteLine("2. Zaloguj się");
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
    }
}
