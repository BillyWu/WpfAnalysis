using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class customerMap : EntityTypeConfiguration<customer>
    {
        public customerMap()
        {
            // Primary Key
            this.HasKey(t => t.cust_no);

            // Properties
            this.Property(t => t.cust_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cust_name)
                .HasMaxLength(20);

            this.Property(t => t.cust_password)
                .HasMaxLength(20);

            this.Property(t => t.cust_nick)
                .HasMaxLength(10);

            this.Property(t => t.phone_no)
                .HasMaxLength(15);

            this.Property(t => t.mobile)
                .HasMaxLength(15);

            this.Property(t => t.idcard)
                .HasMaxLength(18);

            this.Property(t => t.address)
                .HasMaxLength(60);

            this.Property(t => t.remark)
                .HasMaxLength(60);

            this.Property(t => t.@operator)
                .HasMaxLength(10);

            this.Property(t => t.photo)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("customer");
            this.Property(t => t.cust_no).HasColumnName("cust_no");
            this.Property(t => t.cust_name).HasColumnName("cust_name");
            this.Property(t => t.cust_password).HasColumnName("cust_password");
            this.Property(t => t.cust_nick).HasColumnName("cust_nick");
            this.Property(t => t.sex).HasColumnName("sex");
            this.Property(t => t.phone_no).HasColumnName("phone_no");
            this.Property(t => t.mobile).HasColumnName("mobile");
            this.Property(t => t.idcard).HasColumnName("idcard");
            this.Property(t => t.address).HasColumnName("address");
            this.Property(t => t.remark).HasColumnName("remark");
            this.Property(t => t.@operator).HasColumnName("operator");
            this.Property(t => t.createdt).HasColumnName("createdt");
            this.Property(t => t.wrkNo).HasColumnName("wrkNo");
            this.Property(t => t.deptNo).HasColumnName("deptNo");
            this.Property(t => t.photo).HasColumnName("photo");
            this.Property(t => t.cust_level).HasColumnName("cust_level");
        }
    }
}
