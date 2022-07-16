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
    public class RoleConfiguration : IEntityTypeConfiguration<RoleModel>
    {
        public void Configure(EntityTypeBuilder<RoleModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(s => s.Name).IsRequired().HasMaxLength(20);
        }
    }
}
