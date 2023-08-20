﻿using HIS.ApplicationService.Business.DImpExpMestType;
using HIS.ApplicationService.Business.Pharmaceuticals.DMedicineStock;
using HIS.ApplicationService.Business.Pharmaceuticals.DImpMests;
using HIS.ApplicationService.Dictionaries.Branch;
using HIS.ApplicationService.Dictionaries.Career;
using HIS.ApplicationService.Dictionaries.ChapterICD10;
using HIS.ApplicationService.Dictionaries.Country;
using HIS.ApplicationService.Dictionaries.Department;
using HIS.ApplicationService.Dictionaries.DepartmentType;
using HIS.ApplicationService.Dictionaries.District;
using HIS.ApplicationService.Dictionaries.Ethnic;
using HIS.ApplicationService.Dictionaries.Gender;
using HIS.ApplicationService.Dictionaries.Hospital;
using HIS.ApplicationService.Dictionaries.Icd;
using HIS.ApplicationService.Dictionaries.MedicineGroup;
using HIS.ApplicationService.Dictionaries.MedicineLine;
using HIS.ApplicationService.Dictionaries.MedicinePricePolicy;
using HIS.ApplicationService.Dictionaries.MedicineType;
using HIS.ApplicationService.Dictionaries.Province;
using HIS.ApplicationService.Dictionaries.Room;
using HIS.ApplicationService.Dictionaries.RoomType;
using HIS.ApplicationService.Dictionaries.Service;
using HIS.ApplicationService.Dictionaries.ServiceGroup;
using HIS.ApplicationService.Dictionaries.ServiceGroupHeIn;
using HIS.ApplicationService.Dictionaries.ServicePricePolicy;
using HIS.ApplicationService.Dictionaries.Supplier;
using HIS.ApplicationService.Dictionaries.SurgicalProcedureType;
using HIS.ApplicationService.Dictionaries.Unit;
using HIS.ApplicationService.Dictionaries.Ward;
using HIS.ApplicationService.Systems.Login;
using HIS.ApplicationService.Systems.Role;
using HIS.ApplicationService.Systems.User;
using Microsoft.Extensions.DependencyInjection;
using HIS.ApplicationService.Systems.AutoNumber;
using HIS.ApplicationService.Business;

namespace HIS.ApplicationService
{
    public static class ConfigureServices
    {
        public static void ServiceCollection(this IServiceCollection services)
        {
            services.AddTransient<ILoginService, LoginService>();
            services.AddTransient<IRoleService, RoleService>();

            services.AddTransient<ISBranchService, SBranchService>();
            services.AddTransient<ISCareerService, SCareerService>();
            services.AddTransient<ISCountryService, SCountryService>();
            services.AddTransient<ISDepartmentService, SDepartmentService>();
            services.AddTransient<ISDepartmentTypeService, SDepartmentTypeService>();
            services.AddTransient<ISDistrictService, SDistrictService>();
            services.AddTransient<ISEthnicService, SEthnicService>();
            services.AddTransient<ISGenderService, SGenderService>();
            services.AddTransient<ISRoomService, SRoomService>();
            services.AddTransient<ISRoomTypeService, SRoomTypeService>();
            services.AddTransient<ISHospitalService, SHospitalService>();

            services.AddTransient<ISIcdService, SIcdService>();
            services.AddTransient<ISProvinceService, SProvinceService>();
            services.AddTransient<ISWardService, SWardService>();
            services.AddTransient<ISServicePricePolicyService, SServicePricePolicyService>();
            services.AddTransient<IServiceService, ServiceService>();
            services.AddTransient<ISurgicalProcedureTypeService, SurgicalProcedureTypeService>();
            services.AddTransient<IServiceGroupService, ServiceGroupService>();
            services.AddTransient<IServiceGroupHeInService, ServiceGroupHeInService>();
            services.AddTransient<ISUnitService, SUnitService>();
            services.AddTransient<ISChapterIcdService, SChapterIcdService>();
            services.AddTransient<ISSupplierService, SSupplierService>();
            services.AddTransient<IUserService, UserService>();

            services.AddTransient<ISMedicineGroupService, SMedicineGroupService>();
            services.AddTransient<ISMedicineTypeService, SMedicineTypeService>();
            services.AddTransient<ISMedicineLineService, SMedicineLineService>();
            services.AddTransient<ISMedicinePricePolicyService, SMedicinePricePolicyService>();

            services.AddTransient<IDImpMestService, DImpMestService>();
            services.AddTransient<IDImpExpMestTypeService, DImpExpMestTypeService>();
            services.AddTransient<IDMedicineStockService, DMedicineStockService>();

            #region Patient
            services.AddTransient<IPatientAppService, PatientAppService>();
            services.AddTransient<IPatientRecordAppService, PatientRecordAppService>();
            #endregion

            #region Sys
            services.AddTransient<ISYSAutoNumberAppService, SYSAutoNumberAppService>();
            #endregion
        }
    }
}
