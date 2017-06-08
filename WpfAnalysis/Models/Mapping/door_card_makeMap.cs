using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class door_card_makeMap : EntityTypeConfiguration<door_card_make>
    {
        public door_card_makeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.card_no, t.cust_no });

            // Properties
            this.Property(t => t.card_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cust_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TimeNo)
                .HasMaxLength(3);

            this.Property(t => t.MachNo)
                .HasMaxLength(256);

            this.Property(t => t.DownMachNo)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("door_card_make");
            this.Property(t => t.card_no).HasColumnName("card_no");
            this.Property(t => t.cust_no).HasColumnName("cust_no");
            this.Property(t => t.CardState).HasColumnName("CardState");
            this.Property(t => t.bDate).HasColumnName("bDate");
            this.Property(t => t.eDate).HasColumnName("eDate");
            this.Property(t => t.TimeNo).HasColumnName("TimeNo");
            this.Property(t => t.MachNo).HasColumnName("MachNo");
            this.Property(t => t.DownMachNo).HasColumnName("DownMachNo");
            this.Property(t => t.FxDate).HasColumnName("FxDate");
        }
    }
}
