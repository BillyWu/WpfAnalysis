using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class park_timesecMap : EntityTypeConfiguration<park_timesec>
    {
        public park_timesecMap()
        {
            // Primary Key
            this.HasKey(t => t.timeid);

            // Properties
            this.Property(t => t.timeid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.timename)
                .HasMaxLength(20);

            this.Property(t => t.timesec1)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.timesec2)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.timedate)
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("park_timesec");
            this.Property(t => t.timeid).HasColumnName("timeid");
            this.Property(t => t.timename).HasColumnName("timename");
            this.Property(t => t.timesec1).HasColumnName("timesec1");
            this.Property(t => t.timesec2).HasColumnName("timesec2");
            this.Property(t => t.timedate).HasColumnName("timedate");
            this.Property(t => t.satrest).HasColumnName("satrest");
            this.Property(t => t.sunrest).HasColumnName("sunrest");
        }
    }
}
