using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class card_chargeMap : EntityTypeConfiguration<card_charge>
    {
        public card_chargeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CustName)
                .HasMaxLength(10);

            this.Property(t => t.Operator)
                .HasMaxLength(10);

            this.Property(t => t.Remark)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("card_charge");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SystemId).HasColumnName("SystemId");
            this.Property(t => t.CardNO).HasColumnName("CardNO");
            this.Property(t => t.CustName).HasColumnName("CustName");
            this.Property(t => t.PrevAmt).HasColumnName("PrevAmt");
            this.Property(t => t.AddAmt).HasColumnName("AddAmt");
            this.Property(t => t.Operator).HasColumnName("Operator");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.CreateDT).HasColumnName("CreateDT");
        }
    }
}
