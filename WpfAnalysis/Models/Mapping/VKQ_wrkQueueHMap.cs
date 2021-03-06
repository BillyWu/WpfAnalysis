using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class VKQ_wrkQueueHMap : EntityTypeConfiguration<VKQ_wrkQueueH>
    {
        public VKQ_wrkQueueHMap()
        {
            // Primary Key
            this.HasKey(t => t.type);

            // Properties
            this.Property(t => t.wrkname)
                .HasMaxLength(20);

            this.Property(t => t.deptname)
                .HasMaxLength(20);

            this.Property(t => t.type)
                .IsRequired()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("VKQ_wrkQueueH");
            this.Property(t => t.wrkDate).HasColumnName("wrkDate");
            this.Property(t => t.wrkname).HasColumnName("wrkname");
            this.Property(t => t.deptname).HasColumnName("deptname");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.wrkNo).HasColumnName("wrkNo");
            this.Property(t => t.deptNo).HasColumnName("deptNo");
        }
    }
}
