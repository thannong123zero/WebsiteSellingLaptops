﻿using DataAccess.EntityModel;
using DataAccess.IRepositories.IGeneralRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories.IWareHouseRepository
{
    public interface IWareHouseQueryRepository : IGeneralQueryRepository<WareHouseModel>
    {
    }
}
