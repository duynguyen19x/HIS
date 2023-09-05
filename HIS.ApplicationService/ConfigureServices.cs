using HIS.ApplicationService.Business;
using HIS.ApplicationService.Business.InOutStockType;
using HIS.ApplicationService.Business.Pharmaceuticals.InOutStocks;
using HIS.ApplicationService.Business.Pharmaceuticals.ItemStocks;
using HIS.ApplicationService.Business.MedicalRecords;
using HIS.ApplicationService.Business.PatientRecords;
using HIS.ApplicationService.Business.Patients;
using HIS.ApplicationService.Business.Pharmaceuticals.InOutStock;
using HIS.ApplicationService.Business.Pharmaceuticals.MedicineStock;
using HIS.ApplicationService.Business.Receptions;
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
using HIS.ApplicationService.Dictionaries.ItemGroups;
using HIS.ApplicationService.Dictionaries.ItemLines;
using HIS.ApplicationService.Dictionaries.ItemPricePolicies;
using HIS.ApplicationService.Dictionaries.ItemTypes;
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
using HIS.ApplicationService.Systems.AutoNumber;
using HIS.ApplicationService.Systems.Login;
using HIS.ApplicationService.Systems.Role;
using HIS.ApplicationService.Systems.User;
using HIS.EntityFrameworkCore.Entities.Business;
using Microsoft.Extensions.DependencyInjection;

namespace HIS.ApplicationService
{
    public static class ConfigureServices
    {
        public static void ServiceCollection(this IServiceCollection services)
        {
            services.AddTransient<ILoginService, LoginService>();
            services.AddTransient<IRoleService, RoleService>();

            services.AddTransient<IBranchService, BranchService>();
            services.AddTransient<ICareerService, CareerService>();
            services.AddTransient<ICountryService, CountryService>();
            services.AddTransient<IDepartmentService, DepartmentService>();
            services.AddTransient<IDepartmentTypeService, DepartmentTypeService>();
            services.AddTransient<IDistrictService, DistrictService>();
            services.AddTransient<IEthnicService, EthnicService>();
            services.AddTransient<IGenderService, GenderService>();
            services.AddTransient<IRoomService, RoomService>();
            services.AddTransient<IRoomTypeService, RoomTypeService>();
            services.AddTransient<IHospitalService, HospitalService>();

            services.AddTransient<IIcdService, IcdService>();
            services.AddTransient<IProvinceService, ProvinceService>();
            services.AddTransient<IWardService, WardService>();
            services.AddTransient<IServicePricePolicyService, ServicePricePolicyService>();
            services.AddTransient<IServiceService, ServiceService>();
            services.AddTransient<ISurgicalProcedureTypeService, SurgicalProcedureTypeService>();
            services.AddTransient<IServiceGroupService, ServiceGroupService>();
            services.AddTransient<IServiceGroupHeInService, ServiceGroupHeInService>();
            services.AddTransient<IUnitService, UnitService>();
            services.AddTransient<IChapterIcdService, ChapterIcdService>();
            services.AddTransient<ISupplierService, SupplierService>();
            services.AddTransient<IUserService, UserService>();

            services.AddTransient<IItemGroupService, ItemGroupService>();
            services.AddTransient<IItemTypeService, ItemTypeService>();
            services.AddTransient<IItemLineService, ItemLineService>();
            services.AddTransient<IItemPricePolicyService, ItemPricePolicyService>();

            services.AddTransient<IInOutStockTypeService, InOutStockTypeService>();
            services.AddTransient<IInOutStockService, InOutStockService>();
            services.AddTransient<IItemStockService, ItemStockService>();

            services.AddTransient<IMedicalRecordAppService, MedicalRecordAppService>();
            services.AddTransient<IMedicalRecordExamAppService, MedicalRecordExamAppService>();
            services.AddTransient<IPatientRecordAppService, PatientRecordAppService>();
            services.AddTransient<IPatientAppService, PatientAppService>();
            services.AddTransient<IReceptionAppService, ReceptionAppService>();

            #region Sys
            services.AddTransient<ISYSAutoNumberAppService, SYSAutoNumberAppService>();
            #endregion
        }
    }
}
