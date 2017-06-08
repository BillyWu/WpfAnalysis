using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class operator_rightMap : EntityTypeConfiguration<operator_right>
    {
        public operator_rightMap()
        {
            // Primary Key
            this.HasKey(t => new { t.appid, t.operator_id, t.right_id });

            // Properties
            this.Property(t => t.appid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.operator_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.right_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("operator_right");
            this.Property(t => t.appid).HasColumnName("appid");
            this.Property(t => t.operator_id).HasColumnName("operator_id");
            this.Property(t => t.right_id).HasColumnName("right_id");
        }
    }
}
