using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class ParkSearch_car_logMap : EntityTypeConfiguration<ParkSearch_car_log>
    {
        public ParkSearch_car_logMap()
        {
            // Primary Key
            this.HasKey(t => new { t.devID, t.devName });

            // Properties
            this.Property(t => t.devID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.devName)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("ParkSearch_car_log");
            this.Property(t => t.devID).HasColumnName("devID");
            this.Property(t => t.devName).HasColumnName("devName");
            this.Property(t => t.DevTime).HasColumnName("DevTime");
            this.Property(t => t.devState).HasColumnName("devState");
        }
    }
}
