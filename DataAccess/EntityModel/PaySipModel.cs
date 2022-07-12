using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class PaySipModel
    {
        public Guid Id { get; set; }
        public double Money { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
