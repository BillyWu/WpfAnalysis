using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class devtypeMap : EntityTypeConfiguration<devtype>
    {
        public devtypeMap()
        {
            // Primary Key
            this.HasKey(t => t.dev_tid);

            // Properties
            this.Property(t => t.dev_tid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.dev_tname)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("devtype");
            this.Property(t => t.dev_tid).HasColumnName("dev_tid");
            this.Property(t => t.dev_tname).HasColumnName("dev_tname");
        }
    }
}
