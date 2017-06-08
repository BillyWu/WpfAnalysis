using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class SystemSetMap : EntityTypeConfiguration<SystemSet>
    {
        public SystemSetMap()
        {
            // Primary Key
            this.HasKey(t => t.Mode);

            // Properties
            this.Property(t => t.UnitName)
                .HasMaxLength(200);

            this.Property(t => t.Mode)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("SystemSet");
            this.Property(t => t.UnitName).HasColumnName("UnitName");
            this.Property(t => t.Mode).HasColumnName("Mode");
        }
    }
}
