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
    public class UserConfiguration : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(s => s.FullName).IsRequired().HasMaxLength(125);
            builder.Property(s => s.BirthDay).IsRequired();
            builder.Property(s => s.Gender).IsRequired();
            builder.Property(s => s.Address).IsRequired().HasMaxLength(225);
            builder.Property(s => s.NumberPhone).IsRequired().HasMaxLength(10);
            builder.Property(s => s.IsDelete).HasDefaultValue(false);
            builder.Property(s => s.BirthDay).HasDefaultValue(true);
            builder.Property(s => s.CitizenId).IsRequired().HasMaxLength(15);
            builder.Property(s => s.CreateAt).HasDefaultValue(DateTime.Now);

            builder.HasOne(s => s.Role).WithMany(g => g.Users).HasForeignKey(s => s.RoleId);
            builder.HasOne<AccountModel>(s => s.Account).WithOne(sa => sa.User).HasForeignKey<AccountModel>(s => s.UserId);
            builder.HasOne<ReceiptModel>(s => s.Receipt).WithOne(sa => sa.User).HasForeignKey<AccountModel>(s => s.UserId);
        }
    }
}
