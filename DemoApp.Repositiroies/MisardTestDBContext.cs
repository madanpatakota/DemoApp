using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;


using DemoApp.APIs.Entities;


namespace DemoApp.APIs
{
    public class MisardTestDBContext : DbContext
    {



        //options connection realted details
        public MisardTestDBContext(DbContextOptions<MisardTestDBContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Branch> Branches { get; set; }

        public DbSet<BankTransaction> BankTransactions { get; set; }


        public DbSet<Account> Accounts { get; set; }



        //base

        protected  override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
