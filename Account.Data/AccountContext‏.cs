using Microsoft.EntityFrameworkCore;
using Account.Data.Entities;
using System;

namespace Account.Data
{
   public class AccountContext‏: DbContext
    {
        public AccountContext‏()
        {
                
        }
     
        public AccountContext‏(DbContextOptions<AccountContext‏> options)
          : base(options)
        {

        }
        public DbSet<Account.Data.Entities.Account> Accounts { get; set; }
    
        public DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasIndex(x => new { x.Email }).IsUnique();
            modelBuilder.Entity<Entities.Account>().Property(x => x.Balance).HasDefaultValue(1000.00);
            modelBuilder.Entity<Entities.Account>().Property(x => x.OpenDate).HasDefaultValue(DateTime.Now);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=ILRLEMBERGERLT; Database= AccountDB‏;Trusted_Connection = True;MultipleActiveResultSets=true;");
                base.OnConfiguring(optionsBuilder);
            }
        }
    }
}
