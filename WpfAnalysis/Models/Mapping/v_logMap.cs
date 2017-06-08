using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class v_logMap : EntityTypeConfiguration<v_log>
    {
        public v_logMap()
        {
            // Primary Key
            this.HasKey(t => new { t.st, t.et });

            // Properties
            this.Property(t => t.@operator)
                .HasMaxLength(10);

            this.Property(t => t.dt)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.st)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.et)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("v_log");
            this.Property(t => t.@operator).HasColumnName("operator");
            this.Property(t => t.dt).HasColumnName("dt");
            this.Property(t => t.st).HasColumnName("st");
            this.Property(t => t.et).HasColumnName("et");
        }
    }
}
