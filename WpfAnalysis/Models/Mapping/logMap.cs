using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class logMap : EntityTypeConfiguration<log>
    {
        public logMap()
        {
            // Primary Key
            this.HasKey(t => t.log_id);

            // Properties
            this.Property(t => t.@operator)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("log");
            this.Property(t => t.log_id).HasColumnName("log_id");
            this.Property(t => t.log_date).HasColumnName("log_date");
            this.Property(t => t.log_type).HasColumnName("log_type");
            this.Property(t => t.@operator).HasColumnName("operator");
        }
    }
}
