using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class VKQ_dakaHMap : EntityTypeConfiguration<VKQ_dakaH>
    {
        public VKQ_dakaHMap()
        {
            // Primary Key
            this.HasKey(t => t.IsQianka);

            // Properties
            this.Property(t => t.cust_name)
                .HasMaxLength(10);

            this.Property(t => t.deptname)
                .HasMaxLength(20);

            this.Property(t => t.IsQianka)
                .IsRequired()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("VKQ_dakaH");
            this.Property(t => t.custno).HasColumnName("custno");
            this.Property(t => t.cust_name).HasColumnName("cust_name");
            this.Property(t => t.deptno).HasColumnName("deptno");
            this.Property(t => t.dakaDt).HasColumnName("dakaDt");
            this.Property(t => t.deptname).HasColumnName("deptname");
            this.Property(t => t.IsQianka).HasColumnName("IsQianka");
        }
    }
}
