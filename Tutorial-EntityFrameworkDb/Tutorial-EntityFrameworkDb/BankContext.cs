using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial_EntityFrameworkDb.Models;

namespace Tutorial_EntityFrameworkDb
{
    public class BankContext : DbContext
    {
        public BankContext()
            : base("name=DefaultConnection")
        { }


        public DbSet<Card> Card { get; set; }
        public DbSet<Bank> Bank { get; set; }
        public DbSet<Customer> Customer { get; set; }
    }
}
