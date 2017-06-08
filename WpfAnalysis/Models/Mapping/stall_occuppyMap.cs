using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class stall_occuppyMap : EntityTypeConfiguration<stall_occuppy>
    {
        public stall_occuppyMap()
        {
            // Primary Key
            this.HasKey(t => t.stall);

            // Properties
            this.Property(t => t.stall)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("stall_occuppy");
            this.Property(t => t.stall).HasColumnName("stall");
            this.Property(t => t.occuppy).HasColumnName("occuppy");
            this.Property(t => t.isdown).HasColumnName("isdown");
        }
    }
}
