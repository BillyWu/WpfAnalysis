using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class Table_PointDiscountMap : EntityTypeConfiguration<Table_PointDiscount>
    {
        public Table_PointDiscountMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VipLevel)
                .HasMaxLength(50);

            this.Property(t => t.VipName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Table_PointDiscount");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.VipLevel).HasColumnName("VipLevel");
            this.Property(t => t.VipName).HasColumnName("VipName");
            this.Property(t => t.FreeTime).HasColumnName("FreeTime");
            this.Property(t => t.Point).HasColumnName("Point");
            this.Property(t => t.Discount).HasColumnName("Discount");
        }
    }
}
