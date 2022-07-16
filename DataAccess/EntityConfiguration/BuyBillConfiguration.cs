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
    public class BuyBillConfiguration : IEntityTypeConfiguration<BuyBillModel>
    {
        public void Configure(EntityTypeBuilder<BuyBillModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(s => s.TotalMoney).IsRequired();
            builder.Property(s => s.CreatAt).HasDefaultValue(DateTime.Now);

            builder.HasOne(s => s.Producer).WithMany(g => g.BuyBills).HasForeignKey(s => s.ProducerId);
            builder.HasOne(s => s.User).WithMany(g => g.BuyBills).HasForeignKey(s => s.EmployeeId);
            builder.HasOne(s => s.PaymentMethod).WithMany(g => g.BuyBills).HasForeignKey(s => s.PaymentMethodId);
        }
    }
}
