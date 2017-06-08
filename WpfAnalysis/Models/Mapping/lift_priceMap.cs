using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class lift_priceMap : EntityTypeConfiguration<lift_price>
    {
        public lift_priceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.startfloor, t.endfloor, t.price });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.startfloor)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.endfloor)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.price)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("lift_price");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.startfloor).HasColumnName("startfloor");
            this.Property(t => t.endfloor).HasColumnName("endfloor");
            this.Property(t => t.price).HasColumnName("price");
        }
    }
}
