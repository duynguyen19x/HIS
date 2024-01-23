using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.WebApi.Dynamic
{
    public static class DynamicWebApiServiceExtensions
    {
        public static IServiceCollection AddDynamicWebApi(this IServiceCollection services)
        {
            return services;
        }
    }
}
