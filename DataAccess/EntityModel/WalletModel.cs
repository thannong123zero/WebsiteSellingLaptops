using DataAccess.CustomEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZWA.Core.Domain.Abstractions;

namespace DataAccess.EntityModel
{
    public class WalletModel : BaseEntityModel
    {
        public string Name { get; set; }
        public double Money { get; set; }
        public string? Description { get; set; }
        public ICollection<WithdrawMoneyModel> WithdrawMoneys { get; set; }
        public ICollection<ReceiptModel> Receipts { get; set; }
    }
}
