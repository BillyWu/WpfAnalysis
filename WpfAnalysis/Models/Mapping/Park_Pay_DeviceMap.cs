using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class Park_Pay_DeviceMap : EntityTypeConfiguration<Park_Pay_Device>
    {
        public Park_Pay_DeviceMap()
        {
            // Primary Key
            this.HasKey(t => t.device_ID);

            // Properties
            this.Property(t => t.device_name)
                .HasMaxLength(50);

            this.Property(t => t.device_title)
                .HasMaxLength(50);

            this.Property(t => t.device_type)
                .HasMaxLength(50);

            this.Property(t => t.device_IP)
                .HasMaxLength(15);

            this.Property(t => t.remark)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Park_Pay_Device");
            this.Property(t => t.device_ID).HasColumnName("device_ID");
            this.Property(t => t.device_name).HasColumnName("device_name");
            this.Property(t => t.device_title).HasColumnName("device_title");
            this.Property(t => t.device_type).HasColumnName("device_type");
            this.Property(t => t.device_IP).HasColumnName("device_IP");
            this.Property(t => t.income_money).HasColumnName("income_money");
            this.Property(t => t.cash_count).HasColumnName("cash_count");
            this.Property(t => t.ten_count).HasColumnName("ten_count");
            this.Property(t => t.twenty_count).HasColumnName("twenty_count");
            this.Property(t => t.coin_count).HasColumnName("coin_count");
            this.Property(t => t.remark).HasColumnName("remark");
        }
    }
}
