using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class PA_tboSchemeMap : EntityTypeConfiguration<PA_tboScheme>
    {
        public PA_tboSchemeMap()
        {
            // Primary Key
            this.HasKey(t => t.SeqNO);

            // Properties
            this.Property(t => t.IP)
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Memo)
                .HasMaxLength(1000);

            this.Property(t => t.Led)
                .HasMaxLength(50);

            this.Property(t => t.CaptureLayout)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PA_tboScheme");
            this.Property(t => t.SeqNO).HasColumnName("SeqNO");
            this.Property(t => t.Region).HasColumnName("Region");
            this.Property(t => t.IP).HasColumnName("IP");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.Led).HasColumnName("Led");
            this.Property(t => t.CaptureLayout).HasColumnName("CaptureLayout");
            this.Property(t => t.SchemeTime).HasColumnName("SchemeTime");
            this.Property(t => t.RepeatTime).HasColumnName("RepeatTime");
            this.Property(t => t.OneCarMultipleNo).HasColumnName("OneCarMultipleNo");
            this.Property(t => t.WaitTime).HasColumnName("WaitTime");
        }
    }
}
