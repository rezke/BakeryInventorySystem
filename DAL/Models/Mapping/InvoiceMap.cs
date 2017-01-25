using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Models.Mapping
{
    public class InvoiceMap : EntityTypeConfiguration<Invoice>
    {
        public InvoiceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Invoices");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.CustomerId).HasColumnName("CustomerId");

            // Relationships
            this.HasRequired(t => t.Customer)
                .WithMany(t => t.Invoices)
                .HasForeignKey(d => d.CustomerId);

        }
    }
}
