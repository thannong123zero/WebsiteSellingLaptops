using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IValletRepository;
using DataAccess.Repositories.GeneralRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.ValletRepository
{
    public class WalletCommandRepository : GeneralCommandRepository<WalletModel>, IWalletCommandRepository
    {
        public WalletCommandRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
