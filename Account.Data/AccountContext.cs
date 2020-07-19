using Account.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Account.Data
{
    public class AccountContext:DbContext
    {
        public AccountContext()
        {
        }
        public AccountContext(DbContextOptions<AccountContext> options)
          : base(options)
        {

        }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Entities.Account> Accounts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasIndex(x => new { x.Email }).IsUnique();
            modelBuilder.Entity<Entities.Account>().Property(x => x.Balance).HasDefaultValue(1000.00);
            modelBuilder.Entity<Entities.Account>().Property(x => x.OpenDate).HasDefaultValue(DateTime.Now);
            modelBuilder.Entity<Entities.Account>().Property(x => x.AccountId).HasDefaultValue(Guid.NewGuid());
            modelBuilder.Entity<Customer>().Property(x => x.CustomerId).HasDefaultValue(Guid.NewGuid());
        }
    }
}
