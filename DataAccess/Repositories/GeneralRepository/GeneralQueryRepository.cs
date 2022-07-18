using DataAccess.DBContext;
using DataAccess.IRepositories.IGeneralRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.GeneralRepository
{
    public class GeneralQueryRepository<Entity> : IGeneralQueryRepository<Entity> where Entity : class //, IIdentity<Guid>
    {
        private readonly DatabaseContext _databaseContext;
        private readonly DbSet<Entity> _dbSet;
        public GeneralQueryRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _dbSet = databaseContext.Set<Entity>();
        }
        public List<Entity> GetAll(Func<IQueryable<Entity>, IIncludableQueryable<Entity, object>> includeEntities = null, bool disableChangeTracker = true, bool withDeleteFlag = true)
        {
            return InitQuery(includeEntities, disableChangeTracker, withDeleteFlag).ToList();
        }

        public async Task<List<Entity>> GetAllAsync(Func<IQueryable<Entity>, IIncludableQueryable<Entity, object>> includeEntities = null, bool disableChangeTracker = true, bool withDeleteFlag = true)
        {
            return await InitQuery(includeEntities, disableChangeTracker, withDeleteFlag).ToListAsync();
        }

        public Entity GetById(Guid id, Func<IQueryable<Entity>, IIncludableQueryable<Entity, object>> includeEntities = null, bool disableChangeTracker = true, bool withDeleteFlag = true)
        {
            //return InitQuery(includeEntities, disableChangeTracker, withDeleteFlag, filters: ex => ex.Id == id)
            //    .SingleOrDefault();
            throw new NotImplementedException();
        }

        public Task<Entity> GetByIdAsync(Guid id, Func<IQueryable<Entity>, IIncludableQueryable<Entity, object>> includeEntities = null, bool disableChangeTracker = true, bool withDeleteFlag = true)
        {
            //return await InitQuery(includeEntities, disableChangeTracker, withDeleteFlag, filters: ex => ex.Id == id)
            //    .SingleOrDefaultAsync();
            throw new NotImplementedException();
        }

        public IQueryable<Entity> GetWhereMultiple(Func<IQueryable<Entity>, IIncludableQueryable<Entity, object>> includeEntities = null, bool disableChangeTracker = true, bool withDeleteFlag = true)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Entity> GetWhereSingle(Func<IQueryable<Entity>, IIncludableQueryable<Entity, object>> includeEntities = null, bool disableChangeTracker = true, bool withDeleteFlag = true)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Entity> InitQuery(Func<IQueryable<Entity>, IIncludableQueryable<Entity, object>> includeEntities = null, bool disableChangeTracker = true, bool withDeleteFlag = true, params Expression<Func<Entity, bool>>[] filters)
        {
            throw new NotImplementedException();
        }
    }
}
