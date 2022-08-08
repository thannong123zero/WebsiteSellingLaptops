using DataAccess.CustomEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class ProducerModel : BaseEntityModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string NumberPhone { get; set; }
        public ICollection<BuyBillModel>? BuyBills { get; set; }
    }
}
