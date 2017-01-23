using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Models.Mapping
{
    public class InvoicesProductMap : EntityTypeConfiguration<InvoicesProduct>
    {
        public InvoicesProductMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("InvoicesProducts");
            this.Property(t => t.InvoiceId).HasColumnName("InvoiceId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Id).HasColumnName("Id");

            // Relationships
            this.HasRequired(t => t.Invoice)
                .WithMany(t => t.InvoicesProducts)
                .HasForeignKey(d => d.InvoiceId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.InvoicesProducts)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
