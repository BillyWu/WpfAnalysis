using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class deviceMap : EntityTypeConfiguration<device>
    {
        public deviceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.dev_id, t.computer });

            // Properties
            this.Property(t => t.dev_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.dev_name)
                .HasMaxLength(30);

            this.Property(t => t.computer)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.location)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("device");
            this.Property(t => t.dev_id).HasColumnName("dev_id");
            this.Property(t => t.dev_name).HasColumnName("dev_name");
            this.Property(t => t.dev_tid).HasColumnName("dev_tid");
            this.Property(t => t.park_no).HasColumnName("park_no");
            this.Property(t => t.inside_park).HasColumnName("inside_park");
            this.Property(t => t.computer).HasColumnName("computer");
            this.Property(t => t.location).HasColumnName("location");
            this.Property(t => t.loopcheck).HasColumnName("loopcheck");
        }
    }
}
