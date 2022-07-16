using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class DetailBuyBillModel
    {
        public Guid Id { get; set; }
        public Guid BuyBillId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public BuyBillModel BuyBill { get; set; }
        public ProductModel Product { get; set; }
    }
}
