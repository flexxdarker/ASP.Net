using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;


namespace BusinessLogic
{
    public static class ServiceExtensions
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        public static void AddFluentValidators(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation();
            // enable client-side validation
            services.AddFluentValidationClientsideAdapters();
            // Load an assembly reference rather than using a marker type.
            services.AddValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
        }
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IProductsService, ProductService>();
            services.AddScoped<IHomeService, HomeService>();
            services.AddScoped<IOrdersService, OrdersService>();
        }
    }
}
