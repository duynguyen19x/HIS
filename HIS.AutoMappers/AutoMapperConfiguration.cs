using AutoMapper;
using HIS.Dtos.Dictionaries.Career;
using HIS.EntityFrameworkCore.Entities.Dictionaries;

namespace HIS.AutoMappers
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<SCareer, SCareerDto>().ReverseMap();
        }
    }
}