using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class parkMap : EntityTypeConfiguration<park>
    {
        public parkMap()
        {
            // Primary Key
            this.HasKey(t => t.park_no);

            // Properties
            this.Property(t => t.park_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.park_name)
                .HasMaxLength(20);

            this.Property(t => t.remark)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("park");
            this.Property(t => t.park_no).HasColumnName("park_no");
            this.Property(t => t.park_name).HasColumnName("park_name");
            this.Property(t => t.park_type).HasColumnName("park_type");
            this.Property(t => t.belong_to).HasColumnName("belong_to");
            this.Property(t => t.all_stall).HasColumnName("all_stall");
            this.Property(t => t.free_stall).HasColumnName("free_stall");
            this.Property(t => t.remark).HasColumnName("remark");
        }
    }
}
