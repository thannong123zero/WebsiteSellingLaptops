using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZWA.Core.Domain.Abstractions;

namespace DataAccess.EntityModel
{
    public class RoleModel : IdentityRole<Guid>, IIdentity<Guid>
    {

    }
}
