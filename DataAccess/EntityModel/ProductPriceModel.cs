using DataAccess.CustomEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class ProductPriceModel : BaseEntityModel
    {
        public Guid ProductId { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }
        public ProductModel Product { get; set; }
    }
}
