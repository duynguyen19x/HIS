﻿using HIS.Core.Domain.Uow;
using HIS.Core.ObjectMapping;
using HIS.Core.Runtime.Session;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using HIS.Core.Authorization;

namespace HIS.ApplicationService
{
    public static class ConfigureServices
    {
        public static void AddService(this IServiceCollection services)
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
                            appService.AppSession = provider.GetService(typeof(IAppSession)) as IAppSession;
                            appService.PermissionChecker = provider.GetService(typeof(IPermissionChecker)) as IPermissionChecker;
                        }

                        return imp;
                    });
                }
            }
        }
    }
}
