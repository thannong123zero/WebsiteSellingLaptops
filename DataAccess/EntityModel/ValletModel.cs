using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class ValletModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Money { get; set; }
        public ICollection<WithdrawMoneyModel> WithdrawMoneys { get; set; }
        public ICollection<ReceiptModel> Receipts { get; set; }
    }
}
