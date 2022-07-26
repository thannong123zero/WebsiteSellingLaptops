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
            builder.HasKey(x => x.Id);
            builder.Property(s => s.CollectMoney).IsRequired();
            builder.Property(s => s.CreateAt).HasDefaultValue(DateTime.Now);

            builder.HasOne(s => s.Wallet).WithMany(g => g.Receipts).HasForeignKey(s => s.ValletId);
        }
    }
}
