using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class V_Lift_RecordMap : EntityTypeConfiguration<V_Lift_Record>
    {
        public V_Lift_RecordMap()
        {
            // Primary Key
            this.HasKey(t => new { t.用户编号, t.卡号, t.电梯, t.刷卡时间, t.读取时间, t.剩余使用次数, t.卡型 });

            // Properties
            this.Property(t => t.姓名)
                .HasMaxLength(20);

            this.Property(t => t.用户编号)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.部门)
                .HasMaxLength(20);

            this.Property(t => t.卡号)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.电梯)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.门牌号)
                .HasMaxLength(30);

            this.Property(t => t.房间号)
                .HasMaxLength(30);

            this.Property(t => t.剩余使用次数)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.卡型)
                .IsRequired()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("V_Lift_Record");
            this.Property(t => t.姓名).HasColumnName("姓名");
            this.Property(t => t.用户编号).HasColumnName("用户编号");
            this.Property(t => t.部门).HasColumnName("部门");
            this.Property(t => t.卡号).HasColumnName("卡号");
            this.Property(t => t.电梯).HasColumnName("电梯");
            this.Property(t => t.门牌号).HasColumnName("门牌号");
            this.Property(t => t.房间号).HasColumnName("房间号");
            this.Property(t => t.刷卡时间).HasColumnName("刷卡时间");
            this.Property(t => t.读取时间).HasColumnName("读取时间");
            this.Property(t => t.剩余使用次数).HasColumnName("剩余使用次数");
            this.Property(t => t.卡型).HasColumnName("卡型");
        }
    }
}
