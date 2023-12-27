using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.Backend
{
    internal class Account
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

        public Account GetUser(string AccNr)
        {
            var user = accounts.FirstOrDefault(x => x.AccountNumber == AccNr);
            return user;
        }
    }
}
