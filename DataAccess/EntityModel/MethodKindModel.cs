using DataAccess.CustomEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class MethodKindModel : BaseEntityModel
    {
        public string Name { get; set; } 
        public ICollection<WithdrawMoneyModel> WithdrawMoneys { get; set; }
    }
}
