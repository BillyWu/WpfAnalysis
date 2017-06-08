using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class custoperMap : EntityTypeConfiguration<custoper>
    {
        public custoperMap()
        {
            // Primary Key
            this.HasKey(t => new { t.cust_no, t.tid, t.tname, t.cardno });

            // Properties
            this.Property(t => t.cust_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cust_name)
                .HasMaxLength(20);

            this.Property(t => t.cust_nick)
                .HasMaxLength(10);

            this.Property(t => t.tid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tname)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.cardno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("custoper");
            this.Property(t => t.cust_no).HasColumnName("cust_no");
            this.Property(t => t.cust_name).HasColumnName("cust_name");
            this.Property(t => t.cust_nick).HasColumnName("cust_nick");
            this.Property(t => t.tid).HasColumnName("tid");
            this.Property(t => t.tname).HasColumnName("tname");
            this.Property(t => t.cardno).HasColumnName("cardno");
            this.Property(t => t.deptno).HasColumnName("deptno");
        }
    }
}
