using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class VKQ_deptWorkMap : EntityTypeConfiguration<VKQ_deptWork>
    {
        public VKQ_deptWorkMap()
        {
            // Primary Key
            this.HasKey(t => new { t.deptno, t.wrkNo });

            // Properties
            this.Property(t => t.deptno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.deptName)
                .HasMaxLength(20);

            this.Property(t => t.wrkNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.wrkName)
                .HasMaxLength(20);

            this.Property(t => t.wrkStart1)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.wrkStart2)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.wrkEnd1)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.wrkEnd2)
                .IsFixedLength()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("VKQ_deptWork");
            this.Property(t => t.deptno).HasColumnName("deptno");
            this.Property(t => t.deptName).HasColumnName("deptName");
            this.Property(t => t.wrkNo).HasColumnName("wrkNo");
            this.Property(t => t.wrkName).HasColumnName("wrkName");
            this.Property(t => t.wrkStart1).HasColumnName("wrkStart1");
            this.Property(t => t.wrkStart2).HasColumnName("wrkStart2");
            this.Property(t => t.wrkEnd1).HasColumnName("wrkEnd1");
            this.Property(t => t.wrkEnd2).HasColumnName("wrkEnd2");
            this.Property(t => t.wrkTime).HasColumnName("wrkTime");
            this.Property(t => t.wrkType).HasColumnName("wrkType");
        }
    }
}
