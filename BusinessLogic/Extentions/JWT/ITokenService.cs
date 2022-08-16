using DataAccess.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Extentions.JWT
{
    public interface ITokenService
    {
        public interface ITokenService
        {
            string BuildToken(string key, string issuer, UserModel user,string roles);
            bool ValidateToken(string key, string issuer, string audience, string token);
        }

        string BuildToken(string v1, string v2, UserModel validUser, string roles);
        bool IsTokenValid(string v1, string v2, string token);
    }
}
