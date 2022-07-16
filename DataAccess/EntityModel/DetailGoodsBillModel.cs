using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class DetailGoodsBillModel
    {
        public Guid Id { get; set; }
        public Guid GoodsBillId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public GoodsBillModel GoodsBill { get; set; }
        public ProductModel Product { get; set; }
    }
}
