using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IUserRepository;
using DataAccess.Repositories.GeneralRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.UserRepository
{
    public class UserQueryRepository : GeneralQueryRepository<UserModel>, IUserQueryRepository
    {
        public UserQueryRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
