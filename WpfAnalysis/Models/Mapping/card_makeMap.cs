using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class card_makeMap : EntityTypeConfiguration<card_make>
    {
        public card_makeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.card_no, t.cust_no });

            // Properties
            this.Property(t => t.card_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cust_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.@operator)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("card_make");
            this.Property(t => t.card_no).HasColumnName("card_no");
            this.Property(t => t.cust_no).HasColumnName("cust_no");
            this.Property(t => t.foregift).HasColumnName("foregift");
            this.Property(t => t.balance).HasColumnName("balance");
            this.Property(t => t.validdt).HasColumnName("validdt");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.@operator).HasColumnName("operator");
            this.Property(t => t.createdt).HasColumnName("createdt");
            this.Property(t => t.parkStartDT).HasColumnName("parkStartDT");
        }
    }
}
