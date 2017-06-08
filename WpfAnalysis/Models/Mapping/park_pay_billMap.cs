using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class park_pay_billMap : EntityTypeConfiguration<park_pay_bill>
    {
        public park_pay_billMap()
        {
            // Primary Key
            this.HasKey(t => new { t.billNo, t.inSeq });

            // Properties
            this.Property(t => t.billNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.carNo)
                .HasMaxLength(15);

            this.Property(t => t.inSeq)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.@operator)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("park_pay_bill");
            this.Property(t => t.billNo).HasColumnName("billNo");
            this.Property(t => t.carNo).HasColumnName("carNo");
            this.Property(t => t.inSeq).HasColumnName("inSeq");
            this.Property(t => t.userType).HasColumnName("userType");
            this.Property(t => t.carType).HasColumnName("carType");
            this.Property(t => t.inTime).HasColumnName("inTime");
            this.Property(t => t.outTime).HasColumnName("outTime");
            this.Property(t => t.money).HasColumnName("money");
            this.Property(t => t.discountM).HasColumnName("discountM");
            this.Property(t => t.paidM).HasColumnName("paidM");
            this.Property(t => t.payMode).HasColumnName("payMode");
            this.Property(t => t.recStatus).HasColumnName("recStatus");
            this.Property(t => t.isVip).HasColumnName("isVip");
            this.Property(t => t.payTime).HasColumnName("payTime");
            this.Property(t => t.@operator).HasColumnName("operator");
            this.Property(t => t.isHandOver).HasColumnName("isHandOver");
        }
    }
}
