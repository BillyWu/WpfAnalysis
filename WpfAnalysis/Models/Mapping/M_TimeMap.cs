using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class M_TimeMap : EntityTypeConfiguration<M_Time>
    {
        public M_TimeMap()
        {
            // Primary Key
            this.HasKey(t => t.TimeNo);

            // Properties
            this.Property(t => t.TimeNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TimeName)
                .HasMaxLength(50);

            this.Property(t => t.bDate)
                .HasMaxLength(10);

            this.Property(t => t.eDate)
                .HasMaxLength(10);

            this.Property(t => t.Week)
                .HasMaxLength(7);

            this.Property(t => t.Time11)
                .HasMaxLength(8);

            this.Property(t => t.Time12)
                .HasMaxLength(8);

            this.Property(t => t.Time21)
                .HasMaxLength(8);

            this.Property(t => t.Time22)
                .HasMaxLength(8);

            this.Property(t => t.Time31)
                .HasMaxLength(8);

            this.Property(t => t.Time32)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("M_Time");
            this.Property(t => t.TimeNo).HasColumnName("TimeNo");
            this.Property(t => t.TimeName).HasColumnName("TimeName");
            this.Property(t => t.bDate).HasColumnName("bDate");
            this.Property(t => t.eDate).HasColumnName("eDate");
            this.Property(t => t.NextTimeNo).HasColumnName("NextTimeNo");
            this.Property(t => t.Week).HasColumnName("Week");
            this.Property(t => t.Time11).HasColumnName("Time11");
            this.Property(t => t.Time12).HasColumnName("Time12");
            this.Property(t => t.Time21).HasColumnName("Time21");
            this.Property(t => t.Time22).HasColumnName("Time22");
            this.Property(t => t.Time31).HasColumnName("Time31");
            this.Property(t => t.Time32).HasColumnName("Time32");
        }
    }
}
