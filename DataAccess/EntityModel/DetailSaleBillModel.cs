using DataAccess.CustomEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class DetailSaleBillModel : BaseEntityModel
    {
        public Guid SaleBillId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public SaleBillModel SaleBill { get; set; }
        public ProductModel Product { get; set; }
    }
}
