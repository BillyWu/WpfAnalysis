using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class xg_nodeMap : EntityTypeConfiguration<xg_node>
    {
        public xg_nodeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.node_no, t.line_no });

            // Properties
            this.Property(t => t.node_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.node_name)
                .HasMaxLength(50);

            this.Property(t => t.door_sn)
                .HasMaxLength(10);

            this.Property(t => t.door_readno)
                .HasMaxLength(2);

            this.Property(t => t.line_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("xg_node");
            this.Property(t => t.node_no).HasColumnName("node_no");
            this.Property(t => t.node_name).HasColumnName("node_name");
            this.Property(t => t.door_sn).HasColumnName("door_sn");
            this.Property(t => t.door_readno).HasColumnName("door_readno");
            this.Property(t => t.line_no).HasColumnName("line_no");
        }
    }
}
