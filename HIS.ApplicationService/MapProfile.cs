using AutoMapper;
using HIS.Dtos.Business.InOutStockItems;
using HIS.Dtos.Business.ItemStocks;
using HIS.Dtos.Business.ServiceRequests;
using HIS.Dtos.Dictionaries.ChapterICD10;
using HIS.Dtos.Dictionaries.Countries;
using HIS.Dtos.Dictionaries.ExecutionRoom;
using HIS.Dtos.Dictionaries.ItemGroups;
using HIS.Dtos.Dictionaries.ItemPricePolicies;
using HIS.Dtos.Dictionaries.Items;
using HIS.Dtos.Dictionaries.ItemTypes;
using HIS.Dtos.Dictionaries.Province;
using HIS.Dtos.Dictionaries.ServiceResultIndex;
using HIS.Dtos.Dictionaries.Ward;
using HIS.Dtos.Systems.DbOption;
using HIS.EntityFrameworkCore.Entities.Business;
using HIS.EntityFrameworkCore.Entities.Categories.Items;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.Entities.System;
using HIS.EntityFrameworkCore.Views;
using HIS.ApplicationService.Systems.Roles.Dto;
using HIS.ApplicationService.Systems.Users.Dto;
using HIS.ApplicationService.Dictionary.Careers.Dto;
using HIS.EntityFrameworkCore.Entities.Dictionary;
using HIS.ApplicationService.Dictionary.Branchs.Dto;
using HIS.ApplicationService.Dictionary.Departments.Dto;
using HIS.ApplicationService.Dictionary.DepartmentTypes.Dto;
using HIS.ApplicationService.Dictionary.Ethnicities.Dto;
using HIS.ApplicationService.Systems.LayoutTemplates.Dto;
using HIS.ApplicationService.Dictionary.Rooms.Dto;
using HIS.ApplicationService.Dictionary.RoomTypes.Dto;
using HIS.ApplicationService.Dictionary.Units.Dto;
using HIS.ApplicationService.Dictionary.Services.Dto;
using HIS.ApplicationService.Dictionary.Suppliers.Dto;
using HIS.ApplicationService.Business.PatientRecords.Dto;
using HIS.ApplicationService.Dictionary.ServicePricePolicies.Dto;
using HIS.ApplicationService.Dictionary.Districts.Dto;
using HIS.ApplicationService.Dictionary.Genders.Dto;
using HIS.ApplicationService.Dictionary.Hospitals.Dto;
using HIS.ApplicationService.Dictionary.Icds.Dto;
using HIS.ApplicationService.Business.InOutStocks.Dto;
using HIS.ApplicationService.Dictionary.ServiceGroupHeIns.Dto;
using HIS.ApplicationService.Business.Patients.Dto;
using HIS.ApplicationService.Dictionary.ServiceGroups.Dto;

namespace HIS.ApplicationService
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Career, CareerDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            
            CreateMap<ChapterIcdDto, ChapterIcd>().ReverseMap();
            CreateMap<District, DistrictDto>().ReverseMap();
            CreateMap<Gender, GenderDto>().ReverseMap();
            CreateMap<Hospital, HospitalDto>().ReverseMap();
            CreateMap<Icd, IcdDto>().ReverseMap();
            CreateMap<DbOption, DbOptionDto>().ReverseMap();
            CreateMap<Province, ProvinceDto>().ReverseMap();
            
            CreateMap<Ward, WardDto>().ReverseMap();
            CreateMap<ServiceGroupDto, ServiceGroup>().ReverseMap();
            CreateMap<ServiceGroupHeInDto, ServiceGroupHeIn>().ReverseMap();
            CreateMap<UnitDto, Unit>().ReverseMap();
            CreateMap<ServiceDto, Service>()
                .ForMember(dest => dest.Unit, opt => opt.Ignore())
                .ForMember(dest => dest.ServiceGroup, opt => opt.Ignore())
                .ForMember(dest => dest.SurgicalProcedureType, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<ServicePricePolicyDto, ServicePricePolicy>()
               .ForMember(dest => dest.PatientType, opt => opt.Ignore())
               .ForMember(dest => dest.Service, opt => opt.Ignore())
               .ReverseMap();

            CreateMap<ExecutionRoomDto, ExecutionRoom>()
                .ForMember(dest => dest.Service, opt => opt.Ignore())
                .ForMember(dest => dest.Room, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<ServiceResultIndiceDto, ServiceResultIndice>()
             .ForMember(dest => dest.Service, opt => opt.Ignore())
             .ReverseMap();

            CreateMap<ItemGroupDto, ItemGroup>()
                .ReverseMap();
            CreateMap<ItemTypeDto, ItemType>()
                .ForMember(dest => dest.Unit, opt => opt.Ignore())
                .ForMember(dest => dest.ItemLine, opt => opt.Ignore())
                .ForMember(dest => dest.ItemGroup, opt => opt.Ignore())
                .ForMember(dest => dest.Country, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<SupplierDto, Supplier>()
                .ReverseMap();

            CreateMap<InOutStockItemDto, Item>()
                .ForMember(dest => dest.ItemType, opt => opt.Ignore())
                .ForMember(dest => dest.Unit, opt => opt.Ignore())
                .ForMember(dest => dest.ItemLine, opt => opt.Ignore())
                .ForMember(dest => dest.Country, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<ItemDto, Item>()
                .ForMember(dest => dest.ItemType, opt => opt.Ignore())
                .ForMember(dest => dest.Unit, opt => opt.Ignore())
                .ForMember(dest => dest.ItemLine, opt => opt.Ignore())
                .ForMember(dest => dest.Country, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<ItemPricePolicyDto, ItemPricePolicy>()
                .ForMember(dest => dest.Item, opt => opt.Ignore())
                .ForMember(dest => dest.PatientType, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<InOutStockDto, InOutStock>()
                .ForMember(dest => dest.ImpStock, opt => opt.Ignore())
                .ForMember(dest => dest.ExpStock, opt => opt.Ignore())
                .ForMember(dest => dest.InOutStockType, opt => opt.Ignore())
                .ForMember(dest => dest.CreationUser, opt => opt.Ignore())
                .ForMember(dest => dest.ReceiverUser, opt => opt.Ignore())
                .ForMember(dest => dest.ApproverUser, opt => opt.Ignore())
                .ForMember(dest => dest.StockImpUser, opt => opt.Ignore())
                .ForMember(dest => dest.StockExpUser, opt => opt.Ignore())
                .ForMember(dest => dest.ReqRoom, opt => opt.Ignore())
                .ForMember(dest => dest.ReqDepartment, opt => opt.Ignore())
                .ForMember(dest => dest.Supplier, opt => opt.Ignore())
                .ForMember(dest => dest.Patient, opt => opt.Ignore())
                .ForMember(dest => dest.MedicalRecord, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<InOutStockItemDto, InOutStockItem>()
                .ForMember(dest => dest.InOutStock, opt => opt.Ignore())
                .ForMember(dest => dest.Item, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<ItemStockDto, ItemStock>()
                .ForMember(dest => dest.Item, opt => opt.Ignore())
                .ForMember(dest => dest.Stock, opt => opt.Ignore())
                .ReverseMap();

            #region - nghiệp vụ

            CreateMap<Patient, PatientDto>().ReverseMap();
            CreateMap<Patient, PatientRecordDto>().ForMember(des => des.PatientId, act => act.MapFrom(s => s.Id)).ReverseMap();
            CreateMap<PatientRecord, PatientRecordDto>().ReverseMap();
            CreateMap<ServiceRequestDto, ServiceRequestView>().ReverseMap();

            #endregion

            #region - danh mục

            CreateMap<Branch, BranchDto>().ReverseMap();
            CreateMap<DepartmentType, DepartmentTypeDto>().ReverseMap();
            CreateMap<DepartmentDto, Department>()
                .ForMember(dest => dest.BranchFk, opt => opt.Ignore())
                .ForMember(dest => dest.ChiefFk, opt => opt.Ignore())
                .ForMember(dest => dest.DepartmentTypeFk, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<RoomTypeDto, RoomType>().ReverseMap();
            CreateMap<RoomDto, Room>()
                .ForMember(dest => dest.RoomTypeFk, opt => opt.Ignore())
                .ForMember(dest => dest.DepartmentFk, opt => opt.Ignore())
                .ReverseMap();
            
            CreateMap<Ethnicity, EthnicityDto>().ReverseMap();

            #endregion

            #region - hệ thống

            CreateMap<ListLayoutTemplate, ListLayoutTemplateDto>().ReverseMap();
            CreateMap<Role, RoleDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();

            #endregion
        }
    }
}
