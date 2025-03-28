﻿using DataAccess.EntityModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfiguration
{
    public class DetailCartConfiguration : IEntityTypeConfiguration<DetailCartModel>
    {
        public void Configure(EntityTypeBuilder<DetailCartModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(s => s.Quantity).IsRequired();

            builder.HasOne<ProductModel>(s => s.Product).WithMany(g => g.DetailCarts).HasForeignKey(s => s.ProductId);
            builder.HasOne<CartModel>(s => s.Cart).WithMany(g => g.DetailCarts).HasForeignKey(s => s.CartId);
        }
    }
}
