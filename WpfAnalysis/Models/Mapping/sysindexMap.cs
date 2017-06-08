using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class sysindexMap : EntityTypeConfiguration<sysindex>
    {
        public sysindexMap()
        {
            // Primary Key
            this.HasKey(t => t.code);

            // Properties
            this.Property(t => t.code)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("sysindex");
            this.Property(t => t.code).HasColumnName("code");
            this.Property(t => t.sequ).HasColumnName("sequ");
        }
    }
}
