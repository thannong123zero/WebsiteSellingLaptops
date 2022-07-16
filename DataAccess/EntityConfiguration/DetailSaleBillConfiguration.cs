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
    public class DetailSaleBillConfiguration : IEntityTypeConfiguration<DetailSaleBillModel>
    {
        public void Configure(EntityTypeBuilder<DetailSaleBillModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(s => s.Quantity).IsRequired();

            builder.HasOne(s => s.SaleBill).WithMany(g => g.DetailSaleBills).HasForeignKey(s => s.SaleBillId);
            builder.HasOne(s => s.Product).WithMany(g => g.DetailSaleBills).HasForeignKey(s => s.ProductId);
        }
    }
}
