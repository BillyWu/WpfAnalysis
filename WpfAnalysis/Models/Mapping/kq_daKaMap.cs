using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class kq_daKaMap : EntityTypeConfiguration<kq_daKa>
    {
        public kq_daKaMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.doorName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("kq_daKa");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.custNo).HasColumnName("custNo");
            this.Property(t => t.daKaDT).HasColumnName("daKaDT");
            this.Property(t => t.IsQianKa).HasColumnName("IsQianKa");
            this.Property(t => t.doorName).HasColumnName("doorName");
        }
    }
}
