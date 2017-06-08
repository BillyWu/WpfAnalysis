using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class parkingMap : EntityTypeConfiguration<parking>
    {
        public parkingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.card_no, t.in_seq });

            // Properties
            this.Property(t => t.card_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_seq)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.carno)
                .HasMaxLength(15);

            this.Property(t => t.in_pic)
                .HasMaxLength(100);

            this.Property(t => t.@operator)
                .HasMaxLength(10);

            this.Property(t => t.small_pic)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("parking");
            this.Property(t => t.card_no).HasColumnName("card_no");
            this.Property(t => t.in_seq).HasColumnName("in_seq");
            this.Property(t => t.card_tid).HasColumnName("card_tid");
            this.Property(t => t.car_tid).HasColumnName("car_tid");
            this.Property(t => t.carno).HasColumnName("carno");
            this.Property(t => t.in_time).HasColumnName("in_time");
            this.Property(t => t.in_pic).HasColumnName("in_pic");
            this.Property(t => t.in_from).HasColumnName("in_from");
            this.Property(t => t.stall_no).HasColumnName("stall_no");
            this.Property(t => t.inside_park).HasColumnName("inside_park");
            this.Property(t => t.@operator).HasColumnName("operator");
            this.Property(t => t.small_pic).HasColumnName("small_pic");
            this.Property(t => t.feesFlag).HasColumnName("feesFlag");
            this.Property(t => t.payTime).HasColumnName("payTime");
            this.Property(t => t.central_pay_money).HasColumnName("central_pay_money");
        }
    }
}
