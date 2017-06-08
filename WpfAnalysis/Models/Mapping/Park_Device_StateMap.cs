using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class Park_Device_StateMap : EntityTypeConfiguration<Park_Device_State>
    {
        public Park_Device_StateMap()
        {
            // Primary Key
            this.HasKey(t => new { t.device_ID, t.Printer, t.scanner, t.cashIn, t.cashOut, t.coinIn, t.coinOut, t.cardRead });

            // Properties
            this.Property(t => t.device_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Printer)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.scanner)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.cashIn)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.cashOut)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.coinIn)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.coinOut)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.cardRead)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Park_Device_State");
            this.Property(t => t.device_ID).HasColumnName("device_ID");
            this.Property(t => t.Printer).HasColumnName("Printer");
            this.Property(t => t.scanner).HasColumnName("scanner");
            this.Property(t => t.cashIn).HasColumnName("cashIn");
            this.Property(t => t.cashOut).HasColumnName("cashOut");
            this.Property(t => t.coinIn).HasColumnName("coinIn");
            this.Property(t => t.coinOut).HasColumnName("coinOut");
            this.Property(t => t.cardRead).HasColumnName("cardRead");
        }
    }
}
