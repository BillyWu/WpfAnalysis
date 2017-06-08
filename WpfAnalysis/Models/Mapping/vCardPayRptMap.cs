using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class vCardPayRptMap : EntityTypeConfiguration<vCardPayRpt>
    {
        public vCardPayRptMap()
        {
            // Primary Key
            this.HasKey(t => t.卡号);

            // Properties
            this.Property(t => t.姓名)
                .HasMaxLength(10);

            this.Property(t => t.级别)
                .HasMaxLength(20);

            this.Property(t => t.卡号)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.备注)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("vCardPayRpt");
            this.Property(t => t.姓名).HasColumnName("姓名");
            this.Property(t => t.级别).HasColumnName("级别");
            this.Property(t => t.卡号).HasColumnName("卡号");
            this.Property(t => t.充前金额).HasColumnName("充前金额");
            this.Property(t => t.充值金额).HasColumnName("充值金额");
            this.Property(t => t.充后金额).HasColumnName("充后金额");
            this.Property(t => t.充值日期).HasColumnName("充值日期");
            this.Property(t => t.有效期).HasColumnName("有效期");
            this.Property(t => t.备注).HasColumnName("备注");
        }
    }
}
