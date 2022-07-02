using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class BillModel
    {
        public Guid Id { get; set; }
        public Guid KindOfBillId { get; set; }
        public double TotalBill { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
