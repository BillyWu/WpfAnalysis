using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class kq_historyMap : EntityTypeConfiguration<kq_history>
    {
        public kq_historyMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("kq_history");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.riqi).HasColumnName("riqi");
            this.Property(t => t.createDT).HasColumnName("createDT");
            this.Property(t => t.IsHistory).HasColumnName("IsHistory");
        }
    }
}
