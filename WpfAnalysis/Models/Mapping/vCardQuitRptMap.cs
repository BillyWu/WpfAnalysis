using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class vCardQuitRptMap : EntityTypeConfiguration<vCardQuitRpt>
    {
        public vCardQuitRptMap()
        {
            // Primary Key
            this.HasKey(t => new { t.卡号, t.姓名, t.退还方式 });

            // Properties
            this.Property(t => t.卡号)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.姓名)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.退还方式)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.备注)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("vCardQuitRpt");
            this.Property(t => t.卡号).HasColumnName("卡号");
            this.Property(t => t.姓名).HasColumnName("姓名");
            this.Property(t => t.押金).HasColumnName("押金");
            this.Property(t => t.卡上余额).HasColumnName("卡上余额");
            this.Property(t => t.退还金额).HasColumnName("退还金额");
            this.Property(t => t.退还方式).HasColumnName("退还方式");
            this.Property(t => t.操作日期).HasColumnName("操作日期");
            this.Property(t => t.备注).HasColumnName("备注");
        }
    }
}
