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
    public class SaleBillConfiguration : IEntityTypeConfiguration<SaleBillModel>
    {
        public void Configure(EntityTypeBuilder<SaleBillModel> builder)
        {
            throw new NotImplementedException();
        }
    }
}
