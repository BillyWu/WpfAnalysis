using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class EateryDinnerMap : EntityTypeConfiguration<EateryDinner>
    {
        public EateryDinnerMap()
        {
            // Primary Key
            this.HasKey(t => t.DinNo);

            // Properties
            this.Property(t => t.DinNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DinName)
                .HasMaxLength(30);

            this.Property(t => t.@operator)
                .HasMaxLength(10);

            this.Property(t => t.remark)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EateryDinner");
            this.Property(t => t.DinNo).HasColumnName("DinNo");
            this.Property(t => t.DinName).HasColumnName("DinName");
            this.Property(t => t.@operator).HasColumnName("operator");
            this.Property(t => t.CreateDT).HasColumnName("CreateDT");
            this.Property(t => t.remark).HasColumnName("remark");
        }
    }
}
