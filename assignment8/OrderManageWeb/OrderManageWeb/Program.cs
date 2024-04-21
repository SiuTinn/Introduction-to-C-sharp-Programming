using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrderManageWeb.Models;  // Use your actual namespace where OrderContext is defined

namespace OrderManage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Add DbContext to the DI container
            builder.Services.AddDbContext<OrderContext>(opt => opt.UseMySQL(
                "Server=localhost;Database=todoDB;User=root;Password=root"));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseDefaultFiles(); // Enables default static files (index.html or index.htm)
            app.UseStaticFiles(); // Enable serving static files (front-end files like pages, js, images, etc.)

            app.UseHttpsRedirection(); // Enable HTTP to HTTPS redirection
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
