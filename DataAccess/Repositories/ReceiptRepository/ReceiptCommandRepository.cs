﻿using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IReceiptRepository;
using DataAccess.Repositories.GeneralRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.ReceiptRepository
{
    public class ReceiptCommandRepository : GeneralCommandRepository<ReceiptModel>, IReceiptCommandRepository
    {
        public ReceiptCommandRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
