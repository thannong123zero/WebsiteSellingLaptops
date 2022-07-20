﻿using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IManufactoringRepository;
using DataAccess.Repositories.GeneralRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.ManufactoringRepository
{
    public class ManufactoringCommandRepository : GeneralCommandRepository<ManufactoringModel>, IManufactoringCommandRepository
    {
        public ManufactoringCommandRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
