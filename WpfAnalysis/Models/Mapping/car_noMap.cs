using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class car_noMap : EntityTypeConfiguration<car_no>
    {
        public car_noMap()
        {
            // Primary Key
            this.HasKey(t => t.car_tid);

            // Properties
            this.Property(t => t.car_tid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.car_no1)
                .HasMaxLength(10);

            this.Property(t => t.car_name)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("car_no");
            this.Property(t => t.car_tid).HasColumnName("car_tid");
            this.Property(t => t.car_no1).HasColumnName("car_no");
            this.Property(t => t.car_name).HasColumnName("car_name");
        }
    }
}
