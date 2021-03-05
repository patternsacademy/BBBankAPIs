using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class AccountsService
    {
        private readonly AccountRepository _accountRepo;
        public AccountsService(AccountRepository accountRepo)
        {
            _accountRepo = accountRepo;
        }
        public async Task<ICollection<Account>> GetAllAccounts()
        {
            return await _accountRepo.GetAllAccounts();
        }
    }
}
