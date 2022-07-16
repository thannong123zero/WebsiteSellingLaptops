using DataAccess.EntityModel;
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
    public class ProductPriceConfiguration : IEntityTypeConfiguration<ProductPriceModel>
    {
        public void Configure(EntityTypeBuilder<ProductPriceModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(s => s.Price).IsRequired();
            builder.Property(s => s.Discount).HasDefaultValue(0);
            builder.Property(s => s.CreateAt).HasDefaultValue(DateTime.Now);

            builder.HasOne(s => s.Product).WithMany(g => g.ProductPrices).HasForeignKey(s => s.ProductId);
        }
    }
}
