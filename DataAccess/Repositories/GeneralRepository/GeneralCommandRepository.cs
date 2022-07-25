using DataAccess.DBContext;
using DataAccess.IRepositories.IGeneralRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZWA.Core.Domain.Abstractions;

namespace DataAccess.Repositories.GeneralRepository
{
    public class GeneralCommandRepository<Entity> : IGeneralCommandRepository<Entity> where Entity : class //, IIdentity<Guid>
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<Entity> _dbSet;

        public GeneralCommandRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<Entity>();
        }

        public void Add(params Entity[] entity)
        {
            PerformDbOperation(_dbSet.Add, entity);
        }

        public void Delete(params Entity[] entity)
        {
            PerformDbOperation(_dbSet.Remove, entity);
        }

        public void RestoreDelete(params Entity[] entity)
        {
            foreach (var e in entity)
            {
                var property = typeof(Entity).GetProperty("IsDelete");
                if (property != null)
                {
                    property.SetValue(e, true);
                }
            }
            PerformDbOperation(_dbSet.Update, entity);
        }

        public void SoftDelete(params Entity[] entity)
        {
            foreach (var e in entity)
            {
                var property = typeof(Entity).GetProperty("IsDelete");
                if (property != null)
                {
                    property.SetValue(e, false);
                }
            }
            PerformDbOperation(_dbSet.Update, entity);
        }

        public void Update(params Entity[] entity)
        {
            PerformDbOperation(_dbSet.Update, entity);
        }
        private void PerformDbOperation(Func<Entity, EntityEntry<Entity>> dbOperation, params Entity[] entities)
        {
            if (dbOperation == null)
            {
                throw new ArgumentNullException(nameof(dbOperation));
            }

            if (entities == null)
            {
                throw new ArgumentNullException(nameof(entities));
            }

            if (entities.Any(ex => ex == null))
            {
                throw new ArgumentNullException(nameof(entities));
            }

            foreach (var entity in entities)
            {
                dbOperation(entity);
            }
        }
    }
}
