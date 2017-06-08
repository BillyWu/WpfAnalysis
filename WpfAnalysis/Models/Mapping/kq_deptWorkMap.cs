using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class kq_deptWorkMap : EntityTypeConfiguration<kq_deptWork>
    {
        public kq_deptWorkMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("kq_deptWork");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.deptNo).HasColumnName("deptNo");
            this.Property(t => t.wrkNo).HasColumnName("wrkNo");
        }
    }
}
