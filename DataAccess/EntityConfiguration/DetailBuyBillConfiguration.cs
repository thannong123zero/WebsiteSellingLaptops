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
    public class DetailBuyBillConfiguration : IEntityTypeConfiguration<DetailBuyBillModel>
    {
        public void Configure(EntityTypeBuilder<DetailBuyBillModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(s => s.Quantity).IsRequired();
            builder.Property(s => s.Price).IsRequired();
            builder.HasOne(s => s.BuyBill).WithMany(g => g.DetailBuyBills).HasForeignKey(s => s.BuyBillId);
            builder.HasOne(s => s.Product).WithMany(g => g.DetailBuyBills).HasForeignKey(s => s.ProductId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
