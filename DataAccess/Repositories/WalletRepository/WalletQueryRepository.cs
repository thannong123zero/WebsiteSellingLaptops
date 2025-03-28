﻿using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IWalletRepository;
using DataAccess.Repositories.GeneralRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.WalletRepository
{
    public class WalletQueryRepository : GeneralQueryRepository<WalletModel>, IWalletQueryRepository
    {
        public WalletQueryRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
