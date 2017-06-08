using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class xg_planMap : EntityTypeConfiguration<xg_plan>
    {
        public xg_planMap()
        {
            // Primary Key
            this.HasKey(t => new { t.plan_no, t.line_no });

            // Properties
            this.Property(t => t.plan_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.line_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("xg_plan");
            this.Property(t => t.plan_no).HasColumnName("plan_no");
            this.Property(t => t.line_no).HasColumnName("line_no");
            this.Property(t => t.Start_dt).HasColumnName("Start_dt");
            this.Property(t => t.End_dt).HasColumnName("End_dt");
            this.Property(t => t.IsSeq).HasColumnName("IsSeq");
        }
    }
}
