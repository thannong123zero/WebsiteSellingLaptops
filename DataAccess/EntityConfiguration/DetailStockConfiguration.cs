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
    public class DetailStockConfiguration : IEntityTypeConfiguration<DetailStockModel>
    {
        public void Configure(EntityTypeBuilder<DetailStockModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(s => s.quantity).IsRequired();

            builder.HasOne(s => s.WareHourse).WithMany(g => g.DetailStocks).HasForeignKey(s => s.WareHourseId);
            builder.HasOne(s => s.Product).WithMany(g => g.DetailStocks).HasForeignKey(s => s.ProductId);
        }
    }
}
