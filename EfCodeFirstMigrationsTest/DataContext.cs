using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirstMigrationsTest
{
  public class DataContext : DbContext
  {
    public DataContext() : base("name=testDb")
    {

    }

    public DbSet<Customer> Customers { get; set; }
  }
}
