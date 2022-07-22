using DataAccess.DBContext;
using DataAccess.EntityModel;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebsiteSellingLaptops;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(configuration["ConnectionStrings:LinkSQL"]));
//builder.Services.AddDbContext<DatabaseContext>(options =>
//    options.UseSqlServer(
//        configuration["ConnectionStrings:LinkSQL"],
//        b => b.MigrationsAssembly(typeof(DatabaseContext).Assembly.FullName)));

//builder.Services.AddIdentity<UserModel, IdentityRole<Guid>>()
//    .AddEntityFrameworkStores<DatabaseContext>()
//    .AddDefaultTokenProviders();


builder.Services.SignUpSerVice();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
    
app.UseAuthorization();

app.MapControllers();

app.Run();
