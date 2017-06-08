using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class vcustomerMap : EntityTypeConfiguration<vcustomer>
    {
        public vcustomerMap()
        {
            // Primary Key
            this.HasKey(t => new { t.编号, t.性别 });

            // Properties
            this.Property(t => t.编号)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.姓名)
                .HasMaxLength(10);

            this.Property(t => t.级别)
                .HasMaxLength(20);

            this.Property(t => t.性别)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.昵称)
                .HasMaxLength(10);

            this.Property(t => t.电话)
                .HasMaxLength(15);

            this.Property(t => t.手机)
                .HasMaxLength(15);

            this.Property(t => t.卡号)
                .HasMaxLength(18);

            this.Property(t => t.地址)
                .HasMaxLength(60);

            this.Property(t => t.操作者)
                .HasMaxLength(10);

            this.Property(t => t.备注)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("vcustomer");
            this.Property(t => t.编号).HasColumnName("编号");
            this.Property(t => t.姓名).HasColumnName("姓名");
            this.Property(t => t.级别).HasColumnName("级别");
            this.Property(t => t.性别).HasColumnName("性别");
            this.Property(t => t.昵称).HasColumnName("昵称");
            this.Property(t => t.电话).HasColumnName("电话");
            this.Property(t => t.手机).HasColumnName("手机");
            this.Property(t => t.卡号).HasColumnName("卡号");
            this.Property(t => t.地址).HasColumnName("地址");
            this.Property(t => t.操作者).HasColumnName("操作者");
            this.Property(t => t.日期).HasColumnName("日期");
            this.Property(t => t.备注).HasColumnName("备注");
        }
    }
}
