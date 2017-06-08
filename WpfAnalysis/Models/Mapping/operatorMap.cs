using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class operatorMap : EntityTypeConfiguration<operator1>
    {
        public operatorMap()
        {
            // Primary Key
            this.HasKey(t => t.op_code);

            // Properties
            this.Property(t => t.op_code)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.op_name)
                .HasMaxLength(10);

            this.Property(t => t.op_pass)
                .HasMaxLength(20);

            this.Property(t => t.remark)
                .HasMaxLength(60);

            this.Property(t => t.creator)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("operator");
            this.Property(t => t.op_code).HasColumnName("op_code");
            this.Property(t => t.op_name).HasColumnName("op_name");
            this.Property(t => t.op_pass).HasColumnName("op_pass");
            this.Property(t => t.op_cardno).HasColumnName("op_cardno");
            this.Property(t => t.remark).HasColumnName("remark");
            this.Property(t => t.creator).HasColumnName("creator");
            this.Property(t => t.creatdt).HasColumnName("creatdt");
            this.Property(t => t.deptno).HasColumnName("deptno");
        }
    }
}
