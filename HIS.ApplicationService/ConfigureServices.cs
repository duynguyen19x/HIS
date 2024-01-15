﻿using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace HIS.ApplicationService
{
    public static class ConfigureServices
    {
        //public static void ServiceCollection(this IServiceCollection services)
        //{
        //    services.AddTransient<ILoginService, LoginService>();
        //    services.AddTransient<IRoleService, RoleService>();

        //    services.AddTransient<IBranchAppService, BranchAppService>();
        //    services.AddTransient<ICareerService, CareerService>();
        //    services.AddTransient<ICountryService, CountryService>();
        //    services.AddTransient<IDepartmentService, DepartmentService>();
        //    services.AddTransient<IDepartmentTypeService, DepartmentTypeService>();
        //    services.AddTransient<IDistrictService, DistrictService>();
            
        //    services.AddTransient<IGenderAppService, GenderAppService>();
        //    services.AddTransient<IRoomAppService, RoomAppService>();
        //    services.AddTransient<IRoomTypeService, RoomTypeService>();
        //    services.AddTransient<IHospitalService, HospitalService>();

        //    services.AddTransient<IIcdService, IcdService>();
        //    services.AddTransient<IProvinceAppService, ProvinceAppService>();
        //    services.AddTransient<IWardAppService, WardAppService>();
        //    services.AddTransient<IServicePricePolicyService, ServicePricePolicyService>();
        //    services.AddTransient<IServiceService, ServiceService>();
        //    services.AddTransient<ISurgicalProcedureTypeService, SurgicalProcedureTypeService>();
        //    services.AddTransient<IServiceGroupService, ServiceGroupService>();
        //    services.AddTransient<IServiceGroupHeInService, ServiceGroupHeInService>();
        //    services.AddTransient<IUnitService, UnitService>();
        //    services.AddTransient<IChapterIcdService, ChapterIcdService>();
        //    services.AddTransient<ISupplierService, SupplierService>();
        //    services.AddTransient<IUserService, UserService>();

        //    services.AddTransient<IItemGroupService, ItemGroupService>();
        //    services.AddTransient<IItemTypeService, ItemTypeService>();
        //    services.AddTransient<IItemLineService, ItemLineService>();
        //    services.AddTransient<IItemPricePolicyService, ItemPricePolicyService>();

        //    services.AddTransient<IInOutStockTypeService, InOutStockTypeService>();
        //    services.AddTransient<IInOutStockService, InOutStockService>();
        //    services.AddTransient<IItemStockService, ItemStockService>();

        //    #region - Nghiệp vụ

        //    #endregion

        //    #region - Danh mục

        //    services.AddTransient<IEthnicAppService, EthnicAppService>();
        //    services.AddTransient<IRelativeTypeAppService, RelativeTypeAppService>();
        //    //services.AddTransient<IRelativeTypeAppService, RelativeTypeAppService>();

        //    #endregion

        //    #region Sys
        //    services.AddTransient<IDbOptionAppService, DbOptionAppService>();
        //    #endregion
        //}

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
                    services.AddTransient(interfaceType, implementingType);
                }
            }
        }
    }
}
