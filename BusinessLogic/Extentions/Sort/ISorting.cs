using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Extentions.Sort
{
    public interface ISorting
    {
        string SortName { get; set; }

        bool SortByAscending { get; set; }
    }
}
