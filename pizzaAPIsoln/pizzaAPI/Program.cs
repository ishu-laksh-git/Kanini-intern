using Microsoft.EntityFrameworkCore;
using pizzaAPI.Interfaces;
using pizzaAPI.Models;
using pizzaAPI.Services;

namespace pizzaAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<Context>(opts =>
            {
                opts.UseSqlServer(builder.Configuration.GetConnectionString("conn"));
            });
            builder.Services.AddScoped<IBaseRepo<string, Pizza>, pizzaRepo>();
            builder.Services.AddScoped<IRepo<string,Pizza>, pizzaRepo>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}