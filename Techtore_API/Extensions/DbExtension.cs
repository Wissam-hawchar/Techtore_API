using Microsoft.EntityFrameworkCore;
using TechTore_DAL.Models;

namespace Techtore_API.Extensions
{
    public static class DbExtension
    {
        public static IServiceCollection CSTMAddDb(this IServiceCollection services, ConfigurationManager config)
        {
            var ConnectionString = config.GetConnectionString("DefaultConnection");
            // Add services to the container.
            services.AddDbContext<Test1Context>(options => options.UseSqlServer(ConnectionString));
            return services;
        }
    }
}
