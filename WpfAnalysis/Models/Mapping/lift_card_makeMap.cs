using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class lift_card_makeMap : EntityTypeConfiguration<lift_card_make>
    {
        public lift_card_makeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.card_no, t.cust_no, t.card_tid });

            // Properties
            this.Property(t => t.card_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cust_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.card_tid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.door_no)
                .HasMaxLength(30);

            this.Property(t => t.room_no)
                .HasMaxLength(30);

            this.Property(t => t.allowlift)
                .HasMaxLength(30);

            this.Property(t => t.allowfloor)
                .HasMaxLength(168);

            this.Property(t => t.allowlift2)
                .HasMaxLength(30);

            this.Property(t => t.allowfloor2)
                .HasMaxLength(168);

            this.Property(t => t.allowlift3)
                .HasMaxLength(30);

            this.Property(t => t.allowfloor3)
                .IsFixedLength()
                .HasMaxLength(168);

            this.Property(t => t.weekStr)
                .HasMaxLength(7);

            // Table & Column Mappings
            this.ToTable("lift_card_make");
            this.Property(t => t.card_no).HasColumnName("card_no");
            this.Property(t => t.cust_no).HasColumnName("cust_no");
            this.Property(t => t.card_tid).HasColumnName("card_tid");
            this.Property(t => t.door_no).HasColumnName("door_no");
            this.Property(t => t.room_no).HasColumnName("room_no");
            this.Property(t => t.calltype).HasColumnName("calltype");
            this.Property(t => t.allowlift).HasColumnName("allowlift");
            this.Property(t => t.allowfloor).HasColumnName("allowfloor");
            this.Property(t => t.allowlift2).HasColumnName("allowlift2");
            this.Property(t => t.allowfloor2).HasColumnName("allowfloor2");
            this.Property(t => t.allowlift3).HasColumnName("allowlift3");
            this.Property(t => t.allowfloor3).HasColumnName("allowfloor3");
            this.Property(t => t.floorPrice).HasColumnName("floorPrice");
            this.Property(t => t.startDate).HasColumnName("startDate");
            this.Property(t => t.endDate).HasColumnName("endDate");
            this.Property(t => t.startTime).HasColumnName("startTime");
            this.Property(t => t.endTime).HasColumnName("endTime");
            this.Property(t => t.weekStr).HasColumnName("weekStr");
        }
    }
}
