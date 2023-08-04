using HIS.Core.Repositories;
using HIS.EntityFrameworkCore.Entities.Business.Patients;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.EntityFrameworkCore.Repositories
{
    public static class HISRepositoryManager
    {
        public static void AddRepository(this IServiceCollection services)
        {
            //services.AddTransient<IRepository<,>, HISRepository<,>>();

            services.AddTransient<IRepository<SPatient, Guid>, HISRepository<SPatient, Guid>>();
        }
    }
}
