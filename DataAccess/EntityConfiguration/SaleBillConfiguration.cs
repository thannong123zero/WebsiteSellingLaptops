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
    public class SaleBillConfiguration : IEntityTypeConfiguration<SaleBillModel>
    {
        public void Configure(EntityTypeBuilder<SaleBillModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(s => s.TotalValue).IsRequired();
            builder.Property(s => s.CreateAt).HasDefaultValue(DateTime.Now);

            builder.HasOne<CustomerModel>(s => s.Customer).WithMany(g => g.SaleBills).HasForeignKey(s => s.CustomerId);
            builder.HasOne<PaymentMethodModel>(s => s.PaymentMethod).WithMany(g => g.SaleBills).HasForeignKey(s => s.PaymentMethodId);
            builder.HasOne<UserModel>(s => s.User).WithMany(g => g.SaleBills).HasForeignKey(s => s.EmployeeId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne<ReceiptModel>(s => s.Receipt).WithOne(sa => sa.SaleBill).HasForeignKey<ReceiptModel>(s => s.SaleBillId);
        }
    }
}
