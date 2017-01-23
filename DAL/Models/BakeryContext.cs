using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DAL.Models.Mapping;

namespace DAL.Models
{
    public partial class BakeryContext : DbContext
    {
        static BakeryContext()
        {
            Database.SetInitializer<BakeryContext>(null);
        }

        public BakeryContext()
            : base("Name=BakeryContext")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<IngredientsProduct> IngredientsProducts { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoicesProduct> InvoicesProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new IngredientMap());
            modelBuilder.Configurations.Add(new IngredientsProductMap());
            modelBuilder.Configurations.Add(new InvoiceMap());
            modelBuilder.Configurations.Add(new InvoicesProductMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
        }
    }
}
