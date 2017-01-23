using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Models.Mapping
{
    public class IngredientsProductMap : EntityTypeConfiguration<IngredientsProduct>
    {
        public IngredientsProductMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("IngredientsProducts");
            this.Property(t => t.IngredientId).HasColumnName("IngredientId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Id).HasColumnName("Id");

            // Relationships
            this.HasRequired(t => t.Ingredient)
                .WithMany(t => t.IngredientsProducts)
                .HasForeignKey(d => d.IngredientId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.IngredientsProducts)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
