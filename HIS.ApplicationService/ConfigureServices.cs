using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Core.Domain.Uow;
using HIS.Core.ObjectMapping;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace HIS.ApplicationService
{
    public static class ConfigureServices
    {
        public static void ServiceCollection(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var interfaceTypes = assembly.GetTypes().Where(type => type.IsInterface).ToList();

            foreach (var interfaceType in interfaceTypes)
            {
                var implementingTypes = assembly.GetTypes()
                    .Where(type => interfaceType.IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract)
                    .ToList();

                foreach (var implementingType in implementingTypes)
                {
                    //services.AddTransient(interfaceType, implementingType);
                    services.AddTransient(implementingType);
                    services.AddTransient(interfaceType, provider =>
                    {
                        var imp = provider.GetService(implementingType);
                        // đặt giá trị cho service
                        if (imp is Core.Application.Services.BaseAppService appService)
                        {
                            appService.ObjectMapper = provider.GetService(typeof(IObjectMapper)) as IObjectMapper;
                            appService.UnitOfWorkManager = provider.GetService(typeof(IUnitOfWorkManager)) as IUnitOfWorkManager;
                        }

                        return imp;
                    });
                }
            }
        }
    }
}
