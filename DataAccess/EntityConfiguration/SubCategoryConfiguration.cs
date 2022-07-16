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
    public class SubCategoryConfiguration : IEntityTypeConfiguration<SubCategoryModel>
    {
        public void Configure(EntityTypeBuilder<SubCategoryModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(s => s.SubCategoryName).IsRequired().HasMaxLength(125);
            builder.Property(s => s.IsDeleted).HasDefaultValue(false);

            builder.HasOne<CategoryModel>(s => s.Category).WithMany(g => g.SubCategories).HasForeignKey(s => s.CategoryId);
        }
    }
}
