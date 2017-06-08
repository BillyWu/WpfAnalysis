using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class EateryDeviceMap : EntityTypeConfiguration<EateryDevice>
    {
        public EateryDeviceMap()
        {
            // Primary Key
            this.HasKey(t => t.DevNo);

            // Properties
            this.Property(t => t.DevNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DevName)
                .HasMaxLength(30);

            this.Property(t => t.Remark)
                .HasMaxLength(50);

            this.Property(t => t.@operator)
                .HasMaxLength(10);

            this.Property(t => t.devIP)
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("EateryDevice");
            this.Property(t => t.DevNo).HasColumnName("DevNo");
            this.Property(t => t.CmpNo).HasColumnName("CmpNo");
            this.Property(t => t.DinNo).HasColumnName("DinNo");
            this.Property(t => t.DevName).HasColumnName("DevName");
            this.Property(t => t.DevType).HasColumnName("DevType");
            this.Property(t => t.DevAddr).HasColumnName("DevAddr");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.CreateDT).HasColumnName("CreateDT");
            this.Property(t => t.@operator).HasColumnName("operator");
            this.Property(t => t.devIP).HasColumnName("devIP");
        }
    }
}
