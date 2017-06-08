using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class V_Lift_Card_InfoMap : EntityTypeConfiguration<V_Lift_Card_Info>
    {
        public V_Lift_Card_InfoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.card_no, t.card_tid });

            // Properties
            this.Property(t => t.card_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cust_name)
                .HasMaxLength(20);

            this.Property(t => t.card_tid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.door_no)
                .HasMaxLength(30);

            this.Property(t => t.room_no)
                .HasMaxLength(30);

            this.Property(t => t.lift_name)
                .HasMaxLength(50);

            this.Property(t => t.allowfloor)
                .HasMaxLength(56);

            // Table & Column Mappings
            this.ToTable("V_Lift_Card_Info");
            this.Property(t => t.card_no).HasColumnName("card_no");
            this.Property(t => t.cust_name).HasColumnName("cust_name");
            this.Property(t => t.card_tid).HasColumnName("card_tid");
            this.Property(t => t.door_no).HasColumnName("door_no");
            this.Property(t => t.room_no).HasColumnName("room_no");
            this.Property(t => t.calltype).HasColumnName("calltype");
            this.Property(t => t.lift_name).HasColumnName("lift_name");
            this.Property(t => t.allowfloor).HasColumnName("allowfloor");
        }
    }
}
