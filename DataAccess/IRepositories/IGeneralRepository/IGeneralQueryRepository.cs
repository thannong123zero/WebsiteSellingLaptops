using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.IRepositories.IGeneralRepository
{
    public interface IGeneralQueryRepository<Entity> where Entity : class 
    {
        List<Entity> GetAll(Func<IQueryable<Entity>, IIncludableQueryable<Entity, object>> includeEntities = null,
            bool disableChangeTracker = true, bool withDeleteFlag = true);

        Task<List<Entity>> GetAllAsync(Func<IQueryable<Entity>, IIncludableQueryable<Entity, object>> includeEntities = null,
            bool disableChangeTracker = true, bool withDeleteFlag = true);

        Entity GetById(Guid id, Func<IQueryable<Entity>, IIncludableQueryable<Entity, object>> includeEntities = null,
            bool disableChangeTracker = true, bool withDeleteFlag = true);

        Task<Entity> GetByIdAsync(Guid id, Func<IQueryable<Entity>, IIncludableQueryable<Entity, object>> includeEntities = null,
            bool disableChangeTracker = true, bool withDeleteFlag = true);

        IQueryable<Entity> GetWhereMultiple(Func<IQueryable<Entity>, IIncludableQueryable<Entity, object>> includeEntities = null,
            bool disableChangeTracker = true, bool withDeleteFlag = true);

        IQueryable<Entity> GetWhereSingle(Func<IQueryable<Entity>, IIncludableQueryable<Entity, object>> includeEntities = null,
            bool disableChangeTracker = true, bool withDeleteFlag = true);

        IQueryable<Entity> InitQuery(Func<IQueryable<Entity>, IIncludableQueryable<Entity, object>> includeEntities = null,
            bool disableChangeTracker = true, bool withDeleteFlag = true,
            params Expression<Func<Entity, bool>>[] filters);
    }
}
