using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class V_controldefine1Map : EntityTypeConfiguration<V_controldefine1>
    {
        public V_controldefine1Map()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.SN, t.ReadNo, t.xPos, t.yPos, t.IsKq });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SN)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ReadNo)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.DoorName)
                .HasMaxLength(50);

            this.Property(t => t.IP)
                .HasMaxLength(15);

            this.Property(t => t.Port)
                .HasMaxLength(10);

            this.Property(t => t.Watch)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.xPos)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.yPos)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsKq)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("V_controldefine1");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SN).HasColumnName("SN");
            this.Property(t => t.ControlNo).HasColumnName("ControlNo");
            this.Property(t => t.ReadNo).HasColumnName("ReadNo");
            this.Property(t => t.DoorName).HasColumnName("DoorName");
            this.Property(t => t.stallno).HasColumnName("stallno");
            this.Property(t => t.IP).HasColumnName("IP");
            this.Property(t => t.Port).HasColumnName("Port");
            this.Property(t => t.Watch).HasColumnName("Watch");
            this.Property(t => t.xPos).HasColumnName("xPos");
            this.Property(t => t.yPos).HasColumnName("yPos");
            this.Property(t => t.IsKq).HasColumnName("IsKq");
        }
    }
}
