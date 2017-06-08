using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class xg_plan_detailMap : EntityTypeConfiguration<xg_plan_detail>
    {
        public xg_plan_detailMap()
        {
            // Primary Key
            this.HasKey(t => t.plan_no);

            // Properties
            this.Property(t => t.plan_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.door_sn)
                .HasMaxLength(10);

            this.Property(t => t.node_name)
                .HasMaxLength(50);

            this.Property(t => t.door_readno)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("xg_plan_detail");
            this.Property(t => t.plan_no).HasColumnName("plan_no");
            this.Property(t => t.line_no).HasColumnName("line_no");
            this.Property(t => t.node_no).HasColumnName("node_no");
            this.Property(t => t.door_sn).HasColumnName("door_sn");
            this.Property(t => t.node_name).HasColumnName("node_name");
            this.Property(t => t.door_readno).HasColumnName("door_readno");
            this.Property(t => t.Start_dt).HasColumnName("Start_dt");
            this.Property(t => t.End_dt).HasColumnName("End_dt");
        }
    }
}
