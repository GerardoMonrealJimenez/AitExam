using Ait.DataAccess;
using Ait.DataAccess.Repository;
using Ait.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ait.Business;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AitInjection
    {
        public static void AddServicesAit(this IServiceCollection services, string connectionString)
        {
            services.AddTransient<IRepository<Users>, UserRepository>();
            services.AddTransient<IRepository<Products>, ProductRepository>();
            services.AddTransient<IUserBusiness, UserBusiness>();
            services.AddTransient<IProductBusiness, ProductBusiness>();
            services.AddDbContext<AitContext>(options => options.UseSqlServer(connectionString, options => options.MigrationsAssembly("Ait.WebApi")));
        }
    }
}
