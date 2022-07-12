using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityModel
{
    public class GoodsReceiptNoteModel
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
