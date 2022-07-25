using DataAccess.CustomEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class CategoryModel : BaseEntityModel
    {
        public string CategoryName { get; set; }
        public ICollection<SubCategoryModel> SubCategories { get; set; }
    }
}
