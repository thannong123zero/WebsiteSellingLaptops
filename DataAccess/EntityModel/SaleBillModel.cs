using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class SaleBillModel
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid PaymentMethodId { get; set; }
        public double TotalValue { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
