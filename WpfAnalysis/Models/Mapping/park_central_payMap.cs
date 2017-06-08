using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class park_central_payMap : EntityTypeConfiguration<park_central_pay>
    {
        public park_central_payMap()
        {
            // Primary Key
            this.HasKey(t => t.inSeq);

            // Properties
            this.Property(t => t.carNo)
                .HasMaxLength(15);

            this.Property(t => t.inSeq)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_pic)
                .HasMaxLength(100);

            this.Property(t => t.@operator)
                .HasMaxLength(10);

            this.Property(t => t.ComputerName)
                .HasMaxLength(50);

            this.Property(t => t.PayMethod)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("park_central_pay");
            this.Property(t => t.carNo).HasColumnName("carNo");
            this.Property(t => t.inSeq).HasColumnName("inSeq");
            this.Property(t => t.userType).HasColumnName("userType");
            this.Property(t => t.carType).HasColumnName("carType");
            this.Property(t => t.in_from).HasColumnName("in_from");
            this.Property(t => t.inTime).HasColumnName("inTime");
            this.Property(t => t.in_pic).HasColumnName("in_pic");
            this.Property(t => t.money).HasColumnName("money");
            this.Property(t => t.discountM).HasColumnName("discountM");
            this.Property(t => t.paidM).HasColumnName("paidM");
            this.Property(t => t.payTime).HasColumnName("payTime");
            this.Property(t => t.@operator).HasColumnName("operator");
            this.Property(t => t.ComputerName).HasColumnName("ComputerName");
            this.Property(t => t.PayMethod).HasColumnName("PayMethod");
            this.Property(t => t.isHandOver).HasColumnName("isHandOver");
        }
    }
}
