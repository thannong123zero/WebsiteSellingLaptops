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
    public class ValletConfiguration : IEntityTypeConfiguration<ValletModel>
    {
        public void Configure(EntityTypeBuilder<ValletModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(s => s.Money).HasDefaultValue(0);
        }
    }
}
