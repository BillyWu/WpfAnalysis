using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class M_ContrlNoMap : EntityTypeConfiguration<M_ContrlNo>
    {
        public M_ContrlNoMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("M_ContrlNo");
            this.Property(t => t.id).HasColumnName("id");
        }
    }
}
