using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class vRealControlMap : EntityTypeConfiguration<vRealControl>
    {
        public vRealControlMap()
        {
            // Primary Key
            this.HasKey(t => new { t.是否启用, t.设备时间, t.通迅状态, t.当日补助, t.devno, t.cmpno, t.dinno });

            // Properties
            this.Property(t => t.餐厅名称)
                .HasMaxLength(30);

            this.Property(t => t.设备名称)
                .HasMaxLength(30);

            this.Property(t => t.是否启用)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.设备时间)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.通迅状态)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.当日补助)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.devno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cmpno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.dinno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cmpname)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("vRealControl");
            this.Property(t => t.餐厅名称).HasColumnName("餐厅名称");
            this.Property(t => t.设备名称).HasColumnName("设备名称");
            this.Property(t => t.设备地址).HasColumnName("设备地址");
            this.Property(t => t.是否启用).HasColumnName("是否启用");
            this.Property(t => t.设备时间).HasColumnName("设备时间");
            this.Property(t => t.通迅状态).HasColumnName("通迅状态");
            this.Property(t => t.当日补助).HasColumnName("当日补助");
            this.Property(t => t.devno).HasColumnName("devno");
            this.Property(t => t.cmpno).HasColumnName("cmpno");
            this.Property(t => t.dinno).HasColumnName("dinno");
            this.Property(t => t.cmpname).HasColumnName("cmpname");
            this.Property(t => t.devaddr).HasColumnName("devaddr");
        }
    }
}
