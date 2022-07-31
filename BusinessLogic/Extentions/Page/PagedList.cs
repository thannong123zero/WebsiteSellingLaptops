using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Extentions.Page
{
    public class PagedList<T> : IPagination
    {
        public PagedList(IQueryable<T> query, int? pageIndex = null, int? pageSize = null)
        {
            PageIndex = pageIndex ?? 0;
            PageSize = (!pageSize.HasValue || pageSize == 0) ? Constants.ApplicationSettings.DefaultValues.PageSize : pageSize.Value;
            TotalItems = query.Count();
            TotalPages = TotalItems / PageSize;

            if (TotalItems % PageSize > 0)
            {
                TotalPages++;
            }

            Source = query.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToArray();
        }

        public T[] Source { get; }

        public int PageIndex { get; }

        public int PageSize { get; }

        public int TotalItems { get; }

        public int TotalPages { get; }
    }
}
