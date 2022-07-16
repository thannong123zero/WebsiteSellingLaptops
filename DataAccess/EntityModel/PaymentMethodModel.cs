using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class PaymentMethodModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<SaleBillModel> SaleBills { get; set; }
        public ICollection<BuyBillModel> BuyBills { get; set; }
    }
}
