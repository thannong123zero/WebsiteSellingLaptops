using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZWA.Core.Domain.Abstractions;

namespace DataAccess.IRepositories.IGeneralRepository
{
    public interface IGeneralCommandRepository<Entity> where Entity : class //, IIdentity<Guid>
    {
        void Add(params Entity[] entity);
        void Update(params Entity[] entity);
        void Delete(params Entity[] entity);
        void SoftDelete(params Entity[] entity);
        void RestoreDelete(params Entity[] entity);
    }
}
