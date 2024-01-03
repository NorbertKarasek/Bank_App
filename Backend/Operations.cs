using Bank_App.Frontend;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.Backend
{
    public class Operations
    {
        public static void LoggedInOperations(Account user)
        {
            while (true)
            {
                Display.LoggedInMenu(user);
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Display.DisplayBalance(user);
                        break;
                    case "2":
                        MakeTransfer(user, null);
                        break;
                    case "3":
                        return;
                    default:
                        Display.WrongChoice();
                        break;
                }
            }
        }
        public static void MakeTransfer(Account sender, Account recipient)
        {
            Display.GetRecipient();
            recipient = Account.GetUserByAccountNr(Console.ReadLine());
            if (recipient != null && recipient != sender && Account.accounts.Contains(recipient))
            {
                Display.GetAmount();
                if (decimal.TryParse(Console.ReadLine(), out decimal amount))
                {
                    if (amount > 0 && amount <= sender.Balance)
                    {
                        sender.Balance -= amount;
                        recipient.Balance += amount;
                        Display.SuccesfullTransfer(sender, recipient);
                    }
                    else
                    {
                        Display.InsufficientFunds();
                    }
                }
                else
                {
                    Display.WrongChoice();
                }
            }
            else
            {
                Display.WrongChoice();
            }
        }
    }
}
