using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using OpenQubit.Account.Common.Models;
//using ClassLibOpenQubit.Account.Common.Modelsrary1;

namespace OpenQbit.Accounts.DAL.DataAccess
{
    public class AccountDbContext : DbContext
    {


        public AccountDbContext() : base("Accounts") {
        }
        //public DbSet<Accounts> Accounts { get; set; }
        //public DbSet<> Customer { get; set; }
        //public DbSet<Transaction> Transaction { get; set; }
        //public DbSet<ItemDetail> ItemDetails { get; set; }
        //public DbSet<Item> Items { get; set; }

            public DbSet<Account> Accounts { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Transaction> Transaction{ get; set; }
        public DbSet<TransactionDetail> TransactionDetail { get; set; }
        public DbSet<TransactionTemplate> TransactionTemplate { get; set; }
        public DbSet<TransactionTemplateDetail> TransactionTemplateDetail { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
