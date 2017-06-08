using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class kq_deptMap : EntityTypeConfiguration<kq_dept>
    {
        public kq_deptMap()
        {
            // Primary Key
            this.HasKey(t => t.deptNo);

            // Properties
            this.Property(t => t.deptName)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("kq_dept");
            this.Property(t => t.deptNo).HasColumnName("deptNo");
            this.Property(t => t.parentNo).HasColumnName("parentNo");
            this.Property(t => t.deptName).HasColumnName("deptName");
        }
    }
}
