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
            builder.Property(s => s.IsActive).HasDefaultValue(false);
            builder.Property(s => s.CitizenId).IsRequired().HasMaxLength(15);
            builder.HasIndex(s => s.PhoneNumber).IsUnique();
            builder.HasIndex(s => s.CitizenId).IsUnique();

            builder.HasOne<ReceiptModel>(s => s.Receipt).WithOne(sa => sa.User).HasForeignKey<ReceiptModel>(s => s.UserId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
