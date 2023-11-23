using AutoMapper;
using HIS.Dtos.Business.InOutStockItems;
using HIS.Dtos.Business.InOutStocks;
using HIS.Dtos.Business.ItemStocks;
using HIS.Dtos.Dictionaries.Branch;
using HIS.Dtos.Dictionaries.Career;
using HIS.Dtos.Dictionaries.ChapterICD10;
using HIS.Dtos.Dictionaries.Country;
using HIS.Dtos.Dictionaries.Department;
using HIS.Dtos.Dictionaries.DepartmentType;
using HIS.Dtos.Dictionaries.District;
using HIS.Dtos.Dictionaries.ExecutionRoom;
using HIS.Dtos.Dictionaries.Gender;
using HIS.Dtos.Dictionaries.Hospital;
using HIS.Dtos.Dictionaries.Icd;
using HIS.Dtos.Dictionaries.ItemGroups;
using HIS.Dtos.Dictionaries.ItemPricePolicies;
using HIS.Dtos.Dictionaries.Items;
using HIS.Dtos.Dictionaries.ItemTypes;
using HIS.Dtos.Dictionaries.Province;
using HIS.Dtos.Dictionaries.Room;
using HIS.Dtos.Dictionaries.RoomType;
using HIS.Dtos.Dictionaries.Service;
using HIS.Dtos.Dictionaries.ServiceGroup;
using HIS.Dtos.Dictionaries.ServiceGroupHeIn;
using HIS.Dtos.Dictionaries.ServicePricePolicy;
using HIS.Dtos.Dictionaries.ServiceResultIndex;
using HIS.Dtos.Dictionaries.ServiceUnit;
using HIS.Dtos.Dictionaries.Supplier;
using HIS.Dtos.Dictionaries.Ward;
using HIS.EntityFrameworkCore.Entities.Business;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Categories.Items;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Dtos.Business.Receptions;
using HIS.Dtos.Systems.DbOption;
using HIS.EntityFrameworkCore.Entities.Systems;
using HIS.Dtos.Dictionaries.RelativeCategories;
using HIS.Dtos.Dictionaries.PatientObjectTypes;
using HIS.Dtos.Dictionaries.ReceptionObjectTypes;
using HIS.Dtos.Dictionaries.Relatives;
using HIS.Dtos.Business.Patients;
using HIS.Dtos.Business.PatientRecords;
using HIS.Dtos.Dictionaries.Ethnicities;

namespace HIS.AutoMappers
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<Branch, BranchDto>().ReverseMap();
            CreateMap<Career, CareerDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<DepartmentDto, Department>()
                //.ForMember(dest => dest.DepartmentType, opt => opt.Ignore())
                //.ForMember(dest => dest.Branch, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<DepartmentType, DepartmentTypeDto>().ReverseMap();
            CreateMap<ChapterIcdDto, ChapterIcd>().ReverseMap();
            CreateMap<District, DistrictDto>().ReverseMap();
            CreateMap<Gender, GenderDto>().ReverseMap();
            CreateMap<Hospital, HospitalDto>().ReverseMap();
            CreateMap<Icd, IcdDto>().ReverseMap();
            CreateMap<DbOption, DbOptionDto>().ReverseMap();
            CreateMap<Province, ProvinceDto>().ReverseMap();
            CreateMap<RoomDto, Room>()
                .ForMember(dest => dest.RoomType, opt => opt.Ignore())
                .ForMember(dest => dest.Department, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<RoomTypeDto, RoomType>()
                .ForMember(dest => dest.SRooms, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<SWard, WardDto>().ReverseMap();
            CreateMap<ServiceGroupDto, ServiceGroup>()
                .ReverseMap();
            CreateMap<ServiceGroupHeInDto, ServiceGroupHeIn>()
                .ReverseMap();
            CreateMap<UnitDto, Unit>()
                .ReverseMap();
            CreateMap<ServiceDto, Service>()
                .ForMember(dest => dest.Unit, opt => opt.Ignore())
                .ForMember(dest => dest.ServiceGroup, opt => opt.Ignore())
                .ForMember(dest => dest.SurgicalProcedureType, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<ServicePricePolicyDto, ServicePricePolicy>()
               .ForMember(dest => dest.PatientObjectType, opt => opt.Ignore())
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
                .ForMember(dest => dest.PatientObjectType, opt => opt.Ignore())
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
                .ForMember(dest => dest.PatientRecord, opt => opt.Ignore())
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
            CreateMap<ReceptionDto, PatientDto>().ReverseMap();
            CreateMap<ReceptionDto, PatientRecordDto>().ReverseMap();
            #endregion

            #region - danh mục

            CreateMap<Ethnicity, EthnicityDto>().ReverseMap();
            CreateMap<PatientObjectType, PatientObjectTypeDto>().ReverseMap();
            CreateMap<ReceptionObjectType, ReceptionObjectTypeDto>().ReverseMap();
            CreateMap<RelativeCategory, RelativeCategoryDto>().ReverseMap();
            CreateMap<Relative, RelativeDto>().ReverseMap();

            #endregion
        }
    }
}