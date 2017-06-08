using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class in_parkMap : EntityTypeConfiguration<in_park>
    {
        public in_parkMap()
        {
            // Primary Key
            this.HasKey(t => new { t.card_no, t.in_seq });

            // Properties
            this.Property(t => t.card_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_seq)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.carno)
                .HasMaxLength(15);

            this.Property(t => t.in_pic)
                .HasMaxLength(100);

            this.Property(t => t.@operator)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("in_park");
            this.Property(t => t.card_no).HasColumnName("card_no");
            this.Property(t => t.in_seq).HasColumnName("in_seq");
            this.Property(t => t.card_tid).HasColumnName("card_tid");
            this.Property(t => t.carno).HasColumnName("carno");
            this.Property(t => t.in_time).HasColumnName("in_time");
            this.Property(t => t.in_pic).HasColumnName("in_pic");
            this.Property(t => t.in_from).HasColumnName("in_from");
            this.Property(t => t.open_gate_mode).HasColumnName("open_gate_mode");
            this.Property(t => t.stall_in_use).HasColumnName("stall_in_use");
            this.Property(t => t.@operator).HasColumnName("operator");
            this.Property(t => t.rectype).HasColumnName("rectype");
            this.Property(t => t.park_no).HasColumnName("park_no");
            this.Property(t => t.inside_park).HasColumnName("inside_park");
            this.Property(t => t.update_time).HasColumnName("update_time");
            this.Property(t => t.isHandOver).HasColumnName("isHandOver");
        }
    }
}
