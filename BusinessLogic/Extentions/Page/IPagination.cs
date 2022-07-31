using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Extentions.Page
{
    public interface IPagination
    {
        public int PageIndex { get; }

        public int PageSize { get; }
    }
}
