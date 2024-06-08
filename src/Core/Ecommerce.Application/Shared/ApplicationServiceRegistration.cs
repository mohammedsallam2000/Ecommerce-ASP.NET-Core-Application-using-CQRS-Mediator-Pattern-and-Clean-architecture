using Ecommerce.Application.MappingProfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Shared
{
    public static class ApplicationServiceRegistration
    {
        public static void ConfigureApplicationService(this IServiceCollection  services)
        {
            //Configure AutoMapper
            // 3 wayes to Configure
            //services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddAutoMapper(typeof(CategoryMappingProfile));

        }
    }
}
