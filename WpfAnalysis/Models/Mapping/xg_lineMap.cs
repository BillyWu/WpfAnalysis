using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class xg_lineMap : EntityTypeConfiguration<xg_line>
    {
        public xg_lineMap()
        {
            // Primary Key
            this.HasKey(t => t.line_no);

            // Properties
            this.Property(t => t.line_name)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("xg_line");
            this.Property(t => t.line_no).HasColumnName("line_no");
            this.Property(t => t.line_name).HasColumnName("line_name");
        }
    }
}
