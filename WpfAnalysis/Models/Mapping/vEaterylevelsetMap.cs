using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class vEaterylevelsetMap : EntityTypeConfiguration<vEaterylevelset>
    {
        public vEaterylevelsetMap()
        {
            // Primary Key
            this.HasKey(t => new { t.编号, t.超额, t.消费方式 });

            // Properties
            this.Property(t => t.编号)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.等级)
                .HasMaxLength(20);

            this.Property(t => t.超额)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.消费方式)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("vEaterylevelset");
            this.Property(t => t.编号).HasColumnName("编号");
            this.Property(t => t.等级).HasColumnName("等级");
            this.Property(t => t.次数).HasColumnName("次数");
            this.Property(t => t.金额).HasColumnName("金额");
            this.Property(t => t.折扣).HasColumnName("折扣");
            this.Property(t => t.超额).HasColumnName("超额");
            this.Property(t => t.消费方式).HasColumnName("消费方式");
            this.Property(t => t.早餐免费次数).HasColumnName("早餐免费次数");
            this.Property(t => t.午餐免费次数).HasColumnName("午餐免费次数");
            this.Property(t => t.晚餐免费次数).HasColumnName("晚餐免费次数");
            this.Property(t => t.第一次金额).HasColumnName("第一次金额");
            this.Property(t => t.第二次金额).HasColumnName("第二次金额");
            this.Property(t => t.第三次金额).HasColumnName("第三次金额");
            this.Property(t => t.三次以后金额).HasColumnName("三次以后金额");
        }
    }
}
