using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
   public class AccountRepository
    {
        protected DbContext _context;
        protected DbSet<Account> AccountSet;
        public AccountRepository(DbContext context)
        {
            _context = context;
            AccountSet = _context.Set<Account>();
        }
        public async Task<ICollection<Account>> GetAllAccounts()
        {
            return await AccountSet.ToListAsync();
        }
    }
}
