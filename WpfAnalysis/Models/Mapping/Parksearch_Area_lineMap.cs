using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class Parksearch_Area_lineMap : EntityTypeConfiguration<Parksearch_Area_line>
    {
        public Parksearch_Area_lineMap()
        {
            // Primary Key
            this.HasKey(t => new { t.areaID, t.posID, t.sequence });

            // Properties
            this.Property(t => t.areaID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.posID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sequence)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Rermark)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Parksearch_Area_line");
            this.Property(t => t.areaID).HasColumnName("areaID");
            this.Property(t => t.posID).HasColumnName("posID");
            this.Property(t => t.sequence).HasColumnName("sequence");
            this.Property(t => t.xPos).HasColumnName("xPos");
            this.Property(t => t.yPos).HasColumnName("yPos");
            this.Property(t => t.Rermark).HasColumnName("Rermark");
        }
    }
}
