using AutoMapper;
using HIS.Dtos.Business.Treatment;
using HIS.Dtos.Dictionaries.Branch;
using HIS.Dtos.Dictionaries.Career;
using HIS.Dtos.Dictionaries.Country;
using HIS.Dtos.Dictionaries.Department;
using HIS.Dtos.Dictionaries.DepartmentType;
using HIS.Dtos.Dictionaries.District;
using HIS.Dtos.Dictionaries.Ethnic;
using HIS.Dtos.Dictionaries.Gender;
using HIS.Dtos.Dictionaries.Hospital;
using HIS.Dtos.Dictionaries.Icd;
using HIS.Dtos.Dictionaries.Province;
using HIS.Dtos.Dictionaries.Room;
using HIS.Dtos.Dictionaries.RoomType;
using HIS.Dtos.Dictionaries.Service;
using HIS.Dtos.Dictionaries.ServiceGroup;
using HIS.Dtos.Dictionaries.Ward;
using HIS.Dtos.Systems.Role;
using HIS.EntityFrameworkCore.Entities.Business.Patients;
using HIS.EntityFrameworkCore.Entities.Business.Treatment;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Dictionaries;

namespace HIS.AutoMappers
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<STreatmentDto, STreatment>().ReverseMap();
            CreateMap<STreatmentDto, SPatient>().ReverseMap();

            CreateMap<SBranch, SBranchDto>().ReverseMap();
            CreateMap<SCareer, SCareerDto>().ReverseMap();
            CreateMap<SCountry, SCountryDto>().ReverseMap();
            CreateMap<SDepartment, SDepartmentDto>().ReverseMap();
            CreateMap<SDepartmentType, SDepartmentTypeDto>().ReverseMap();
            CreateMap<SDistrict, SDistrictDto>().ReverseMap();
            CreateMap<SEthnic, SEthnicDto>().ReverseMap();
            CreateMap<SGender, SGenderDto>().ReverseMap();
            CreateMap<SHospital, SHospitalDto>().ReverseMap();
            CreateMap<SIcd, SIcdDto>().ReverseMap();
            CreateMap<SProvince, SProvinceDto>().ReverseMap();
            CreateMap<SRoom, SRoomDto>().ReverseMap();
            CreateMap<SRoomType, SRoomTypeDto>().ReverseMap();
            CreateMap<SWard, SWardDto>().ReverseMap();
            CreateMap<SServiceGroup, SServiceGroupDto>().ReverseMap();
            CreateMap<SService, SServiceDto>().ReverseMap();
        }
    }
}