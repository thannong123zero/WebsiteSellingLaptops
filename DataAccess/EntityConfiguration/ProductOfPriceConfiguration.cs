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
    public class ProductOfPriceConfiguration : IEntityTypeConfiguration<ProductOfPriceModel>
    {
        public void Configure(EntityTypeBuilder<ProductOfPriceModel> builder)
        {
            throw new NotImplementedException();
        }
    }
}
