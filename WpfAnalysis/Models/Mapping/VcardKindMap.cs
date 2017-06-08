using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class VcardKindMap : EntityTypeConfiguration<VcardKind>
    {
        public VcardKindMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MonthCard, t.RentCard, t.TempCard, t.FreeCard, t.TempFreeCard, t.VisCard });

            // Properties
            this.Property(t => t.MonthCard)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RentCard)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TempCard)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FreeCard)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TempFreeCard)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VisCard)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VcardKind");
            this.Property(t => t.MonthCard).HasColumnName("MonthCard");
            this.Property(t => t.RentCard).HasColumnName("RentCard");
            this.Property(t => t.TempCard).HasColumnName("TempCard");
            this.Property(t => t.FreeCard).HasColumnName("FreeCard");
            this.Property(t => t.TempFreeCard).HasColumnName("TempFreeCard");
            this.Property(t => t.VisCard).HasColumnName("VisCard");
            this.Property(t => t.RemainStall).HasColumnName("RemainStall");
        }
    }
}
