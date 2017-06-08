using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class kq_holidayMap : EntityTypeConfiguration<kq_holiday>
    {
        public kq_holidayMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Operator)
                .HasMaxLength(10);

            this.Property(t => t.Remark)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("kq_holiday");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Holiday).HasColumnName("Holiday");
            this.Property(t => t.IsHoliday).HasColumnName("IsHoliday");
            this.Property(t => t.Operator).HasColumnName("Operator");
            this.Property(t => t.createDT).HasColumnName("createDT");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
