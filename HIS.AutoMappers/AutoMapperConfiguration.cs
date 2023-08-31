using AutoMapper;
using HIS.Dtos.Business;
using HIS.Dtos.Business.InOutStocks;
using HIS.Dtos.Business.InOutStockMedicines;
using HIS.Dtos.Business.MedicineStocks;
using HIS.Dtos.Dictionaries.Branch;
using HIS.Dtos.Dictionaries.Career;
using HIS.Dtos.Dictionaries.ChapterICD10;
using HIS.Dtos.Dictionaries.Country;
using HIS.Dtos.Dictionaries.Department;
using HIS.Dtos.Dictionaries.DepartmentType;
using HIS.Dtos.Dictionaries.District;
using HIS.Dtos.Dictionaries.Ethnic;
using HIS.Dtos.Dictionaries.ExecutionRoom;
using HIS.Dtos.Dictionaries.Gender;
using HIS.Dtos.Dictionaries.Hospital;
using HIS.Dtos.Dictionaries.Icd;
using HIS.Dtos.Dictionaries.Medicine;
using HIS.Dtos.Dictionaries.MedicineGroup;
using HIS.Dtos.Dictionaries.MedicinePricePolicy;
using HIS.Dtos.Dictionaries.MedicineType;
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
using HIS.EntityFrameworkCore.Entities.Categories.Medicines;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using HIS.EntityFrameworkCore.Entities.Dictionaries;

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
            CreateMap<Ethnic, EthnicDto>().ReverseMap();
            CreateMap<Gender, GenderDto>().ReverseMap();
            CreateMap<Hospital, HospitalDto>().ReverseMap();
            CreateMap<Icd, IcdDto>().ReverseMap();
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
                .ForMember(dest => dest.Services, opt => opt.Ignore())
                .ForMember(dest => dest.MedicineTypes, opt => opt.Ignore())
                .ForMember(dest => dest.Medicines, opt => opt.Ignore())
                .ForMember(dest => dest.Materials, opt => opt.Ignore())
                .ForMember(dest => dest.MaterialTypes, opt => opt.Ignore())
                .ReverseMap();
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

            CreateMap<MedicineGroupDto, MedicineGroup>()
                .ReverseMap();
            CreateMap<MedicineTypeDto, MedicineType>()
                .ForMember(dest => dest.Unit, opt => opt.Ignore())
                .ForMember(dest => dest.MedicineLine, opt => opt.Ignore())
                .ForMember(dest => dest.MedicineGroup, opt => opt.Ignore())
                .ForMember(dest => dest.Country, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<SupplierDto, Supplier>()
                .ReverseMap();

            CreateMap<InOutStockMedicineDto, Medicine>()
                .ForMember(dest => dest.MedicineType, opt => opt.Ignore())
                .ForMember(dest => dest.Unit, opt => opt.Ignore())
                .ForMember(dest => dest.MedicineLine, opt => opt.Ignore())
                .ForMember(dest => dest.Country, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<MedicineDto, Medicine>()
                .ForMember(dest => dest.MedicineType, opt => opt.Ignore())
                .ForMember(dest => dest.Unit, opt => opt.Ignore())
                .ForMember(dest => dest.MedicineLine, opt => opt.Ignore())
                .ForMember(dest => dest.Country, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<MedicinePricePolicyDto, MedicinePricePolicy>()
                .ForMember(dest => dest.Medicine, opt => opt.Ignore())
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
                .ForMember(dest => dest.PatientRecord, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<InOutStockMedicineDto, InOutStockMedicine>()
                .ForMember(dest => dest.InOutStock, opt => opt.Ignore())
                .ForMember(dest => dest.Medicine, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<MedicineStockDto, MedicineStock>()
                .ForMember(dest => dest.Medicine, opt => opt.Ignore())
                .ForMember(dest => dest.Stock, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<PatientDto, Patient>().ReverseMap();
            CreateMap<PatientRecordDto, PatientRecord>().ReverseMap();
            CreateMap<PatientRecordDto, PatientDto>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.PatientId))
                .ForMember(d => d.Code, o => o.MapFrom(s => s.PatientCode))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.PatientName))
                .ReverseMap();
        }
    }
}