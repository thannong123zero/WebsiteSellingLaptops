using DataAccess.CustomEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class ManufactoringModel : BaseEntityModel
    {
        public string MadeIn { get; set; }
        public string? Description { get; set; }
        public ICollection<ProductModel> Products { get; set; }
    }
}
