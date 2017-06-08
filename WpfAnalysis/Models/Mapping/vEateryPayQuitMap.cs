using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class vEateryPayQuitMap : EntityTypeConfiguration<vEateryPayQuit>
    {
        public vEateryPayQuitMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CardNO, t.deptno });

            // Properties
            this.Property(t => t.CardNO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Remark)
                .HasMaxLength(100);

            this.Property(t => t.Operator)
                .HasMaxLength(10);

            this.Property(t => t.cust_nick)
                .HasMaxLength(10);

            this.Property(t => t.cust_name)
                .HasMaxLength(20);

            this.Property(t => t.deptname)
                .HasMaxLength(20);

            this.Property(t => t.deptno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vEateryPayQuit");
            this.Property(t => t.CardNO).HasColumnName("CardNO");
            this.Property(t => t.AddAmt).HasColumnName("AddAmt");
            this.Property(t => t.PrevAmt).HasColumnName("PrevAmt");
            this.Property(t => t.CreateDT).HasColumnName("CreateDT");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.Operator).HasColumnName("Operator");
            this.Property(t => t.cust_nick).HasColumnName("cust_nick");
            this.Property(t => t.cust_name).HasColumnName("cust_name");
            this.Property(t => t.deptname).HasColumnName("deptname");
            this.Property(t => t.deptno).HasColumnName("deptno");
        }
    }
}
