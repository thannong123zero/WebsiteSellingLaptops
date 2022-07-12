using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class ReceiptModel
    {
        public Guid Id { get; set; }
        public Guid SaleBillId { get; set; }
        public double CollectMoney { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
