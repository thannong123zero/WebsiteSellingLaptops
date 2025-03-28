﻿using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IBillTypeRepository;
using DataAccess.Repositories.GeneralRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.BillTypeRepository
{
    public class BillTypeQueryRepository : GeneralQueryRepository<BillTypeModel>, IBillTypeQueryRepository
    {
        public BillTypeQueryRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
