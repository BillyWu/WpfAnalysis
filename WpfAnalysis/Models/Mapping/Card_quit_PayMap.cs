using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class Card_quit_PayMap : EntityTypeConfiguration<Card_quit_Pay>
    {
        public Card_quit_PayMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CardNO, t.CustNO });

            // Properties
            this.Property(t => t.CardNO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CustNO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Operator)
                .HasMaxLength(10);

            this.Property(t => t.Remark)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Card_quit_Pay");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CardNO).HasColumnName("CardNO");
            this.Property(t => t.CustNO).HasColumnName("CustNO");
            this.Property(t => t.PrevAmt).HasColumnName("PrevAmt");
            this.Property(t => t.AddAmt).HasColumnName("AddAmt");
            this.Property(t => t.ValidTime).HasColumnName("ValidTime");
            this.Property(t => t.Operator).HasColumnName("Operator");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.CreateDT).HasColumnName("CreateDT");
        }
    }
}
