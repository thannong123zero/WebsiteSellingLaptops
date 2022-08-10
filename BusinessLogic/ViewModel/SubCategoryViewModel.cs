using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModel
{
    public class SubCategoryViewModel
    {
        public int Id { get; set; }
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
