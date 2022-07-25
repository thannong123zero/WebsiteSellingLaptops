using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IUserRepository;
using DataAccess.Repositories.GeneralRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.UserRepository
{
    public class UserCommandRepository : GeneralCommandRepository<UserModel>, IUserCommandRepository
    {
        public UserCommandRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
