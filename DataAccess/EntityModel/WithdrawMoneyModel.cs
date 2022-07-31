using DataAccess.CustomEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class WithdrawMoneyModel : BaseEntityModel
    {
        public Guid ValletId { get; set; }
        public Guid MethodKindId { get; set; }
        public Guid UserId { get; set; }
        public double Money { get; set; }
        public string? Note { get; set; }
        public UserModel User { get; set; }
        public WalletModel Wallet { get; set; }
        public PaymentMethodModel PaymentMethod { get; set; }

    }
}
