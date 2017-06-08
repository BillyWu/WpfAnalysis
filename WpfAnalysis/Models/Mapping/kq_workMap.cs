using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class kq_workMap : EntityTypeConfiguration<kq_work>
    {
        public kq_workMap()
        {
            // Primary Key
            this.HasKey(t => t.wrkNo);

            // Properties
            this.Property(t => t.wrkName)
                .HasMaxLength(20);

            this.Property(t => t.wrkStart1)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.wrkEnd1)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.wrkStart2)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.wrkEnd2)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.wrkStart3)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.wrkEnd3)
                .IsFixedLength()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("kq_work");
            this.Property(t => t.wrkNo).HasColumnName("wrkNo");
            this.Property(t => t.wrkName).HasColumnName("wrkName");
            this.Property(t => t.wrkType).HasColumnName("wrkType");
            this.Property(t => t.wrkStart1).HasColumnName("wrkStart1");
            this.Property(t => t.wrkEnd1).HasColumnName("wrkEnd1");
            this.Property(t => t.wrkStart2).HasColumnName("wrkStart2");
            this.Property(t => t.wrkEnd2).HasColumnName("wrkEnd2");
            this.Property(t => t.wrkStart3).HasColumnName("wrkStart3");
            this.Property(t => t.wrkEnd3).HasColumnName("wrkEnd3");
            this.Property(t => t.wrkTime).HasColumnName("wrkTime");
        }
    }
}
