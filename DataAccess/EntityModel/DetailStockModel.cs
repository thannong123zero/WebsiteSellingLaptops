using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class DetailStockModel
    {
        public Guid Id { get; set; }
        public Guid WareHourseId { get; set; }
        public Guid ProductId { get; set; }
        public int quantity  { get; set; }
        public WareHourseModel WareHourse { get; set; }
        public ProductModel Product { get; set; }
    }
}
