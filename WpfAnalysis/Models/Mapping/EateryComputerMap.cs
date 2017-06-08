using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class EateryComputerMap : EntityTypeConfiguration<EateryComputer>
    {
        public EateryComputerMap()
        {
            // Primary Key
            this.HasKey(t => t.CmpNo);

            // Properties
            this.Property(t => t.CmpNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CmpName)
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(50);

            this.Property(t => t.@operator)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("EateryComputer");
            this.Property(t => t.CmpNo).HasColumnName("CmpNo");
            this.Property(t => t.CmpName).HasColumnName("CmpName");
            this.Property(t => t.ComPort).HasColumnName("ComPort");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.CreateDT).HasColumnName("CreateDT");
            this.Property(t => t.@operator).HasColumnName("operator");
        }
    }
}
