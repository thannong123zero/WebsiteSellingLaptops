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
    public class CustomerConfiguration : IEntityTypeConfiguration<CustomerModel>
    {
        public void Configure(EntityTypeBuilder<CustomerModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(s => s.FullName).IsRequired().HasMaxLength(225);
            builder.Property(s => s.NumberPhone).IsRequired().HasMaxLength(10);
            builder.Property(s => s.Gmail).IsRequired(false).HasMaxLength(125);
            builder.Property(s => s.Address).IsRequired().HasMaxLength(225);
            builder.HasIndex(x => x.NumberPhone).IsUnique();
            builder.HasOne<CartModel>(s => s.Cart).WithOne(sa => sa.Customer)
                .HasPrincipalKey<CartModel>(s => s.CustomerId);
        }
    }
}
