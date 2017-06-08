using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class Park_Auto_Pay_RecordMap : EntityTypeConfiguration<Park_Auto_Pay_Record>
    {
        public Park_Auto_Pay_RecordMap()
        {
            // Primary Key
            this.HasKey(t => new { t.deserve_money, t.real_money, t.operate_time });

            // Properties
            this.Property(t => t.serial_number)
                .HasMaxLength(21);

            this.Property(t => t.card_no)
                .HasMaxLength(50);

            this.Property(t => t.pay_type)
                .HasMaxLength(50);

            this.Property(t => t.deserve_money)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.real_money)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.remark)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Park_Auto_Pay_Record");
            this.Property(t => t.serial_number).HasColumnName("serial_number");
            this.Property(t => t.device_ID).HasColumnName("device_ID");
            this.Property(t => t.pay_teminal).HasColumnName("pay_teminal");
            this.Property(t => t.card_no).HasColumnName("card_no");
            this.Property(t => t.inPark_time).HasColumnName("inPark_time");
            this.Property(t => t.outPark_time).HasColumnName("outPark_time");
            this.Property(t => t.pay_type).HasColumnName("pay_type");
            this.Property(t => t.deserve_money).HasColumnName("deserve_money");
            this.Property(t => t.real_money).HasColumnName("real_money");
            this.Property(t => t.dispense_money).HasColumnName("dispense_money");
            this.Property(t => t.operate_flag).HasColumnName("operate_flag");
            this.Property(t => t.operate_time).HasColumnName("operate_time");
            this.Property(t => t.remark).HasColumnName("remark");
        }
    }
}
