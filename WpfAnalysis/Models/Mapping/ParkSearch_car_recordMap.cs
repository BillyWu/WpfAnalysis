using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class ParkSearch_car_recordMap : EntityTypeConfiguration<ParkSearch_car_record>
    {
        public ParkSearch_car_recordMap()
        {
            // Primary Key
            this.HasKey(t => new { t.devID, t.devName, t.plateName, t.devIP, t.areaID, t.stamp });

            // Properties
            this.Property(t => t.devID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.devName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.plateName)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.devIP)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.smallPicPath)
                .IsFixedLength()
                .HasMaxLength(100);

            this.Property(t => t.picPath)
                .HasMaxLength(100);

            this.Property(t => t.areaID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Remark)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("ParkSearch_car_record");
            this.Property(t => t.devID).HasColumnName("devID");
            this.Property(t => t.devName).HasColumnName("devName");
            this.Property(t => t.plateName).HasColumnName("plateName");
            this.Property(t => t.devIP).HasColumnName("devIP");
            this.Property(t => t.smallPicPath).HasColumnName("smallPicPath");
            this.Property(t => t.picPath).HasColumnName("picPath");
            this.Property(t => t.areaID).HasColumnName("areaID");
            this.Property(t => t.stamp).HasColumnName("stamp");
            this.Property(t => t.inPark).HasColumnName("inPark");
            this.Property(t => t.newFlag).HasColumnName("newFlag");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
