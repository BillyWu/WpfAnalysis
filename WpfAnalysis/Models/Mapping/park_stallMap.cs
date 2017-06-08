using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class park_stallMap : EntityTypeConfiguration<park_stall>
    {
        public park_stallMap()
        {
            // Primary Key
            this.HasKey(t => t.stall_no);

            // Properties
            this.Property(t => t.stall_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.stall_name)
                .HasMaxLength(20);

            this.Property(t => t.remark)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("park_stall");
            this.Property(t => t.stall_no).HasColumnName("stall_no");
            this.Property(t => t.stall_name).HasColumnName("stall_name");
            this.Property(t => t.stall_num).HasColumnName("stall_num");
            this.Property(t => t.remark).HasColumnName("remark");
        }
    }
}
