using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class kq_huiZongHMap : EntityTypeConfiguration<kq_huiZongH>
    {
        public kq_huiZongHMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("kq_huiZongH");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.riqi).HasColumnName("riqi");
            this.Property(t => t.custNo).HasColumnName("custNo");
            this.Property(t => t.deptNO).HasColumnName("deptNO");
            this.Property(t => t.wrkNO).HasColumnName("wrkNO");
            this.Property(t => t.actDays).HasColumnName("actDays");
            this.Property(t => t.wrkDays).HasColumnName("wrkDays");
            this.Property(t => t.ciDao).HasColumnName("ciDao");
            this.Property(t => t.zaoTui).HasColumnName("zaoTui");
            this.Property(t => t.JiaBan).HasColumnName("JiaBan");
            this.Property(t => t.kuangGong).HasColumnName("kuangGong");
            this.Property(t => t.qinJia).HasColumnName("qinJia");
            this.Property(t => t.chuCai).HasColumnName("chuCai");
            this.Property(t => t.ciDao2).HasColumnName("ciDao2");
            this.Property(t => t.zaoTui2).HasColumnName("zaoTui2");
            this.Property(t => t.kuangGong2).HasColumnName("kuangGong2");
        }
    }
}
