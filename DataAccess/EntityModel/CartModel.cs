using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class CartModel
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public double TotalMoney { get; set; }
        public DateTime CreatAt  { get; set; }
    }
}
