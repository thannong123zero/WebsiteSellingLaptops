﻿using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IMethodKindRepository;
using DataAccess.Repositories.GeneralRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.MethodKindRepository
{
    public class MethodKindQueryRepository : GeneralQueryRepository<MethodKindModel>, IMethodKindQueryRepository
    {
        public MethodKindQueryRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
