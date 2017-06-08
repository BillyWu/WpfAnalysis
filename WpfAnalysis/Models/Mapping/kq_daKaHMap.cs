using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class kq_daKaHMap : EntityTypeConfiguration<kq_daKaH>
    {
        public kq_daKaHMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("kq_daKaH");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.custNo).HasColumnName("custNo");
            this.Property(t => t.daKaDT).HasColumnName("daKaDT");
            this.Property(t => t.IsQianKa).HasColumnName("IsQianKa");
        }
    }
}
