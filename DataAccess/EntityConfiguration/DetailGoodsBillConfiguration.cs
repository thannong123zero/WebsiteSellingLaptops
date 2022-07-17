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
    public class DetailGoodsBillConfiguration : IEntityTypeConfiguration<DetailGoodsBillModel>
    {
        public void Configure(EntityTypeBuilder<DetailGoodsBillModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(s => s.Quantity).IsRequired();
            builder.Property(s => s.Price).IsRequired();
            builder.HasOne(s => s.GoodsBill).WithMany(g => g.DetailGoodsBills).HasForeignKey(s => s.GoodsBillId);
            builder.HasOne(s => s.Product).WithMany(g => g.DetailGoodsBills).HasForeignKey(s => s.ProductId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
