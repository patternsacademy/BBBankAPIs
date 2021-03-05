using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class BBBankContext : DbContext
    {
        public BBBankContext(DbContextOptions<BBBankContext> options)
           : base(options)
        { }
        public DbSet<Account> Accounts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(b =>
            {
                b.HasData(new
                {
                    Id = Guid.NewGuid().ToString(),
                    AccountNumber = "0001-1001",
                    AccountTitle = "Raas Masood"
                });
                b.HasData(new
                {
                    Id = Guid.NewGuid().ToString(),
                    AccountNumber = "0001-1002",
                    AccountTitle = "Jack Jill"
                });
            });
        }
    }
}
