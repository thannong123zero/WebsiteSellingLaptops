using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DBContext;
using DataAccess.IRepositories;

namespace DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposed;
        private readonly DatabaseContext _databaseContext;
        public UnitOfWork(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public void SaveChanges()
        {
            _databaseContext.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _databaseContext.SaveChangesAsync();
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    //dispose managed resources
                }
            }
            //dispose unmanaged resources
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
