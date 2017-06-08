using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class vLiftRecordMap : EntityTypeConfiguration<vLiftRecord>
    {
        public vLiftRecordMap()
        {
            // Primary Key
            this.HasKey(t => new { t.card_no, t.overnumber, t.cardtime, t.readtime });

            // Properties
            this.Property(t => t.card_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cust_name)
                .HasMaxLength(20);

            this.Property(t => t.lift_name)
                .HasMaxLength(50);

            this.Property(t => t.overnumber)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vLiftRecord");
            this.Property(t => t.card_no).HasColumnName("card_no");
            this.Property(t => t.cust_name).HasColumnName("cust_name");
            this.Property(t => t.lift_name).HasColumnName("lift_name");
            this.Property(t => t.overnumber).HasColumnName("overnumber");
            this.Property(t => t.cardtime).HasColumnName("cardtime");
            this.Property(t => t.readtime).HasColumnName("readtime");
        }
    }
}
