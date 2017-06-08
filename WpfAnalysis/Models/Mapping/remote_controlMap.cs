using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class remote_controlMap : EntityTypeConfiguration<remote_control>
    {
        public remote_controlMap()
        {
            // Primary Key
            this.HasKey(t => new { t.indt, t.@operator });

            // Properties
            this.Property(t => t.@operator)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.picture)
                .HasMaxLength(100);

            this.Property(t => t.allowFree)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("remote_control");
            this.Property(t => t.indt).HasColumnName("indt");
            this.Property(t => t.@operator).HasColumnName("operator");
            this.Property(t => t.comm_type).HasColumnName("comm_type");
            this.Property(t => t.address).HasColumnName("address");
            this.Property(t => t.flag).HasColumnName("flag");
            this.Property(t => t.picture).HasColumnName("picture");
            this.Property(t => t.isHandOver).HasColumnName("isHandOver");
            this.Property(t => t.allowFree).HasColumnName("allowFree");
        }
    }
}
