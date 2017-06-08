using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class M_ControlDefineMap : EntityTypeConfiguration<M_ControlDefine>
    {
        public M_ControlDefineMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SN, t.ReadNo });

            // Properties
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

            this.Property(t => t.Pwd)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("M_ControlDefine");
            this.Property(t => t.SN).HasColumnName("SN");
            this.Property(t => t.ControlNo).HasColumnName("ControlNo");
            this.Property(t => t.ReadNo).HasColumnName("ReadNo");
            this.Property(t => t.DoorName).HasColumnName("DoorName");
            this.Property(t => t.IP).HasColumnName("IP");
            this.Property(t => t.Port).HasColumnName("Port");
            this.Property(t => t.Watch).HasColumnName("Watch");
            this.Property(t => t.xPos).HasColumnName("xPos");
            this.Property(t => t.yPos).HasColumnName("yPos");
            this.Property(t => t.IsKq).HasColumnName("IsKq");
            this.Property(t => t.StallNO).HasColumnName("StallNO");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Pwd).HasColumnName("Pwd");
            this.Property(t => t.id).HasColumnName("id");
        }
    }
}
