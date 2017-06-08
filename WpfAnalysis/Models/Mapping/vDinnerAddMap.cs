using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class vDinnerAddMap : EntityTypeConfiguration<vDinnerAdd>
    {
        public vDinnerAddMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.名称)
                .HasMaxLength(30);

            this.Property(t => t.星期)
                .HasMaxLength(10);

            this.Property(t => t.早餐开始时间)
                .HasMaxLength(5);

            this.Property(t => t.早餐结束时间)
                .HasMaxLength(5);

            this.Property(t => t.午餐开始时间)
                .HasMaxLength(5);

            this.Property(t => t.午餐结束时间)
                .HasMaxLength(5);

            this.Property(t => t.晚餐开始时间)
                .HasMaxLength(5);

            this.Property(t => t.晚餐结束时间)
                .HasMaxLength(5);

            this.Property(t => t.操作者)
                .HasMaxLength(10);

            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vDinnerAdd");
            this.Property(t => t.编号).HasColumnName("编号");
            this.Property(t => t.名称).HasColumnName("名称");
            this.Property(t => t.星期).HasColumnName("星期");
            this.Property(t => t.早餐开始时间).HasColumnName("早餐开始时间");
            this.Property(t => t.早餐结束时间).HasColumnName("早餐结束时间");
            this.Property(t => t.午餐开始时间).HasColumnName("午餐开始时间");
            this.Property(t => t.午餐结束时间).HasColumnName("午餐结束时间");
            this.Property(t => t.晚餐开始时间).HasColumnName("晚餐开始时间");
            this.Property(t => t.晚餐结束时间).HasColumnName("晚餐结束时间");
            this.Property(t => t.早餐补助).HasColumnName("早餐补助");
            this.Property(t => t.午餐补助).HasColumnName("午餐补助");
            this.Property(t => t.晚餐补助).HasColumnName("晚餐补助");
            this.Property(t => t.操作者).HasColumnName("操作者");
            this.Property(t => t.操作时间).HasColumnName("操作时间");
            this.Property(t => t.id).HasColumnName("id");
        }
    }
}
