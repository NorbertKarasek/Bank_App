using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.Backend
{
    internal class Data
    {
        public static void GetAccounts()
        {
            Account account1 = new Account(1,"Jan Nowak", "001", 1457.23m);
            Account account2 = new Account(2,"Agnieszka Kowalska", "002", 3600.18m);
            Account account3 = new Account(3,"Robert Lewandowski", "003", 2745.03m);
            Account account4 = new Account(4,"Zofia Plucińska", "004", 7344.00m);
            Account account5 = new Account(5,"Grzegorz Braun", "005", 455.38m);
        }
    }
}