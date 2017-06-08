using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class vCardLostRptMap : EntityTypeConfiguration<vCardLostRpt>
    {
        public vCardLostRptMap()
        {
            // Primary Key
            this.HasKey(t => new { t.卡号, t.操作类别 });

            // Properties
            this.Property(t => t.姓名)
                .HasMaxLength(10);

            this.Property(t => t.级别)
                .HasMaxLength(20);

            this.Property(t => t.卡号)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.操作类别)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.备注)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("vCardLostRpt");
            this.Property(t => t.姓名).HasColumnName("姓名");
            this.Property(t => t.级别).HasColumnName("级别");
            this.Property(t => t.卡号).HasColumnName("卡号");
            this.Property(t => t.操作类别).HasColumnName("操作类别");
            this.Property(t => t.卡上余额).HasColumnName("卡上余额");
            this.Property(t => t.有效期).HasColumnName("有效期");
            this.Property(t => t.操作日期).HasColumnName("操作日期");
            this.Property(t => t.备注).HasColumnName("备注");
        }
    }
}
