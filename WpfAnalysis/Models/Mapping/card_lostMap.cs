using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class card_lostMap : EntityTypeConfiguration<card_lost>
    {
        public card_lostMap()
        {
            // Primary Key
            this.HasKey(t => new { t.card_no, t.cust_no, t.optype });

            // Properties
            this.Property(t => t.card_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cust_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.optype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.remark)
                .HasMaxLength(60);

            this.Property(t => t.@operator)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("card_lost");
            this.Property(t => t.card_no).HasColumnName("card_no");
            this.Property(t => t.cust_no).HasColumnName("cust_no");
            this.Property(t => t.optype).HasColumnName("optype");
            this.Property(t => t.lostdt).HasColumnName("lostdt");
            this.Property(t => t.remark).HasColumnName("remark");
            this.Property(t => t.@operator).HasColumnName("operator");
            this.Property(t => t.createdt).HasColumnName("createdt");
        }
    }
}
