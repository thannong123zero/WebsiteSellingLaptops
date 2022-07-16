using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class SubCategoryModel
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public bool IsDeleted { get; set; }
        public CategoryModel Category { get; set; }
        public ICollection<ProductModel> Products { get; set; }
    }
}
