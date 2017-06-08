using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class kq_workQueueHMap : EntityTypeConfiguration<kq_workQueueH>
    {
        public kq_workQueueHMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("kq_workQueueH");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.wrkDate).HasColumnName("wrkDate");
            this.Property(t => t.deptNo).HasColumnName("deptNo");
            this.Property(t => t.wrkNo).HasColumnName("wrkNo");
            this.Property(t => t.wrkType).HasColumnName("wrkType");
            this.Property(t => t.IsHoliday).HasColumnName("IsHoliday");
            this.Property(t => t.wrkStart1).HasColumnName("wrkStart1");
            this.Property(t => t.wrkEnd1).HasColumnName("wrkEnd1");
            this.Property(t => t.wrkStart2).HasColumnName("wrkStart2");
            this.Property(t => t.wrkEnd2).HasColumnName("wrkEnd2");
            this.Property(t => t.wrkStart3).HasColumnName("wrkStart3");
            this.Property(t => t.wrkEnd3).HasColumnName("wrkEnd3");
        }
    }
}
