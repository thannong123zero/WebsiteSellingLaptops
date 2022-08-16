using BusinessLogic.ViewModel;
using DataAccess.EntityModel;
using DataAccess.IRepositories.IUserRepository;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.User.Query.Login
{
    public class LoginHandler : IRequestHandler<LoginRequest, LoginResponseViewModel>
    {
        private readonly IUserQueryRepository _userQueryRepository;
        private readonly UserManager<UserModel> _userManager;
        //private readonly ILogger<LoginHandler> _logger;
        private readonly IConfiguration _configuration;


        private const string _loginProvider = "MyShop";
        private const string _refreshToken = "RefreshToken";

        public LoginHandler(IUserQueryRepository userQueryRepository, IConfiguration configuration, UserManager<UserModel> userManager)
        {
            _userQueryRepository = userQueryRepository;
            _userManager = userManager;
            _configuration = configuration;
        }

        public async Task<LoginResponseViewModel> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            UserModel user = await _userManager.FindByEmailAsync(request.Email);
            //UserModel user =  _userQueryRepository.Find(s => s.Email == request.Email,withDeleteFlag: false).FirstOrDefault();
            bool isValidUser = await _userManager.CheckPasswordAsync(user, request.Password);

            if (user == null || isValidUser == false)
            {
                throw new Exception($"User with email {request.Email} was not found");
            }

            var token = await GenerateToken(user);

            var login = new LoginResponseViewModel();

            login.Token = token;
            login.UserId = user.Id.ToString();
            login.RefreshToken = await CreateRefreshToken(user);
            

            return login;
        }
        private async Task<string> GenerateToken(UserModel user)
        {
            var securitykey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Key"]));

            var credentials = new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha256);

            var roles = await _userManager.GetRolesAsync(user);
            var roleClaims = roles.Select(x => new Claim(ClaimTypes.Role, x)).ToList();
            var userClaims = await _userManager.GetClaimsAsync(user);

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("uid", user.Id.ToString()),
            }
            .Union(userClaims).Union(roleClaims);

            var token = new JwtSecurityToken(
                issuer: _configuration["JwtSettings:Issuer"],
                audience: _configuration["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToInt32(_configuration["JwtSettings:DurationInMinutes"])),
                signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        public async Task<string> CreateRefreshToken(UserModel user)
        {
            try
            {
            await _userManager.RemoveAuthenticationTokenAsync(user, _loginProvider, _refreshToken);
            var newRefreshToken = await _userManager.GenerateUserTokenAsync(user, _loginProvider, _refreshToken);
            var result = await _userManager.SetAuthenticationTokenAsync(user, _loginProvider, _refreshToken, newRefreshToken);
                return newRefreshToken;
            }catch(Exception error)
            {
                throw new Exception(error.Message.ToString());
            }
            return null;
        }
    }
}
