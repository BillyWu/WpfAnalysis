using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class vDeviceTimeMap : EntityTypeConfiguration<vDeviceTime>
    {
        public vDeviceTimeMap()
        {
            // Primary Key
            this.HasKey(t => t.星期);

            // Properties
            this.Property(t => t.星期)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.开始1)
                .HasMaxLength(5);

            this.Property(t => t.结束1)
                .HasMaxLength(5);

            this.Property(t => t.开始2)
                .HasMaxLength(5);

            this.Property(t => t.结束2)
                .HasMaxLength(5);

            this.Property(t => t.开始3)
                .HasMaxLength(5);

            this.Property(t => t.结束3)
                .HasMaxLength(5);

            this.Property(t => t.开始4)
                .HasMaxLength(5);

            this.Property(t => t.结束4)
                .HasMaxLength(5);

            this.Property(t => t.开始5)
                .HasMaxLength(5);

            this.Property(t => t.结束5)
                .HasMaxLength(5);

            this.Property(t => t.开始6)
                .HasMaxLength(5);

            this.Property(t => t.结束6)
                .HasMaxLength(5);

            this.Property(t => t.开始7)
                .HasMaxLength(5);

            this.Property(t => t.结束7)
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("vDeviceTime");
            this.Property(t => t.序号).HasColumnName("序号");
            this.Property(t => t.星期).HasColumnName("星期");
            this.Property(t => t.开始时间).HasColumnName("开始时间");
            this.Property(t => t.结束时间).HasColumnName("结束时间");
            this.Property(t => t.开始1).HasColumnName("开始1");
            this.Property(t => t.结束1).HasColumnName("结束1");
            this.Property(t => t.开始2).HasColumnName("开始2");
            this.Property(t => t.结束2).HasColumnName("结束2");
            this.Property(t => t.开始3).HasColumnName("开始3");
            this.Property(t => t.结束3).HasColumnName("结束3");
            this.Property(t => t.开始4).HasColumnName("开始4");
            this.Property(t => t.结束4).HasColumnName("结束4");
            this.Property(t => t.开始5).HasColumnName("开始5");
            this.Property(t => t.结束5).HasColumnName("结束5");
            this.Property(t => t.开始6).HasColumnName("开始6");
            this.Property(t => t.结束6).HasColumnName("结束6");
            this.Property(t => t.开始7).HasColumnName("开始7");
            this.Property(t => t.结束7).HasColumnName("结束7");
        }
    }
}
