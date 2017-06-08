using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class Parksearch_recognizerMap : EntityTypeConfiguration<Parksearch_recognizer>
    {
        public Parksearch_recognizerMap()
        {
            // Primary Key
            this.HasKey(t => new { t.devID, t.devName, t.devIP, t.areaID });

            // Properties
            this.Property(t => t.devID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.devName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.devIP)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.areaID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.fixLocation)
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Parksearch_recognizer");
            this.Property(t => t.devID).HasColumnName("devID");
            this.Property(t => t.devName).HasColumnName("devName");
            this.Property(t => t.devIP).HasColumnName("devIP");
            this.Property(t => t.areaID).HasColumnName("areaID");
            this.Property(t => t.fixLocation).HasColumnName("fixLocation");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
