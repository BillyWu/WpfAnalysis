using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class card_delayMap : EntityTypeConfiguration<card_delay>
    {
        public card_delayMap()
        {
            // Primary Key
            this.HasKey(t => new { t.card_no, t.cust_no, t.prevdate });

            // Properties
            this.Property(t => t.card_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cust_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.remark)
                .HasMaxLength(30);

            this.Property(t => t.@operator)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("card_delay");
            this.Property(t => t.card_no).HasColumnName("card_no");
            this.Property(t => t.cust_no).HasColumnName("cust_no");
            this.Property(t => t.prevdate).HasColumnName("prevdate");
            this.Property(t => t.currdate).HasColumnName("currdate");
            this.Property(t => t.money).HasColumnName("money");
            this.Property(t => t.remark).HasColumnName("remark");
            this.Property(t => t.@operator).HasColumnName("operator");
            this.Property(t => t.createdt).HasColumnName("createdt");
        }
    }
}
