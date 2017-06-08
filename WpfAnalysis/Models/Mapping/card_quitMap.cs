using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class card_quitMap : EntityTypeConfiguration<card_quit>
    {
        public card_quitMap()
        {
            // Primary Key
            this.HasKey(t => new { t.card_no, t.cust_no });

            // Properties
            this.Property(t => t.card_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cust_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.remark)
                .HasMaxLength(60);

            this.Property(t => t.@operator)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("card_quit");
            this.Property(t => t.card_no).HasColumnName("card_no");
            this.Property(t => t.cust_no).HasColumnName("cust_no");
            this.Property(t => t.retmode).HasColumnName("retmode");
            this.Property(t => t.foregift).HasColumnName("foregift");
            this.Property(t => t.balance).HasColumnName("balance");
            this.Property(t => t.retmoney).HasColumnName("retmoney");
            this.Property(t => t.remark).HasColumnName("remark");
            this.Property(t => t.@operator).HasColumnName("operator");
            this.Property(t => t.createdt).HasColumnName("createdt");
        }
    }
}
