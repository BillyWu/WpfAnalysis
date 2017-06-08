using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class Parksearch_posMap : EntityTypeConfiguration<Parksearch_pos>
    {
        public Parksearch_posMap()
        {
            // Primary Key
            this.HasKey(t => new { t.posID, t.posName, t.posIP });

            // Properties
            this.Property(t => t.posID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.posName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.posIP)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.areaMapPath)
                .HasMaxLength(250);

            this.Property(t => t.Rermark)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Parksearch_pos");
            this.Property(t => t.posID).HasColumnName("posID");
            this.Property(t => t.posName).HasColumnName("posName");
            this.Property(t => t.posIP).HasColumnName("posIP");
            this.Property(t => t.xPos).HasColumnName("xPos");
            this.Property(t => t.yPos).HasColumnName("yPos");
            this.Property(t => t.areaMapPath).HasColumnName("areaMapPath");
            this.Property(t => t.Rermark).HasColumnName("Rermark");
        }
    }
}
