﻿using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IManufactoringRepository;
using DataAccess.Repositories.GeneralRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.ManufactoringRepository
{
    public class ManufactoringQueryRepository : GeneralQueryRepository<ManufactoringModel>, IManufactoringQueryRepository
    {
        public ManufactoringQueryRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
