using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class PA_tboDeviceMap : EntityTypeConfiguration<PA_tboDevice>
    {
        public PA_tboDeviceMap()
        {
            // Primary Key
            this.HasKey(t => t.SeqNO);

            // Properties
            this.Property(t => t.Display)
                .HasMaxLength(50);

            this.Property(t => t.Memo)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("PA_tboDevice");
            this.Property(t => t.SeqNO).HasColumnName("SeqNO");
            this.Property(t => t.Region).HasColumnName("Region");
            this.Property(t => t.UpNO).HasColumnName("UpNO");
            this.Property(t => t.Display).HasColumnName("Display");
            this.Property(t => t.DevType).HasColumnName("DevType");
            this.Property(t => t.Memo).HasColumnName("Memo");
        }
    }
}
