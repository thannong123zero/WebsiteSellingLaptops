using DataAccess.DBContext;
using DataAccess.IRepositories.IGeneralRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Query;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ZWA.Core.Domain.Abstractions;
// ?
using System.Linq.Dynamic.Core;

namespace DataAccess.Repositories.GeneralRepository
{
    public class GeneralQueryRepository<Entity> : IGeneralQueryRepository<Entity> where Entity : class //, IIdentity<Guid>
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<Entity> _dbSet;

        public GeneralQueryRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<Entity>();
        }

        public List<Entity> GetAll(Func<IQueryable<Entity>, IIncludableQueryable<Entity, object>> includeEntities = null,
            bool disableChangeTracker = true, bool withDeleteFlag = true)
        {
            return InitQuery(includeEntities, disableChangeTracker, withDeleteFlag).ToList();
        }

        public async Task<List<Entity>> GetAllAsync(
            Func<IQueryable<Entity>, IIncludableQueryable<Entity, object>> includeEntities = null,
            bool disableChangeTracker = true, bool withDeleteFlag = true)
        {
            return await InitQuery(includeEntities, disableChangeTracker, withDeleteFlag).ToListAsync();
        }

        public Entity GetById(Guid id,
            Func<IQueryable<Entity>, IIncludableQueryable<Entity, object>> includeEntities = null,
            bool disableChangeTracker = true, bool withDeleteFlag = true)
        {
            //return InitQuery(includeEntities, disableChangeTracker, withDeleteFlag, filters: ex => ex.Id == id)
            //    .SingleOrDefault();
            throw new NotImplementedException();
        }

        public async Task<Entity> GetByIdAsync(Guid id,
            Func<IQueryable<Entity>, IIncludableQueryable<Entity, object>> includeEntities = null,
            bool disableChangeTracker = true, bool withDeleteFlag = true)
        {
            //return await InitQuery(includeEntities, disableChangeTracker, withDeleteFlag, filters: ex => ex.Id == id)
            //    .SingleOrDefaultAsync();
            throw new NotImplementedException();
        }

        public IQueryable<Entity> GetWhereMultiple(
            Func<IQueryable<Entity>, IIncludableQueryable<Entity, object>> includeEntities = null,
            bool disableChangeTracker = true, bool withDeleteFlag = true,
            params Expression<Func<Entity, bool>>[] filters)
        {
            return InitQuery(includeEntities, disableChangeTracker, withDeleteFlag, filters);
        }

        public IQueryable<Entity> Find(Expression<Func<Entity, bool>> filter,
            Func<IQueryable<Entity>, IIncludableQueryable<Entity, object>> includeEntities = null,
            bool disableChangeTracker = true, bool withDeleteFlag = true)
        {
            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            return InitQuery(includeEntities, disableChangeTracker, withDeleteFlag, filters: filter);
        }

        public IQueryable<Entity> InitQuery(
            Func<IQueryable<Entity>, IIncludableQueryable<Entity, object>> includeEntities = null,
            bool disableChangeTracker = true, bool withDeleteFlag = true,
            params Expression<Func<Entity, bool>>[] filters)
        {
            var query = _dbSet.AsQueryable();

            if (includeEntities != null)
            {
                query = includeEntities(query);
            }
            if (withDeleteFlag)
            {
                query = query.Where("IsDelete = @0", false);
            }

            filters.ToList().ForEach(filter =>
            {
                query = query.Where(filter);
            });


            if (disableChangeTracker)
            {
                query = query.AsNoTracking();
            }

            return query;
        }

        public IQueryable<Entity> GetWhereSingle(Func<IQueryable<Entity>, IIncludableQueryable<Entity, object>> includeEntities = null, bool disableChangeTracker = true, bool withDeleteFlag = true)
        {
            throw new NotImplementedException();
        }
    }
}
