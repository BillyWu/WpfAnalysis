using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class VKQ_mingxiHMap : EntityTypeConfiguration<VKQ_mingxiH>
    {
        public VKQ_mingxiHMap()
        {
            // Primary Key
            this.HasKey(t => new { t.type, t.Holiday });

            // Properties
            this.Property(t => t.cust_name)
                .HasMaxLength(10);

            this.Property(t => t.deptname)
                .HasMaxLength(20);

            this.Property(t => t.dt)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.type)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Holiday)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.s1)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.e1)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.s2)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.e2)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.jb_s)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.jb_e)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.wrkname)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("VKQ_mingxiH");
            this.Property(t => t.custNo).HasColumnName("custNo");
            this.Property(t => t.cust_name).HasColumnName("cust_name");
            this.Property(t => t.deptname).HasColumnName("deptname");
            this.Property(t => t.dt).HasColumnName("dt");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.Holiday).HasColumnName("Holiday");
            this.Property(t => t.s1).HasColumnName("s1");
            this.Property(t => t.e1).HasColumnName("e1");
            this.Property(t => t.s2).HasColumnName("s2");
            this.Property(t => t.e2).HasColumnName("e2");
            this.Property(t => t.jb_s).HasColumnName("jb_s");
            this.Property(t => t.jb_e).HasColumnName("jb_e");
            this.Property(t => t.cidao).HasColumnName("cidao");
            this.Property(t => t.zaotui).HasColumnName("zaotui");
            this.Property(t => t.kg).HasColumnName("kg");
            this.Property(t => t.jb).HasColumnName("jb");
            this.Property(t => t.qj).HasColumnName("qj");
            this.Property(t => t.cc).HasColumnName("cc");
            this.Property(t => t.wrkname).HasColumnName("wrkname");
            this.Property(t => t.wrkDate).HasColumnName("wrkDate");
            this.Property(t => t.deptno).HasColumnName("deptno");
            this.Property(t => t.wrkno).HasColumnName("wrkno");
            this.Property(t => t.wrktype).HasColumnName("wrktype");
            this.Property(t => t.isHoliday).HasColumnName("isHoliday");
        }
    }
}
