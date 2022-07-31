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
    public class BillTypeConfiguration : IEntityTypeConfiguration<BillTypeModel>
    {
        public void Configure(EntityTypeBuilder<BillTypeModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(s => s.Name).IsRequired().HasMaxLength(50);
            builder.HasIndex(s => s.Name).IsUnique();
            builder.HasData(
                new BillTypeModel { Name = "Hóa đơn nhập" },
                new BillTypeModel { Name = "Hóa đơn xuất" }
            );

        }
    }
}
