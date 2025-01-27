using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Core.Interfaces;
using TodoApp.Infrastructure.Data;
using TodoApp.Infrastructure.Repositories;

namespace TodoApp.Infrastructure.ExtensionMethods
{
    public static class ServicesAndConfigurations 
    {
        public static IServiceCollection  LoadServicesAndConfigs(this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<ApplicationContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<IToDoItemRepository, ToDoItemRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            

            return services;
        }



    }
}
