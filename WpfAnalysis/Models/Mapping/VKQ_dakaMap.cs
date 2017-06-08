using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class VKQ_dakaMap : EntityTypeConfiguration<VKQ_daka>
    {
        public VKQ_dakaMap()
        {
            // Primary Key
            this.HasKey(t => t.IsQianka);

            // Properties
            this.Property(t => t.cust_name)
                .HasMaxLength(20);

            this.Property(t => t.deptName)
                .HasMaxLength(20);

            this.Property(t => t.IsQianka)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.doorName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VKQ_daka");
            this.Property(t => t.custNo).HasColumnName("custNo");
            this.Property(t => t.cust_name).HasColumnName("cust_name");
            this.Property(t => t.deptNo).HasColumnName("deptNo");
            this.Property(t => t.daKaDT).HasColumnName("daKaDT");
            this.Property(t => t.deptName).HasColumnName("deptName");
            this.Property(t => t.IsQianka).HasColumnName("IsQianka");
            this.Property(t => t.doorName).HasColumnName("doorName");
        }
    }
}
