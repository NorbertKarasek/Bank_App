using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.Backend
{
    public class Account
    {
        public int Id {  get; set; }
        public string AccountNumber {  get; set; }
        public string UserName { get; set; }
        public decimal Balance { get; set; }
        public static List<Account> accounts { get; set; } = new List<Account>();

        public Account(int id, string userName, string accountNumber, decimal balance)
        {
            Id = id;
            UserName = userName;
            AccountNumber = accountNumber;
            Balance = balance;
            accounts.Add(this);
        }

        public static Account GetUserByAccountNr(string accountNumber)
        {
            return accounts.FirstOrDefault(account => account.AccountNumber == accountNumber);
        }
    }
}
