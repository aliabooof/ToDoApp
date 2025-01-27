using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Infrastructure.Data;

namespace TodoApp.Infrastructure.ExtensionMethods
{
    public static class ServicesAndConfigurations 
    {
        public static IServiceCollection  LoadServicesAndConfigs(this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));




            return services;
        }



    }
}
