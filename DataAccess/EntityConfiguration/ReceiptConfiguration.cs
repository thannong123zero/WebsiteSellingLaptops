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
    public class ReceiptConfiguration : IEntityTypeConfiguration<ReceiptModel>
    {
        public void Configure(EntityTypeBuilder<ReceiptModel> builder)
        {
            throw new NotImplementedException();
        }
    }
}
