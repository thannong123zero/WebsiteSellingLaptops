using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class CategoryModel
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
