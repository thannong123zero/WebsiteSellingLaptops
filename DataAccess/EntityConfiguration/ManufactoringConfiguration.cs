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
    public class ManufactoringConfiguration : IEntityTypeConfiguration<ManufactoringModel>
    {
        public void Configure(EntityTypeBuilder<ManufactoringModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(s => s.MadeIn).IsRequired().HasMaxLength(125);
            builder.Property(s => s.Description).HasMaxLength(1000);
            builder.HasIndex(s => s.MadeIn).IsUnique();
        }
    }
}
