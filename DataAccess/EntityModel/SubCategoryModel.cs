using DataAccess.CustomEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class SubCategoryModel : BaseEntityModel
    { 
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public CategoryModel Category { get; set; }
        public ICollection<ProductModel>? Products { get; set; }
    }
}
