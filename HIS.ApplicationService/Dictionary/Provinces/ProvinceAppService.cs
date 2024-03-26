using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.Dtos.Dictionaries.Province;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using System.Transactions;

namespace HIS.ApplicationService.Dictionaries.Provinces
{
    public class ProvinceAppService : BaseAppService, IProvinceAppService
    {
        private readonly IRepository<Province, Guid> _provinceRepository;

        public ProvinceAppService(IRepository<Province, Guid> provinceRepository)
        {
            _provinceRepository = provinceRepository;
        }

        public virtual async Task<ResultDto<ProvinceDto>> CreateOrEdit(ProvinceDto input)
        {
            if (Check.IsNullOrDefault(input.Id))
            {
                return await Create(input);
            }
            else
            {
                return await Update(input);
            }
        }

        public virtual async Task<ResultDto<ProvinceDto>> Create(ProvinceDto input)
        {
            var result = new ResultDto<ProvinceDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var entity = ObjectMapper.Map<Province>(input);

                    await _provinceRepository.InsertAsync(entity);

                    unitOfWork.Complete();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<ProvinceDto>> Update(ProvinceDto input)
        {
            var result = new ResultDto<ProvinceDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _provinceRepository.GetAsync(input.Id.GetValueOrDefault());

                    ObjectMapper.Map(input, entity);

                    unitOfWork.Complete();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<ProvinceDto>> Delete(Guid id)
        {
            var result = new ResultDto<ProvinceDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = _provinceRepository.Get(id);

                    await _provinceRepository.DeleteAsync(entity);

                    unitOfWork.Complete();
                    result.Success(null);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<PagedResultDto<ProvinceDto>> GetAll(GetAllProvinceInputDto input)
        {
            var result = new PagedResultDto<ProvinceDto>();
            try
            {
                result.IsSucceeded = true;
                result.Result = (from r in _provinceRepository.GetAll()
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new ProvinceDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Inactive = r.Inactive
                                 }).OrderBy(o => o.Code).ToList();
                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public virtual async Task<ResultDto<ProvinceDto>> GetById(Guid id)
        {
            var result = new ResultDto<ProvinceDto>();

            var data = _provinceRepository.FirstOrDefault(s => s.Id == id);
            if (data != null)
            {
                result.IsSucceeded = true;
                result.Result = ObjectMapper.Map<ProvinceDto>(data);
            }

            return await Task.FromResult(result);
        }
    }
}
