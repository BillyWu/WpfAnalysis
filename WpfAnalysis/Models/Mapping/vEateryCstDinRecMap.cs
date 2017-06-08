using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class vEateryCstDinRecMap : EntityTypeConfiguration<vEateryCstDinRec>
    {
        public vEateryCstDinRecMap()
        {
            // Primary Key
            this.HasKey(t => new { t.餐段, t.ID });

            // Properties
            this.Property(t => t.用户姓名)
                .HasMaxLength(20);

            this.Property(t => t.卡号_姓名)
                .HasMaxLength(34);

            this.Property(t => t.部门)
                .HasMaxLength(20);

            this.Property(t => t.级别)
                .HasMaxLength(20);

            this.Property(t => t.餐厅名)
                .HasMaxLength(30);

            this.Property(t => t.设备名)
                .HasMaxLength(30);

            this.Property(t => t.餐段)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.收费员)
                .HasMaxLength(10);

            this.Property(t => t.电脑名)
                .HasMaxLength(50);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.@operator)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("vEateryCstDinRec");
            this.Property(t => t.用户姓名).HasColumnName("用户姓名");
            this.Property(t => t.卡号).HasColumnName("卡号");
            this.Property(t => t.卡号_姓名).HasColumnName("卡号_姓名");
            this.Property(t => t.部门).HasColumnName("部门");
            this.Property(t => t.级别).HasColumnName("级别");
            this.Property(t => t.餐厅名).HasColumnName("餐厅名");
            this.Property(t => t.设备名).HasColumnName("设备名");
            this.Property(t => t.餐段).HasColumnName("餐段");
            this.Property(t => t.原有金额).HasColumnName("原有金额");
            this.Property(t => t.应收金额).HasColumnName("应收金额");
            this.Property(t => t.补助金额).HasColumnName("补助金额");
            this.Property(t => t.实收金额).HasColumnName("实收金额");
            this.Property(t => t.剩余金额).HasColumnName("剩余金额");
            this.Property(t => t.收费员).HasColumnName("收费员");
            this.Property(t => t.日期).HasColumnName("日期");
            this.Property(t => t.电脑名).HasColumnName("电脑名");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DinNo).HasColumnName("DinNo");
            this.Property(t => t.CmpNo).HasColumnName("CmpNo");
            this.Property(t => t.DevNo).HasColumnName("DevNo");
            this.Property(t => t.@operator).HasColumnName("operator");
            this.Property(t => t.DayAddNo).HasColumnName("DayAddNo");
            this.Property(t => t.CustNo).HasColumnName("CustNo");
            this.Property(t => t.CustLevel).HasColumnName("CustLevel");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.amt).HasColumnName("amt");
            this.Property(t => t.addAmt).HasColumnName("addAmt");
            this.Property(t => t.realAmt).HasColumnName("realAmt");
            this.Property(t => t.CreateDT).HasColumnName("CreateDT");
            this.Property(t => t.leftAmt).HasColumnName("leftAmt");
        }
    }
}
