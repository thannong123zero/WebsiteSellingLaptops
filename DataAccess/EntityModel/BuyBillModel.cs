using DataAccess.CustomEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class BuyBillModel : BaseEntityModel
    {
        public Guid ProducerId { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid PaymentMethodId { get; set; }
        public double TotalMoney { get; set; }
        public ProducerModel Producer { get; set; }
        public UserModel User { get; set; }
        public PaymentMethodModel PaymentMethod { get; set; }
        public ICollection<DetailBuyBillModel>? DetailBuyBills { get; set; }
    }
}
