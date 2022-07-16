using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class ManufactoringModel
    {
        public Guid Id { get; set; }
        public string MadeIn { get; set; }
        public ICollection<ProductModel> Products { get; set; }
    }
}
