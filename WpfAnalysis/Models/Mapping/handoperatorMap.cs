using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class handoperatorMap : EntityTypeConfiguration<handoperator>
    {
        public handoperatorMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.@operator)
                .HasMaxLength(20);

            this.Property(t => t.computer)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("handoperator");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.@operator).HasColumnName("operator");
            this.Property(t => t.computer).HasColumnName("computer");
            this.Property(t => t.optime).HasColumnName("optime");
        }
    }
}
