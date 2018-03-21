using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirstMigrationsTest
{
  public class DataContext : DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=testDb2;Integrated Security=true");
    }

    public DbSet<Customer> Customers { get; set; }
  }
}
