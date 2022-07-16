using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class CustomerModel
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Gmail { get; set; }
        public string NumberPhone { get; set; }
        public string Address { get; set; }
        public CartModel Cart { get; set; }
        public ICollection<SaleBillModel> SaleBills { get; set; }
    }
}
