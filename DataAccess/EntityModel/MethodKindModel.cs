using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class MethodKindModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } 
        public ICollection<WithdrawMoneyModel> WithdrawMoneys { get; set; }
    }
}
