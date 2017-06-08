using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class VKQ_HistoryMap : EntityTypeConfiguration<VKQ_History>
    {
        public VKQ_HistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.RIQI2)
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("VKQ_History");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RIQI).HasColumnName("RIQI");
            this.Property(t => t.RIQI2).HasColumnName("RIQI2");
            this.Property(t => t.CREATEDT).HasColumnName("CREATEDT");
            this.Property(t => t.ISHISTORY).HasColumnName("ISHISTORY");
        }
    }
}
