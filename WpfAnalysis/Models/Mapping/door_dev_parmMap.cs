using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class door_dev_parmMap : EntityTypeConfiguration<door_dev_parm>
    {
        public door_dev_parmMap()
        {
            // Primary Key
            this.HasKey(t => t.dev_id);

            // Properties
            this.Property(t => t.dev_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("door_dev_parm");
            this.Property(t => t.dev_id).HasColumnName("dev_id");
            this.Property(t => t.left_rec_alarm).HasColumnName("left_rec_alarm");
            this.Property(t => t.open_door_delay).HasColumnName("open_door_delay");
            this.Property(t => t.buzzer).HasColumnName("buzzer");
            this.Property(t => t.open_mode).HasColumnName("open_mode");
            this.Property(t => t.multi_interval).HasColumnName("multi_interval");
            this.Property(t => t.multi_num).HasColumnName("multi_num");
            this.Property(t => t.fire_alarm).HasColumnName("fire_alarm");
            this.Property(t => t.fire_delay).HasColumnName("fire_delay");
            this.Property(t => t.riot_alarm).HasColumnName("riot_alarm");
            this.Property(t => t.riot_delay).HasColumnName("riot_delay");
            this.Property(t => t.riot_close).HasColumnName("riot_close");
            this.Property(t => t.riot_card).HasColumnName("riot_card");
            this.Property(t => t.magnet).HasColumnName("magnet");
            this.Property(t => t.close_delay1).HasColumnName("close_delay1");
            this.Property(t => t.close_delay2).HasColumnName("close_delay2");
            this.Property(t => t.work_mode).HasColumnName("work_mode");
            this.Property(t => t.isdeleted).HasColumnName("isdeleted");
            this.Property(t => t.doors).HasColumnName("doors");
        }
    }
}
