using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class vEateryDinnerMap : EntityTypeConfiguration<vEateryDinner>
    {
        public vEateryDinnerMap()
        {
            // Primary Key
            this.HasKey(t => t.编号);

            // Properties
            this.Property(t => t.编号)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.名称)
                .HasMaxLength(30);

            this.Property(t => t.操作者)
                .HasMaxLength(10);

            this.Property(t => t.备注)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("vEateryDinner");
            this.Property(t => t.编号).HasColumnName("编号");
            this.Property(t => t.名称).HasColumnName("名称");
            this.Property(t => t.操作者).HasColumnName("操作者");
            this.Property(t => t.操作时间).HasColumnName("操作时间");
            this.Property(t => t.备注).HasColumnName("备注");
        }
    }
}
