namespace MasterDetail.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MasterDetail.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MasterDetail.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MasterDetail.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            string accountNumber = "123ABC";

            context.Customers.AddOrUpdate(
                c => c.AccountNumber,
                new Customer
                {
                    AccountNumber = accountNumber,
                    CompanyName = "ABC Company of America",
                    Address = "123 Main St.",
                    City = "San Diego",
                    State = "CA",
                    ZipCode = "92122"
                });

            context.SaveChanges();

            //Customer customer = context.Customers.First(c => c.AccountNumber == accountNumber);
        }
    }
}
