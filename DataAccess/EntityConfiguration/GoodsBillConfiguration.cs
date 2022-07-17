using DataAccess.EntityModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfiguration
{
    public class GoodsBillConfiguration : IEntityTypeConfiguration<GoodsBillModel>
    {
        public void Configure(EntityTypeBuilder<GoodsBillModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(s => s.Money).IsRequired();
            builder.Property(s => s.CreateAt).HasDefaultValue(DateTime.Now);
            builder.HasOne(s => s.User).WithMany(g => g.GoodsBills).HasForeignKey(s => s.EmployeeId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(s => s.BillType).WithMany(g => g.GoodsBills).HasForeignKey(s => s.BillTypeId);
            builder.HasOne(s => s.WareHourse).WithMany(g => g.GoodsBills).HasForeignKey(s => s.WareHourseId);
        }
    }
}
