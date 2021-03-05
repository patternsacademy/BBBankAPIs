using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class AccountsService
    {
        public List<Account> GetAllAccounts()
        {
            var accounts = new List<Account>();
            accounts.Add(new Account()
            {
                AccountNumber = "1101",
                AccountTitle = "John Doe"
            });
            accounts.Add(new Account()
            {
                AccountNumber = "1102",
                AccountTitle = "Andrew Mike"
            });
            return accounts;
        }
    }
}
