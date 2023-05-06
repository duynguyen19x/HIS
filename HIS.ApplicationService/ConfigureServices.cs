using HIS.ApplicationService.Dictionaries.Branch;
using HIS.ApplicationService.Dictionaries.Department;
using HIS.ApplicationService.Dictionaries.Room;
using HIS.ApplicationService.Systems.Login;
using HIS.ApplicationService.Systems.Role;
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
            services.AddTransient<IRoleService, RoleService>();

            services.AddTransient<ISBranchService, SBranchService>();
            services.AddTransient<ISDepartmentService, SDepartmentService>();
            services.AddTransient<ISRoomService, SRoomService>();
        }
    }
}
