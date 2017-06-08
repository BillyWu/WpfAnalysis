using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class car_typeMap : EntityTypeConfiguration<car_type>
    {
        public car_typeMap()
        {
            // Primary Key
            this.HasKey(t => t.car_tid);

            // Properties
            this.Property(t => t.car_tid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.car_tname)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("car_type");
            this.Property(t => t.car_tid).HasColumnName("car_tid");
            this.Property(t => t.car_tname).HasColumnName("car_tname");
        }
    }
}
