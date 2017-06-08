using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class EateryDevicePriceMap : EntityTypeConfiguration<EateryDevicePrice>
    {
        public EateryDevicePriceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.DevNo, t.MenuNo });

            // Properties
            this.Property(t => t.DevNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MenuNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MenuName)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("EateryDevicePrice");
            this.Property(t => t.DevNo).HasColumnName("DevNo");
            this.Property(t => t.MenuNo).HasColumnName("MenuNo");
            this.Property(t => t.MenuName).HasColumnName("MenuName");
            this.Property(t => t.MenuPrice).HasColumnName("MenuPrice");
        }
    }
}
