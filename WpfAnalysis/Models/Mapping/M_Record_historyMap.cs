using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class M_Record_historyMap : EntityTypeConfiguration<M_Record_history>
    {
        public M_Record_historyMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CardNo)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Cust_nick)
                .HasMaxLength(10);

            this.Property(t => t.Cust_name)
                .HasMaxLength(10);

            this.Property(t => t.State)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.SN)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ControlNo)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ReadNo)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.DoorName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("M_Record_history");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.Cust_nick).HasColumnName("Cust_nick");
            this.Property(t => t.Cust_name).HasColumnName("Cust_name");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.SN).HasColumnName("SN");
            this.Property(t => t.ControlNo).HasColumnName("ControlNo");
            this.Property(t => t.ReadNo).HasColumnName("ReadNo");
            this.Property(t => t.DoorName).HasColumnName("DoorName");
            this.Property(t => t.KaiTime).HasColumnName("KaiTime");
        }
    }
}
