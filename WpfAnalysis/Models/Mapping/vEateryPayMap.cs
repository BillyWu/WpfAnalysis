using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class vEateryPayMap : EntityTypeConfiguration<vEateryPay>
    {
        public vEateryPayMap()
        {
            // Primary Key
            this.HasKey(t => new { t.卡号, t.deptNo, t.CardNO });

            // Properties
            this.Property(t => t.卡号)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Remark)
                .HasMaxLength(100);

            this.Property(t => t.Operator)
                .HasMaxLength(10);

            this.Property(t => t.cust_nick)
                .HasMaxLength(10);

            this.Property(t => t.姓名)
                .HasMaxLength(20);

            this.Property(t => t.部门)
                .HasMaxLength(20);

            this.Property(t => t.deptNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.deptName)
                .HasMaxLength(20);

            this.Property(t => t.CardNO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cust_name)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("vEateryPay");
            this.Property(t => t.卡号).HasColumnName("卡号");
            this.Property(t => t.AddAmt).HasColumnName("AddAmt");
            this.Property(t => t.PrevAmt).HasColumnName("PrevAmt");
            this.Property(t => t.leftAmt).HasColumnName("leftAmt");
            this.Property(t => t.CreateDT).HasColumnName("CreateDT");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.Operator).HasColumnName("Operator");
            this.Property(t => t.cust_nick).HasColumnName("cust_nick");
            this.Property(t => t.姓名).HasColumnName("姓名");
            this.Property(t => t.部门).HasColumnName("部门");
            this.Property(t => t.deptNo).HasColumnName("deptNo");
            this.Property(t => t.deptName).HasColumnName("deptName");
            this.Property(t => t.CardNO).HasColumnName("CardNO");
            this.Property(t => t.cust_name).HasColumnName("cust_name");
        }
    }
}
