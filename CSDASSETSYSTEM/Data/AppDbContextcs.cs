using CSDASSETSYSTEM.Models.Core;
using System.Data.Entity;

namespace CSDASSETSYSTEM.Data.context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=ApplicationServices")
        {

        }
        public DbSet<Reciept> Reciepts { get; set; }
        public DbSet<RecieptsProduct> RecieptsProducts { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Asset> Assets { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Address> Addresses { get; set; }
    }



}