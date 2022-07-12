using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class ProductModel
    {
        public Guid Id { get; set; }
        public Guid SubCategoryId { get; set; }
        public Guid ManufactorId { get; set; } 
        public string ProductName { get; set; }
        public string Descrition { get; set; }
        public string Img { get; set; }
        public DateTime CreateAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime WarrantyPeriod { get; set; }
    }
}
