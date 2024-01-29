using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Core.Services.Dto;
using HIS.Dtos.Systems.RefTypeCategory;
using HIS.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.RefTypeCategory
{
    public class SYSRefTypeCategoryAppService : BaseCrudAppService<SYSRefTypeCategoryDto, int, GetAllSYSRefTypeCategoryInputDto>, ISYSRefTypeCategoryAppService
    {
        public SYSRefTypeCategoryAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public override Task<ResultDto<SYSRefTypeCategoryDto>> Create(SYSRefTypeCategoryDto input)
        {
            throw new NotImplementedException();
        }

        public override Task<ResultDto<SYSRefTypeCategoryDto>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override Task<PagedResultDto<SYSRefTypeCategoryDto>> GetAll(GetAllSYSRefTypeCategoryInputDto input)
        {
            throw new NotImplementedException();
        }

        public override Task<ResultDto<SYSRefTypeCategoryDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override Task<ResultDto<SYSRefTypeCategoryDto>> Update(SYSRefTypeCategoryDto input)
        {
            throw new NotImplementedException();
        }
    }
}
