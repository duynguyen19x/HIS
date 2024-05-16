using HIS.ApplicationService.Business.Patients.Dto;
using HIS.ApplicationService.Business.Receptions.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HIS.ApplicationService.Business.Receptions
{
    public class ReceptionAppService : BaseAppService, IReceptionAppService
    {
        private readonly IRepository<Patient, Guid> _patientRepository;
        private readonly IRepository<Reception, Guid> _receptionRepository;
        

        public ReceptionAppService(
            IRepository<Patient, Guid> patientRepository,
            IRepository<Reception, Guid> receptionRepository) 
        {
            _patientRepository = patientRepository;
            _receptionRepository = receptionRepository;
        }

        public Task<ResultDto<ReceptionDto>> CreateOrEdit(ReceptionDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<ReceptionDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResultDto<ReceptionDto>> GetAll(GetAllReceptionInputDto input)
        {
            var result = new PagedResultDto<ReceptionDto>();

            var filter = _receptionRepository.GetAll()
                .WhereIf(input.MaxReceptionDateFilter != null, x => x.ReceptionDate <= input.MaxReceptionDateFilter)
                .WhereIf(input.MinReceptionDateFilter != null, x => x.ReceptionDate >= input.MinReceptionDateFilter)
                .WhereIf(input.BranchFilter != null, x => x.BranchID == input.BranchFilter)
                .WhereIf(input.DepartmentFilter != null, x => x.DepartmentID == input.DepartmentFilter)
                .WhereIf(input.RoomFilter != null, x => x.RoomID == input.RoomFilter)
                .WhereIf(input.GateFilter != null, x => x.Gate == input.GateFilter);

            if (Check.IsNullOrDefault(input.Sorting))
                input.Sorting = nameof(ReceptionDto.ReceptionDate);

            var paged = filter.ApplySortingAndPaging(input);


            result.TotalCount = await filter.CountAsync();
            result.Result = ObjectMapper.Map<IList<ReceptionDto>>(paged.ToList());
            result.IsSucceeded = true;

            return result;
        }

        public async Task<ResultDto<ReceptionDto>> GetById(Guid id)
        {
            var result = new ResultDto<ReceptionDto>();
            var entity = await _receptionRepository.GetAsync(id);

            result.Result = ObjectMapper.Map<ReceptionDto>(entity);
            result.IsSucceeded = true;

            return result;
        }
    }
}
