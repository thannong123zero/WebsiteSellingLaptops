using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Extentions.Sort
{
    public class Sorting : ISorting
    {
        public string SortName { get; set; } = "CreateAt";
        public bool SortByAscending { get; set; } = true;

    }
}
