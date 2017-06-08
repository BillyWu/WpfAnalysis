using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class Table_VisitorMap : EntityTypeConfiguration<Table_Visitor>
    {
        public Table_VisitorMap()
        {
            // Primary Key
            this.HasKey(t => new { t.carno, t.validdt, t.parkStartDT });

            // Properties
            this.Property(t => t.carno)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.cust_name)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.matchDevStr)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.passcode)
                .HasMaxLength(20);

            this.Property(t => t.visitor_desc)
                .HasMaxLength(20);

            this.Property(t => t.cid)
                .HasMaxLength(60);

            this.Property(t => t.block_name)
                .HasMaxLength(50);

            this.Property(t => t.plate_number)
                .HasMaxLength(20);

            this.Property(t => t.password)
                .HasMaxLength(20);

            this.Property(t => t.arrive_at)
                .HasMaxLength(20);

            this.Property(t => t.leave_at)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Table_Visitor");
            this.Property(t => t.card_no).HasColumnName("card_no");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.card_type).HasColumnName("card_type");
            this.Property(t => t.carno).HasColumnName("carno");
            this.Property(t => t.car_type).HasColumnName("car_type");
            this.Property(t => t.cust_name).HasColumnName("cust_name");
            this.Property(t => t.validdt).HasColumnName("validdt");
            this.Property(t => t.park_stall).HasColumnName("park_stall");
            this.Property(t => t.matchDevStr).HasColumnName("matchDevStr");
            this.Property(t => t.parkStartDT).HasColumnName("parkStartDT");
            this.Property(t => t.passcode).HasColumnName("passcode");
            this.Property(t => t.visitor_desc).HasColumnName("visitor_desc");
            this.Property(t => t.cid).HasColumnName("cid");
            this.Property(t => t.block_name).HasColumnName("block_name");
            this.Property(t => t.plate_number).HasColumnName("plate_number");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.arrive_at).HasColumnName("arrive_at");
            this.Property(t => t.leave_at).HasColumnName("leave_at");
        }
    }
}
