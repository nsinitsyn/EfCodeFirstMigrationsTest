using EfCodeFirstMigrationsTest;
using System;

namespace ConsoleAppCore
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
