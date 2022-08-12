using DataAccess.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModel
{
    public class CartViewModel
    {
        public int Id { get; set; }
        public Guid CustomerId { get; set; }
        public double TotalMoney { get; set; }
        public CustomerModel Customer { get; set; }
    }
}
