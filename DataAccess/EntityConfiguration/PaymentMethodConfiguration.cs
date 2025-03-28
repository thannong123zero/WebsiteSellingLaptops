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
    public class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethodModel>
    {
        public void Configure(EntityTypeBuilder<PaymentMethodModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(s => s.Name).IsRequired().HasMaxLength(50);
            builder.HasIndex(s => s.Name).IsUnique();
            builder.HasData(
                new PaymentMethodModel {  Name = "Tiền mặt" },
                new PaymentMethodModel {  Name = "Chuyển khoản" });
        }
    }
}
