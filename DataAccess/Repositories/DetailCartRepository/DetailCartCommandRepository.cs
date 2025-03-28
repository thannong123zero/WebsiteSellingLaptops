﻿using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IDetailCartRepository;
using DataAccess.Repositories.GeneralRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.DetailCartRepository
{
    public class DetailCartCommandRepository : GeneralCommandRepository<DetailCartModel>, IDetailCartCommandRepository
    {
        public DetailCartCommandRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
