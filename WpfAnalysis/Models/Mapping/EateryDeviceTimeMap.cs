using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class EateryDeviceTimeMap : EntityTypeConfiguration<EateryDeviceTime>
    {
        public EateryDeviceTimeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.DevNo, t.DayName });

            // Properties
            this.Property(t => t.DevNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DayName)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Start1)
                .HasMaxLength(5);

            this.Property(t => t.End1)
                .HasMaxLength(5);

            this.Property(t => t.Start2)
                .HasMaxLength(5);

            this.Property(t => t.End2)
                .HasMaxLength(5);

            this.Property(t => t.Start3)
                .HasMaxLength(5);

            this.Property(t => t.End3)
                .HasMaxLength(5);

            this.Property(t => t.Start4)
                .HasMaxLength(5);

            this.Property(t => t.End4)
                .HasMaxLength(5);

            this.Property(t => t.Start5)
                .HasMaxLength(5);

            this.Property(t => t.End5)
                .HasMaxLength(5);

            this.Property(t => t.Start6)
                .HasMaxLength(5);

            this.Property(t => t.End6)
                .HasMaxLength(5);

            this.Property(t => t.Start7)
                .HasMaxLength(5);

            this.Property(t => t.End7)
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("EateryDeviceTime");
            this.Property(t => t.DevNo).HasColumnName("DevNo");
            this.Property(t => t.DayName).HasColumnName("DayName");
            this.Property(t => t.StartDT).HasColumnName("StartDT");
            this.Property(t => t.EndDT).HasColumnName("EndDT");
            this.Property(t => t.Start1).HasColumnName("Start1");
            this.Property(t => t.End1).HasColumnName("End1");
            this.Property(t => t.Start2).HasColumnName("Start2");
            this.Property(t => t.End2).HasColumnName("End2");
            this.Property(t => t.Start3).HasColumnName("Start3");
            this.Property(t => t.End3).HasColumnName("End3");
            this.Property(t => t.Start4).HasColumnName("Start4");
            this.Property(t => t.End4).HasColumnName("End4");
            this.Property(t => t.Start5).HasColumnName("Start5");
            this.Property(t => t.End5).HasColumnName("End5");
            this.Property(t => t.Start6).HasColumnName("Start6");
            this.Property(t => t.End6).HasColumnName("End6");
            this.Property(t => t.Start7).HasColumnName("Start7");
            this.Property(t => t.End7).HasColumnName("End7");
            this.Property(t => t.DayNumber).HasColumnName("DayNumber");
        }
    }
}
