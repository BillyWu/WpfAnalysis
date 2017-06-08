using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class vCustCard3Map : EntityTypeConfiguration<vCustCard3>
    {
        public vCustCard3Map()
        {
            // Primary Key
            this.HasKey(t => new { t.用户编号, t.性别, t.类型, t.卡号, t.状态, t.押金, t.金额, t.有效期 });

            // Properties
            this.Property(t => t.用户编号)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.姓名)
                .HasMaxLength(10);

            this.Property(t => t.昵称)
                .HasMaxLength(10);

            this.Property(t => t.性别)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.类型)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.级别)
                .HasMaxLength(20);

            this.Property(t => t.手机)
                .HasMaxLength(15);

            this.Property(t => t.地址)
                .HasMaxLength(60);

            this.Property(t => t.卡号)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.状态)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.押金)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.金额)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vCustCard3");
            this.Property(t => t.用户编号).HasColumnName("用户编号");
            this.Property(t => t.姓名).HasColumnName("姓名");
            this.Property(t => t.昵称).HasColumnName("昵称");
            this.Property(t => t.性别).HasColumnName("性别");
            this.Property(t => t.类型).HasColumnName("类型");
            this.Property(t => t.级别).HasColumnName("级别");
            this.Property(t => t.手机).HasColumnName("手机");
            this.Property(t => t.地址).HasColumnName("地址");
            this.Property(t => t.卡号).HasColumnName("卡号");
            this.Property(t => t.状态).HasColumnName("状态");
            this.Property(t => t.押金).HasColumnName("押金");
            this.Property(t => t.金额).HasColumnName("金额");
            this.Property(t => t.有效期).HasColumnName("有效期");
        }
    }
}
