using HIS.ApplicationService.Systems.Login;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService
{
    public static class ConfigureServices
    {
        public static void ServiceCollection(this IServiceCollection services)
        {
            services.AddTransient<ILoginService, LoginService>();
        }
    }
}
