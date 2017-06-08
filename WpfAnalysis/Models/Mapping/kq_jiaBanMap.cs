using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class kq_jiaBanMap : EntityTypeConfiguration<kq_jiaBan>
    {
        public kq_jiaBanMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Operator)
                .HasMaxLength(10);

            this.Property(t => t.Remark)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("kq_jiaBan");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.custNo).HasColumnName("custNo");
            this.Property(t => t.startDT).HasColumnName("startDT");
            this.Property(t => t.endDT).HasColumnName("endDT");
            this.Property(t => t.howTime).HasColumnName("howTime");
            this.Property(t => t.Operator).HasColumnName("Operator");
            this.Property(t => t.createDT).HasColumnName("createDT");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
