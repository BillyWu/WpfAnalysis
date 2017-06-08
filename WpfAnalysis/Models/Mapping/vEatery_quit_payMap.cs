using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class vEatery_quit_payMap : EntityTypeConfiguration<vEatery_quit_pay>
    {
        public vEatery_quit_payMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CardNO, t.CustNO });

            // Properties
            this.Property(t => t.CardNO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CustNO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Operator)
                .HasMaxLength(10);

            this.Property(t => t.Remark)
                .HasMaxLength(100);

            this.Property(t => t.cust_name)
                .HasMaxLength(20);

            this.Property(t => t.deptName)
                .HasMaxLength(20);

            this.Property(t => t.cust_nick)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("vEatery_quit_pay");
            this.Property(t => t.CardNO).HasColumnName("CardNO");
            this.Property(t => t.CustNO).HasColumnName("CustNO");
            this.Property(t => t.PrevAmt).HasColumnName("PrevAmt");
            this.Property(t => t.ValidTime).HasColumnName("ValidTime");
            this.Property(t => t.AddAmt).HasColumnName("AddAmt");
            this.Property(t => t.Operator).HasColumnName("Operator");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.CreateDT).HasColumnName("CreateDT");
            this.Property(t => t.cust_name).HasColumnName("cust_name");
            this.Property(t => t.deptNo).HasColumnName("deptNo");
            this.Property(t => t.deptName).HasColumnName("deptName");
            this.Property(t => t.cust_nick).HasColumnName("cust_nick");
        }
    }
}
