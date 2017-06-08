using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class ParkSearch_area_dictionaryMap : EntityTypeConfiguration<ParkSearch_area_dictionary>
    {
        public ParkSearch_area_dictionaryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.areaID, t.areaName });

            // Properties
            this.Property(t => t.areaID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.areaName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ParkSearch_area_dictionary");
            this.Property(t => t.areaID).HasColumnName("areaID");
            this.Property(t => t.areaName).HasColumnName("areaName");
        }
    }
}
