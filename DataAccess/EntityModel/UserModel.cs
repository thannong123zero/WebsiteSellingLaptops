using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZWA.Core.Domain.Abstractions;

namespace DataAccess.EntityModel
{
    public class UserModel : IdentityUser<Guid>, IIdentity<Guid>
    {
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public byte Gender { get; set; }
        public string Address { get; set; }
        public string? Avatatar { get; set; }
        public bool IsActive { get; set; }
        public string CitizenId { get; set; }


        public ReceiptModel Receipt { get; set; }
        public ICollection<GoodsBillModel> GoodsBills { get; set; }
        public ICollection<SaleBillModel> SaleBills { get; set; }
        public ICollection<BuyBillModel> BuyBills { get; set; }
        public ICollection<WithdrawMoneyModel> WithdrawMoneys { get; set; }

    }
}
