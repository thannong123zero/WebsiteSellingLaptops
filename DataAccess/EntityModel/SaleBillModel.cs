using DataAccess.CustomEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class SaleBillModel : BaseEntityModel
    {
        public Guid EmployeeId { get; set; }
        public Guid PaymentMethodId { get; set; }
        public Guid CustomerId { get; set; }
        public double TotalValue { get; set; }
        public UserModel User { get; set; }
        public PaymentMethodModel PaymentMethod { get; set; }
        public ReceiptModel Receipt { get; set; }
        public CustomerModel Customer { get; set; }
        public ICollection<DetailSaleBillModel>? DetailSaleBills { get; set; }
    }
}
