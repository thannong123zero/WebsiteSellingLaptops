using DataAccess.CustomEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class ReceiptModel : BaseEntityModel
    {
        public Guid ValletId { get; set; }
        public Guid UserId { get; set; }
        public Guid SaleBillId { get; set; }
        public double CollectMoney { get; set; }
        public DateTime CreateAt { get; set; }
        public ValletModel Vallet { get; set; }
        public UserModel User { get; set; }
        public SaleBillModel SaleBill { get; set; }

    }
}
