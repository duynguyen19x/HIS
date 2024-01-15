using HIS.Application.Core.Services;
using HIS.Dtos.Systems.RefType;
using HIS.Dtos.Systems;
using HIS.Application.Core.Services.Dto;
using HIS.EntityFrameworkCore;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using HIS.Core.Linq;
using HIS.EntityFrameworkCore.Entities.Systems;
using HIS.Core.Domain.Repositories;
using System.Transactions;
using HIS.Core.Domain.Uow;
using HIS.ApplicationService.Dictionaries.Unit;

namespace HIS.ApplicationService.Systems.RefType
{
    public class SYSRefTypeAppService : BaseCrudAppService<SYSRefTypeDto, int, GetAllSYSRefTypeInputDto>, ISYSRefTypeAppService
    {
        private readonly IRepository<SYSRefType, int> _sysRefTypeRepository;
        private readonly IUnitOfWorkManager _unitOfWorkManager;
        private readonly IUnitService _unitService;

        public SYSRefTypeAppService(HISDbContext context, 
            IMapper mapper, 
            IRepository<SYSRefType, int> sysRefTypeRepository,
            IUnitService unitService,
            IUnitOfWorkManager unitOfWorkManager) 
            : base(context, mapper)
        {
            _sysRefTypeRepository = sysRefTypeRepository;
            _unitOfWorkManager = unitOfWorkManager;
            _unitService = unitService;
        }

        public override async Task<ResultDto<SYSRefTypeDto>> Create(SYSRefTypeDto input)
        {
            var result = new ResultDto<SYSRefTypeDto>();
            using (var unitOfWork = _unitOfWorkManager.Begin())
            {
                try
                {
                    //input.Id = Context.NewID<SYSRefType>();
                    var data = ObjectMapper.Map<SYSRefType>(input);
                    input.Id = await _sysRefTypeRepository.InsertAndGetIdAsync(data);

                    unitOfWork.Complete();
                    result.Result = input;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                    throw;
                }
            }
            return result;
        }

        public override async Task<ResultDto<SYSRefTypeDto>> Update(SYSRefTypeDto input)
        {
            var result = new ResultDto<SYSRefTypeDto>();
            using (var unitOfWork = _unitOfWorkManager.Begin())
            {
                try
                {
                    //input.Id = Context.NewID<SYSRefType>();
                    var data = ObjectMapper.Map<SYSRefType>(input);
                    _sysRefTypeRepository.Update(data);

                    unitOfWork.Complete();
                    result.Result = input;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                    throw;
                }
            }
            return await Task.FromResult(result);
        }

        public override Task<ResultDto<SYSRefTypeDto>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override async Task<PagedResultDto<SYSRefTypeDto>> GetAll(GetAllSYSRefTypeInputDto input)
        {
            var result = new PagedResultDto<SYSRefTypeDto>();
            try
            {
                var filter = _sysRefTypeRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.RefTypeNameFilter), x => x.RefTypeName == input.RefTypeNameFilter)
                    .WhereIf(input.RefTypeCategoryFilter != null, x => x.RefTypeCategoryId == input.RefTypeCategoryFilter);

                var paged = filter.OrderBy(s => s.RefTypeCategoryId).ThenBy(t => t.SortOrder).PageBy(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<SYSRefTypeDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public override Task<ResultDto<SYSRefTypeDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        
    }
}
