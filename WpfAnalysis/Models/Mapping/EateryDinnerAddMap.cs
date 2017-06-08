using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class EateryDinnerAddMap : EntityTypeConfiguration<EateryDinnerAdd>
    {
        public EateryDinnerAddMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DayName)
                .HasMaxLength(10);

            this.Property(t => t.Start1)
                .HasMaxLength(5);

            this.Property(t => t.End1)
                .HasMaxLength(5);

            this.Property(t => t.Start2)
                .HasMaxLength(5);

            this.Property(t => t.End2)
                .HasMaxLength(5);

            this.Property(t => t.Start3)
                .HasMaxLength(5);

            this.Property(t => t.End3)
                .HasMaxLength(5);

            this.Property(t => t.@operator)
                .HasMaxLength(10);

            this.Property(t => t.Start4)
                .HasMaxLength(5);

            this.Property(t => t.End4)
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("EateryDinnerAdd");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.DinNo).HasColumnName("DinNo");
            this.Property(t => t.DayName).HasColumnName("DayName");
            this.Property(t => t.Start1).HasColumnName("Start1");
            this.Property(t => t.End1).HasColumnName("End1");
            this.Property(t => t.Start2).HasColumnName("Start2");
            this.Property(t => t.End2).HasColumnName("End2");
            this.Property(t => t.Start3).HasColumnName("Start3");
            this.Property(t => t.End3).HasColumnName("End3");
            this.Property(t => t.BreakfastAmt).HasColumnName("BreakfastAmt");
            this.Property(t => t.LunchAmt).HasColumnName("LunchAmt");
            this.Property(t => t.SupperAmt).HasColumnName("SupperAmt");
            this.Property(t => t.@operator).HasColumnName("operator");
            this.Property(t => t.createdt).HasColumnName("createdt");
            this.Property(t => t.Start4).HasColumnName("Start4");
            this.Property(t => t.End4).HasColumnName("End4");
            this.Property(t => t.NightAmt).HasColumnName("NightAmt");
        }
    }
}
