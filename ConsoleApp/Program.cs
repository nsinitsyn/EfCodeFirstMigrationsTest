using EfCodeFirstMigrationsTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var context = new DataContext())
      {
        context.Customers.Add(new Customer { Id = 1, Name = "Alex" });
        context.SaveChanges();
      }

      Console.ReadKey();
    }
  }
}
