using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class lift_recordMap : EntityTypeConfiguration<lift_record>
    {
        public lift_recordMap()
        {
            // Primary Key
            this.HasKey(t => new { t.card_no, t.lift_no, t.overnumber, t.cardtime, t.readtime });

            // Properties
            this.Property(t => t.card_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.lift_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.overnumber)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("lift_record");
            this.Property(t => t.card_no).HasColumnName("card_no");
            this.Property(t => t.lift_no).HasColumnName("lift_no");
            this.Property(t => t.overnumber).HasColumnName("overnumber");
            this.Property(t => t.cardtime).HasColumnName("cardtime");
            this.Property(t => t.readtime).HasColumnName("readtime");
        }
    }
}
