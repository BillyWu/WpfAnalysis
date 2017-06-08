using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class kq_mingXiHMap : EntityTypeConfiguration<kq_mingXiH>
    {
        public kq_mingXiHMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("kq_mingXiH");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.wrkDate).HasColumnName("wrkDate");
            this.Property(t => t.deptNo).HasColumnName("deptNo");
            this.Property(t => t.custNo).HasColumnName("custNo");
            this.Property(t => t.wrkNo).HasColumnName("wrkNo");
            this.Property(t => t.wrkType).HasColumnName("wrkType");
            this.Property(t => t.IsHoliday).HasColumnName("IsHoliday");
            this.Property(t => t.wrkStart1).HasColumnName("wrkStart1");
            this.Property(t => t.wrkEnd1).HasColumnName("wrkEnd1");
            this.Property(t => t.wrkStart2).HasColumnName("wrkStart2");
            this.Property(t => t.wrkEnd2).HasColumnName("wrkEnd2");
            this.Property(t => t.wrkStart3).HasColumnName("wrkStart3");
            this.Property(t => t.wrkEnd3).HasColumnName("wrkEnd3");
            this.Property(t => t.JB_Start).HasColumnName("JB_Start");
            this.Property(t => t.JB_End).HasColumnName("JB_End");
            this.Property(t => t.ciDao).HasColumnName("ciDao");
            this.Property(t => t.zaoTui).HasColumnName("zaoTui");
            this.Property(t => t.kuangGong).HasColumnName("kuangGong");
            this.Property(t => t.JiaBan).HasColumnName("JiaBan");
            this.Property(t => t.qinJia).HasColumnName("qinJia");
            this.Property(t => t.chuCai).HasColumnName("chuCai");
            this.Property(t => t.ciDao2).HasColumnName("ciDao2");
            this.Property(t => t.zaoTui2).HasColumnName("zaoTui2");
            this.Property(t => t.kuangGong2).HasColumnName("kuangGong2");
        }
    }
}
