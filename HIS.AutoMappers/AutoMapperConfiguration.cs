using AutoMapper;
using HIS.Dtos.Business.DImMest;
using HIS.Dtos.Business.DImMestMedicine;
using HIS.Dtos.Business.Patient;
using HIS.Dtos.Business.Treatment;
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
using HIS.Dtos.Dictionaries.MedicineGroup;
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
using HIS.EntityFrameworkCore.Entities.Business.Patients;
using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.ImpMests;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using HIS.EntityFrameworkCore.Entities.Dictionaries;

namespace HIS.AutoMappers
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<STreatmentDto, STreatment>().ReverseMap();
            CreateMap<STreatmentDto, SPatient>().ReverseMap();
            CreateMap<SPatientDto, SPatient>().ReverseMap();

            CreateMap<SBranch, SBranchDto>().ReverseMap();
            CreateMap<SCareer, SCareerDto>().ReverseMap();
            CreateMap<SCountry, SCountryDto>().ReverseMap();
            CreateMap<SDepartment, SDepartmentDto>().ReverseMap();
            CreateMap<SDepartmentType, SDepartmentTypeDto>().ReverseMap();
            CreateMap<SChapterICD10Dto, SChapterICD10>().ReverseMap();
            CreateMap<SDistrict, SDistrictDto>().ReverseMap();
            CreateMap<SEthnic, SEthnicDto>().ReverseMap();
            CreateMap<SGender, SGenderDto>().ReverseMap();
            CreateMap<SHospital, SHospitalDto>().ReverseMap();
            CreateMap<SIcd, SIcdDto>().ReverseMap();
            CreateMap<SProvince, SProvinceDto>().ReverseMap();
            CreateMap<SRoomDto, SRoom>()
                .ForMember(dest => dest.SRoomType, opt => opt.Ignore())
                .ForMember(dest => dest.SDepartment, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<SRoomTypeDto, SRoomType>()
                .ForMember(dest => dest.SRooms, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<SWard, SWardDto>().ReverseMap();
            CreateMap<SServiceGroupDto, SServiceGroup>()
                .ForMember(dest => dest.SServices, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<SServiceGroupHeInDto, SServiceGroupHeIn>()
                .ForMember(dest => dest.SServices, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<SUnitDto, SUnit>()
                .ForMember(dest => dest.SServices, opt => opt.Ignore())
                .ForMember(dest => dest.SMedicineTypes, opt => opt.Ignore())
                .ForMember(dest => dest.SMedicines, opt => opt.Ignore())
                .ForMember(dest => dest.SMaterials, opt => opt.Ignore())
                .ForMember(dest => dest.SMaterialTypes, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<SServiceDto, SService>()
                .ForMember(dest => dest.SUnit, opt => opt.Ignore())
                .ForMember(dest => dest.SServiceGroup, opt => opt.Ignore())
                .ForMember(dest => dest.SSurgicalProcedureType, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<SServicePricePolicyDto, SServicePricePolicy>()
               .ForMember(dest => dest.SPatientType, opt => opt.Ignore())
               .ForMember(dest => dest.SService, opt => opt.Ignore())
               .ReverseMap();

            CreateMap<SExecutionRoomDto, SExecutionRoom>()
                .ForMember(dest => dest.SService, opt => opt.Ignore())
                .ForMember(dest => dest.SRoom, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<SServiceResultIndiceDto, SServiceResultIndice>()
             .ForMember(dest => dest.SService, opt => opt.Ignore())
             .ReverseMap();

            CreateMap<SMedicineGroupDto, SMedicineGroup>()
                .ForMember(dest => dest.SMedicineTypes, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<SMedicineTypeDto, SMedicineType>()
                .ForMember(dest => dest.SUnit, opt => opt.Ignore())
                .ForMember(dest => dest.SMedicineLine, opt => opt.Ignore())
                .ForMember(dest => dest.SMedicineGroup, opt => opt.Ignore())
                .ForMember(dest => dest.SCountry, opt => opt.Ignore())
                .ForMember(dest => dest.SMedicines, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<SSupplierDto, SSupplier>()
                .ReverseMap();

            CreateMap<DImpMestDto, DImpMest>()
                .ForMember(dest => dest.ImStock, opt => opt.Ignore())
                .ForMember(dest => dest.ExStock, opt => opt.Ignore())
                .ForMember(dest => dest.DImExMestType, opt => opt.Ignore())
                .ForMember(dest => dest.ReceiverUser, opt => opt.Ignore())
                .ForMember(dest => dest.ApproverUser, opt => opt.Ignore())
                .ForMember(dest => dest.StockReceiptUser, opt => opt.Ignore())
                .ForMember(dest => dest.ReqRoom, opt => opt.Ignore())
                .ForMember(dest => dest.ReqDepartment, opt => opt.Ignore())
                .ForMember(dest => dest.STreatment, opt => opt.Ignore())
                .ForMember(dest => dest.SPatient, opt => opt.Ignore())
                .ForMember(dest => dest.SSupplier, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<DImpMestMedicineDto, SMedicine>()
                .ForMember(dest => dest.SMedicineType, opt => opt.Ignore())
                .ForMember(dest => dest.SUnit, opt => opt.Ignore())
                .ForMember(dest => dest.SMedicineLine, opt => opt.Ignore())
                .ForMember(dest => dest.SCountry, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<DImpMestMedicineDto, DImpMestMedicine>()
                .ForMember(dest => dest.DImMest, opt => opt.Ignore())
                .ForMember(dest => dest.SMedicine, opt => opt.Ignore())
                .ReverseMap();
        }
    }
}