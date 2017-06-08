using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class color_typeMap : EntityTypeConfiguration<color_type>
    {
        public color_typeMap()
        {
            // Primary Key
            this.HasKey(t => t.color_tid);

            // Properties
            this.Property(t => t.color_tid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.color_tname)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("color_type");
            this.Property(t => t.color_tid).HasColumnName("color_tid");
            this.Property(t => t.color_tname).HasColumnName("color_tname");
        }
    }
}
