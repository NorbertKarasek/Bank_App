using Bank_App.Frontend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.Backend
{
    public class Bank
    {
        public static void StartMenu()
        {
            while (true)
            {
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        LoggingIn();
                        break;
                    case "2":
                        Display.DisplayClients();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Display.WrongChoice();
                        break;
                }
            }
        }

        public static Account LoggingIn()
        {
            Display.LogInScreen();
            var LoggedUser = Account.GetUserByAccountNr(Console.ReadLine());
            if (LoggedUser != null && Account.accounts.Contains(LoggedUser))
            {
                Operations.LoggedInOperations(LoggedUser);
                return LoggedUser;
            }
            else
            {
                Display.WrongChoice();
                return LoggingIn();
            }
        }
    }
}
