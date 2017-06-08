using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class Ticket_InfoMap : EntityTypeConfiguration<Ticket_Info>
    {
        public Ticket_InfoMap()
        {
            // Primary Key
            this.HasKey(t => t.create_Time);

            // Properties
            this.Property(t => t.qp_Code)
                .HasMaxLength(80);

            this.Property(t => t.vip_Code)
                .HasMaxLength(20);

            this.Property(t => t.merchant)
                .HasMaxLength(20);

            this.Property(t => t.ticket_Number)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Ticket_Info");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.qp_Code).HasColumnName("qp_Code");
            this.Property(t => t.use_Time).HasColumnName("use_Time");
            this.Property(t => t.vip_Code).HasColumnName("vip_Code");
            this.Property(t => t.merchant).HasColumnName("merchant");
            this.Property(t => t.ticket_Number).HasColumnName("ticket_Number");
            this.Property(t => t.money).HasColumnName("money");
            this.Property(t => t.point).HasColumnName("point");
            this.Property(t => t.deductible_money).HasColumnName("deductible_money");
            this.Property(t => t.deductible_mode).HasColumnName("deductible_mode");
            this.Property(t => t.create_Time).HasColumnName("create_Time");
        }
    }
}
