using DataAccess.DBContext;
using DataAccess.EntityModel;
using MediatR;
using WebsiteSellingLaptops.MiddleWare;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebsiteSellingLaptops;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.SignUpSerVice();
builder.Services.AddAuthentication(options => {
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme; // "Bearer"
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options => {
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero,
        ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
        ValidAudience = builder.Configuration["JwtSettings:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtSettings:Key"]))
    };
});

//builder.Services.Configure<IdentityOptions>(options => {
//    // Thiết lập về Password
//    options.Password.RequireDigit = false; // Không bắt phải có số
//    options.Password.RequireLowercase = false; // Không bắt phải có chữ thường
//    options.Password.RequireNonAlphanumeric = false; // Không bắt ký tự đặc biệt
//    options.Password.RequireUppercase = false; // Không bắt buộc chữ in
//    options.Password.RequiredLength = 3; // Số ký tự tối thiểu của password
//    options.Password.RequiredUniqueChars = 1; // Số ký tự riêng biệt

//    // Cấu hình Lockout - khóa user
//    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5); // Khóa 5 phút
//    options.Lockout.MaxFailedAccessAttempts = 5; // Thất bại 5 lầ thì khóa
//    options.Lockout.AllowedForNewUsers = true;

//    // Cấu hình về User.
//    options.User.AllowedUserNameCharacters = // các ký tự đặt tên user
//        "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
//    options.User.RequireUniqueEmail = true;  // Email là duy nhất

//    // Cấu hình đăng nhập.
//    options.SignIn.RequireConfirmedEmail = true;            // Cấu hình xác thực địa chỉ email (email phải tồn tại)
//    options.SignIn.RequireConfirmedPhoneNumber = false;     // Xác thực số điện thoại

//});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseMiddleware<ExceptionHandlerMiddleware>()
			   .UseHttpsRedirection()
			   .UseForwardedHeaders()
			   .UseResponseCaching()
			   .UseAuthentication()
			   .UseAuthorization();
			   

app.UseHttpsRedirection();


app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
