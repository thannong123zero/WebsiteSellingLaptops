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
    public class ProducerConfiguration : IEntityTypeConfiguration<ProducerModel>
    {
        public void Configure(EntityTypeBuilder<ProducerModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(s => s.Name).IsRequired().HasMaxLength(125);
            builder.Property(s => s.NumberPhone).HasMaxLength(10);
            builder.Property(s => s.Address).HasMaxLength(225);
            builder.Property(s => s.IsDelete).HasDefaultValue(false);
            builder.HasIndex(s => s.Name).IsUnique();

        }
    }
}
