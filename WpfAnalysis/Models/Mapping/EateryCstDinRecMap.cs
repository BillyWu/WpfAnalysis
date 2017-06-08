using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class EateryCstDinRecMap : EntityTypeConfiguration<EateryCstDinRec>
    {
        public EateryCstDinRecMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.@operator)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("EateryCstDinRec");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DinNo).HasColumnName("DinNo");
            this.Property(t => t.CmpNo).HasColumnName("CmpNo");
            this.Property(t => t.DevNo).HasColumnName("DevNo");
            this.Property(t => t.@operator).HasColumnName("operator");
            this.Property(t => t.DayAddNo).HasColumnName("DayAddNo");
            this.Property(t => t.CustNo).HasColumnName("CustNo");
            this.Property(t => t.CustLevel).HasColumnName("CustLevel");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.amt).HasColumnName("amt");
            this.Property(t => t.addAmt).HasColumnName("addAmt");
            this.Property(t => t.realAmt).HasColumnName("realAmt");
            this.Property(t => t.CreateDT).HasColumnName("CreateDT");
            this.Property(t => t.leftAmt).HasColumnName("leftAmt");
        }
    }
}
