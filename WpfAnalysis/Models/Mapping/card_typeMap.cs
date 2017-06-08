using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class card_typeMap : EntityTypeConfiguration<card_type>
    {
        public card_typeMap()
        {
            // Primary Key
            this.HasKey(t => t.card_tid);

            // Properties
            this.Property(t => t.card_tid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.card_tname)
                .HasMaxLength(30);

            this.Property(t => t.card_showname)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("card_type");
            this.Property(t => t.card_tid).HasColumnName("card_tid");
            this.Property(t => t.card_tname).HasColumnName("card_tname");
            this.Property(t => t.card_showname).HasColumnName("card_showname");
        }
    }
}
