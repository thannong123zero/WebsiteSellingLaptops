using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class WithdrawMoneyModel
    {
        public Guid Id { get; set; }
        public Guid ValletId { get; set; }
        public Guid MethodKindId { get; set; }
        public Guid UserId { get; set; }
        public double Money { get; set; }
        public DateTime CreateAt { get; set; }
        public string Note { get; set; }
        public UserModel User { get; set; }
        public ValletModel Vallet { get; set; }
        public MethodKindModel MethodKind { get; set; }

    }
}
