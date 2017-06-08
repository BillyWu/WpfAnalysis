using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class ParkSearch_mapMap : EntityTypeConfiguration<ParkSearch_map>
    {
        public ParkSearch_mapMap()
        {
            // Primary Key
            this.HasKey(t => new { t.mapID, t.mapName, t.mapPath, t.devID });

            // Properties
            this.Property(t => t.mapID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.mapName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.mapPath)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.devID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ParkSearch_map");
            this.Property(t => t.mapID).HasColumnName("mapID");
            this.Property(t => t.mapName).HasColumnName("mapName");
            this.Property(t => t.mapPath).HasColumnName("mapPath");
            this.Property(t => t.devID).HasColumnName("devID");
        }
    }
}
