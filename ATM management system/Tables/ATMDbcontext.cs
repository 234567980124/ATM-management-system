using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ATM_management_system.Models
{
    public class ATMDbContext : DbContext
    {
        public ATMDbContext() : base("sqlcon")
    { 
    }
    public DbSet<Atm> Atms { get; set; }
    public DbSet<CustomerInfo> Customers { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<Card> Cards { get; set; }
    public DbSet<TransactionType> TransactionTypes { get; set; }
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerInfo>().HasRequired(i => i.User).WithRequiredPrincipal(i => i.CustomerInfo);
        }

        public System.Data.Entity.DbSet<ATM_management_system.Models.NewRegisterModel> NewRegisterModels { get; set; }

        public System.Data.Entity.DbSet<ATM_management_system.Models.WithdrawalModel> WithdrawalModels { get; set; }

        public System.Data.Entity.DbSet<ATM_management_system.Models.AccountModel> AccountModels { get; set; }

        public System.Data.Entity.DbSet<ATM_management_system.Models.MinistatementModel> MinistatementModels { get; set; }
    }
    
 
}