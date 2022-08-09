using DataAccess.DBContext;
using DataAccess.EntityModel;
using MediatR;
using WebsiteSellingLaptops.MiddleWare;
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



builder.Services.SignUpSerVice();

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
    
app.UseAuthorization();

app.MapControllers();

app.Run();
