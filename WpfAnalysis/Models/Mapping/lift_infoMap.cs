using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class lift_infoMap : EntityTypeConfiguration<lift_info>
    {
        public lift_infoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.lift_no, t.lift_name, t.totalFloor });

            // Properties
            this.Property(t => t.lift_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.lift_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.totalFloor)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.lift_type)
                .HasMaxLength(30);

            this.Property(t => t.startFloor)
                .HasMaxLength(30);

            this.Property(t => t.controlfloor)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("lift_info");
            this.Property(t => t.lift_no).HasColumnName("lift_no");
            this.Property(t => t.lift_name).HasColumnName("lift_name");
            this.Property(t => t.totalFloor).HasColumnName("totalFloor");
            this.Property(t => t.lift_type).HasColumnName("lift_type");
            this.Property(t => t.startFloor).HasColumnName("startFloor");
            this.Property(t => t.bureau_no).HasColumnName("bureau_no");
            this.Property(t => t.controlfloor).HasColumnName("controlfloor");
            this.Property(t => t.flag).HasColumnName("flag");
        }
    }
}
