using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class vDeviceMap : EntityTypeConfiguration<vDevice>
    {
        public vDeviceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.编号, t.设备类型 });

            // Properties
            this.Property(t => t.编号)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.名称)
                .HasMaxLength(30);

            this.Property(t => t.电脑)
                .HasMaxLength(50);

            this.Property(t => t.餐厅)
                .HasMaxLength(30);

            this.Property(t => t.设备类型)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.操作者)
                .HasMaxLength(10);

            this.Property(t => t.备注)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("vDevice");
            this.Property(t => t.编号).HasColumnName("编号");
            this.Property(t => t.名称).HasColumnName("名称");
            this.Property(t => t.电脑).HasColumnName("电脑");
            this.Property(t => t.餐厅).HasColumnName("餐厅");
            this.Property(t => t.设备类型).HasColumnName("设备类型");
            this.Property(t => t.设备地址).HasColumnName("设备地址");
            this.Property(t => t.操作者).HasColumnName("操作者");
            this.Property(t => t.操作时间).HasColumnName("操作时间");
            this.Property(t => t.备注).HasColumnName("备注");
        }
    }
}
