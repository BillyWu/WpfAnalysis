using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class M_TimeTaskMap : EntityTypeConfiguration<M_TimeTask>
    {
        public M_TimeTaskMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.devID)
                .HasMaxLength(4000);

            this.Property(t => t.taskDT)
                .HasMaxLength(5);

            this.Property(t => t.taskTime)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("M_TimeTask");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.devID).HasColumnName("devID");
            this.Property(t => t.taskDT).HasColumnName("taskDT");
            this.Property(t => t.taskTime).HasColumnName("taskTime");
            this.Property(t => t.weekDy).HasColumnName("weekDy");
            this.Property(t => t.Type).HasColumnName("Type");
        }
    }
}
