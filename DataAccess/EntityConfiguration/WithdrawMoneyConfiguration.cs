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
    public class WithdrawMoneyConfiguration : IEntityTypeConfiguration<WithdrawMoneyModel>
    {
        public void Configure(EntityTypeBuilder<WithdrawMoneyModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Money).IsRequired();
            builder.Property(x => x.CreateAt).IsRequired();
            builder.Property(s => s.Note).IsRequired(false).HasMaxLength(225);

            builder.HasOne<ValletModel>(s => s.Vallet).WithMany(g => g.WithdrawMoneys)
                .HasForeignKey(s => s.ValletId);
            builder.HasOne<UserModel>(s => s.User).WithMany(g => g.WithdrawMoneys)
                .HasForeignKey(s => s.UserId);
            builder.HasOne<MethodKindModel>(s => s.MethodKind).WithMany(g => g.WithdrawMoneys)
                .HasForeignKey(s => s.MethodKindId);
        }
    }
}
