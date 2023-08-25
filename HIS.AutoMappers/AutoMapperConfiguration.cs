using AutoMapper;
using HIS.Dtos.Business;
using HIS.Dtos.Business.DImMestMedicine;
using HIS.Dtos.Business.DImpMest;
using HIS.Dtos.Business.DMedicineStock;
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
using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals;
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
            CreateMap<Branch, SBranchDto>().ReverseMap();
            CreateMap<Career, SCareerDto>().ReverseMap();
            CreateMap<Country, SCountryDto>().ReverseMap();
            CreateMap<Department, SDepartmentDto>().ReverseMap();
            CreateMap<DepartmentType, SDepartmentTypeDto>().ReverseMap();
            CreateMap<SChapterIcdDto, ChapterIcd>().ReverseMap();
            CreateMap<District, SDistrictDto>().ReverseMap();
            CreateMap<Ethnic, SEthnicDto>().ReverseMap();
            CreateMap<Gender, SGenderDto>().ReverseMap();
            CreateMap<Hospital, SHospitalDto>().ReverseMap();
            CreateMap<Icd, SIcdDto>().ReverseMap();
            CreateMap<Province, SProvinceDto>().ReverseMap();
            CreateMap<SRoomDto, Room>()
                .ForMember(dest => dest.RoomType, opt => opt.Ignore())
                .ForMember(dest => dest.Department, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<SRoomTypeDto, RoomType>()
                .ForMember(dest => dest.SRooms, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<SWard, SWardDto>().ReverseMap();
            CreateMap<SServiceGroupDto, ServiceGroup>()
                .ReverseMap();
            CreateMap<SServiceGroupHeInDto, ServiceGroupHeIn>()
                .ReverseMap();
            CreateMap<SUnitDto, Unit>()
                .ForMember(dest => dest.Services, opt => opt.Ignore())
                .ForMember(dest => dest.MedicineTypes, opt => opt.Ignore())
                .ForMember(dest => dest.Medicines, opt => opt.Ignore())
                .ForMember(dest => dest.Materials, opt => opt.Ignore())
                .ForMember(dest => dest.MaterialTypes, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<SServiceDto, Service>()
                .ForMember(dest => dest.Unit, opt => opt.Ignore())
                .ForMember(dest => dest.ServiceGroup, opt => opt.Ignore())
                .ForMember(dest => dest.SurgicalProcedureType, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<SServicePricePolicyDto, ServicePricePolicy>()
               .ForMember(dest => dest.PatientType, opt => opt.Ignore())
               .ForMember(dest => dest.Service, opt => opt.Ignore())
               .ReverseMap();

            CreateMap<SExecutionRoomDto, ExecutionRoom>()
                .ForMember(dest => dest.Service, opt => opt.Ignore())
                .ForMember(dest => dest.Room, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<SServiceResultIndiceDto, ServiceResultIndice>()
             .ForMember(dest => dest.Service, opt => opt.Ignore())
             .ReverseMap();

            CreateMap<SMedicineGroupDto, MedicineGroup>()
                .ReverseMap();
            CreateMap<SMedicineTypeDto, MedicineType>()
                .ForMember(dest => dest.Unit, opt => opt.Ignore())
                .ForMember(dest => dest.MedicineLine, opt => opt.Ignore())
                .ForMember(dest => dest.MedicineGroup, opt => opt.Ignore())
                .ForMember(dest => dest.Country, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<SSupplierDto, Supplier>()
                .ReverseMap();


            CreateMap<DImpMestMedicineDto, Medicine>()
                .ForMember(dest => dest.MedicineType, opt => opt.Ignore())
                .ForMember(dest => dest.Unit, opt => opt.Ignore())
                .ForMember(dest => dest.MedicineLine, opt => opt.Ignore())
                .ForMember(dest => dest.Country, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<SMedicineDto, Medicine>()
                .ForMember(dest => dest.MedicineType, opt => opt.Ignore())
                .ForMember(dest => dest.Unit, opt => opt.Ignore())
                .ForMember(dest => dest.MedicineLine, opt => opt.Ignore())
                .ForMember(dest => dest.Country, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<SMedicinePricePolicyDto, MedicinePricePolicy>()
                .ForMember(dest => dest.Medicine, opt => opt.Ignore())
                .ForMember(dest => dest.PatientType, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<DMedicineStockDto, MedicineStock>()
                .ForMember(dest => dest.Medicine, opt => opt.Ignore())
                .ForMember(dest => dest.Stock, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<PatientDto, HISPatient>().ReverseMap();
            CreateMap<PatientRecordDto, HISPatientRecord>().ReverseMap();
            CreateMap<PatientRecordDto, PatientDto>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.PatientId))
                .ForMember(d => d.Code, o => o.MapFrom(s => s.PatientCode))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.PatientName))
                .ReverseMap();
        }
    }
}