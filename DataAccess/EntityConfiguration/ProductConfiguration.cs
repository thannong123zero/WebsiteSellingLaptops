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
    public class ProductConfiguration : IEntityTypeConfiguration<ProductModel>
    {
        public void Configure(EntityTypeBuilder<ProductModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(s => s.ProductName).IsRequired().HasMaxLength(125);
            builder.Property(s => s.Descrition).IsRequired();
            builder.Property(s => s.CreateAt).HasDefaultValue(DateTime.Now);
            builder.HasOne(s => s.SubCategory).WithMany(g => g.Products).HasForeignKey(s => s.SubCategoryId);
            builder.HasOne(s => s.Manufactoring).WithMany(g => g.Products).HasForeignKey(s => s.ManufactorId);
        }
    }
}
