﻿using DataAccess.DBContext;
using DataAccess.EntityModel;
using DataAccess.IRepositories.ICartRepository;
using DataAccess.Repositories.GeneralRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.CartRepository
{
    public class CartCommandRepository : GeneralCommandRepository<CartModel>, ICartCommandRepository
    {
        public CartCommandRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
