using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class card_statusMap : EntityTypeConfiguration<card_status>
    {
        public card_statusMap()
        {
            // Primary Key
            this.HasKey(t => t.card_tid);

            // Properties
            this.Property(t => t.card_tid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.card_statusname)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("card_status");
            this.Property(t => t.card_tid).HasColumnName("card_tid");
            this.Property(t => t.card_statusname).HasColumnName("card_statusname");
        }
    }
}
