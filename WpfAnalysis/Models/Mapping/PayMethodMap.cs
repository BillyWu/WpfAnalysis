using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class PayMethodMap : EntityTypeConfiguration<PayMethod>
    {
        public PayMethodMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Name, t.Support, t.TimeOut });

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.TimeOut)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CloudRootAddress)
                .HasMaxLength(500);

            this.Property(t => t.CloudInOperate)
                .HasMaxLength(50);

            this.Property(t => t.CloudOutOperate)
                .HasMaxLength(50);

            this.Property(t => t.CloudQueryPay)
                .HasMaxLength(50);

            this.Property(t => t.CloudSyncData)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PayMethod");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Support).HasColumnName("Support");
            this.Property(t => t.TimeOut).HasColumnName("TimeOut");
            this.Property(t => t.CloudRootAddress).HasColumnName("CloudRootAddress");
            this.Property(t => t.CloudInOperate).HasColumnName("CloudInOperate");
            this.Property(t => t.CloudOutOperate).HasColumnName("CloudOutOperate");
            this.Property(t => t.CloudQueryPay).HasColumnName("CloudQueryPay");
            this.Property(t => t.CloudSyncData).HasColumnName("CloudSyncData");
            this.Property(t => t.NetworkTO).HasColumnName("NetworkTO");
            this.Property(t => t.Priority).HasColumnName("Priority");
        }
    }
}
