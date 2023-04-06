using Microsoft.EntityFrameworkCore;
using reposatywithuow.Entities.Context;

namespace reposatywithuow.Extensions
{
    public static class ServiceExtensions
    {

        public static void configureSqlContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationContext>(o => o.UseSqlServer(connectionString));
        }
    }
}
