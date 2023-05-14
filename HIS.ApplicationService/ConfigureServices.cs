using HIS.ApplicationService.Dictionaries.Branch;
using HIS.ApplicationService.Dictionaries.Country;
using HIS.ApplicationService.Dictionaries.Department;
using HIS.ApplicationService.Dictionaries.District;
using HIS.ApplicationService.Dictionaries.Ethnic;
using HIS.ApplicationService.Dictionaries.Hospital;
using HIS.ApplicationService.Dictionaries.Icd;
using HIS.ApplicationService.Dictionaries.Job;
using HIS.ApplicationService.Dictionaries.Province;
using HIS.ApplicationService.Dictionaries.Room;
using HIS.ApplicationService.Dictionaries.Ward;
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
            services.AddTransient<ISCountryService, SCountryService>();
            services.AddTransient<ISDepartmentService, SDepartmentService>();
            services.AddTransient<ISDistrictService, SDistrictService>();
            services.AddTransient<ISEthnicService, SEthnicService>();
            services.AddTransient<ISRoomService, SRoomService>();
            services.AddTransient<ISHospitalService, SHospitalService>();
            services.AddTransient<ISIcdService, SIcdService>();
            services.AddTransient<ISJobService, SJobService>();
            services.AddTransient<ISProvinceService, SProvinceService>();
            services.AddTransient<ISWardService, SWardService>();
        }
    }
}
