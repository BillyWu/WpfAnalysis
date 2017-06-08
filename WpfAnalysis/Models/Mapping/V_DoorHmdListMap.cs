using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class V_DoorHmdListMap : EntityTypeConfiguration<V_DoorHmdList>
    {
        public V_DoorHmdListMap()
        {
            // Primary Key
            this.HasKey(t => new { t.flag, t.SN, t.ReadNo });

            // Properties
            this.Property(t => t.cust_nick)
                .HasMaxLength(10);

            this.Property(t => t.cust_name)
                .HasMaxLength(10);

            this.Property(t => t.flag)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.SN)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ReadNo)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.DoorName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("V_DoorHmdList");
            this.Property(t => t.card_no).HasColumnName("card_no");
            this.Property(t => t.cust_nick).HasColumnName("cust_nick");
            this.Property(t => t.cust_name).HasColumnName("cust_name");
            this.Property(t => t.flag).HasColumnName("flag");
            this.Property(t => t.bDate).HasColumnName("bDate");
            this.Property(t => t.eDate).HasColumnName("eDate");
            this.Property(t => t.TimeNo).HasColumnName("TimeNo");
            this.Property(t => t.devID).HasColumnName("devID");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.SN).HasColumnName("SN");
            this.Property(t => t.ReadNo).HasColumnName("ReadNo");
            this.Property(t => t.DoorName).HasColumnName("DoorName");
        }
    }
}
