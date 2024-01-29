using BusinessLogic;
using DataAccess.Model.Data;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Model
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connStr = builder.Configuration.GetConnectionString("LocalDb");
            builder.Services.AddDbContext<ShopDbContext>(opts => opts.UseSqlServer(connStr));
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddAutoMapper();
            builder.Services.AddFluentValidators();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}