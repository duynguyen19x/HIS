using AutoMapper;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.MedicineLine;
using HIS.Dtos.Dictionaries.MedicineType;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using HIS.Utilities.Helpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.MedicineLine
{
    public class SMedicineLineService : BaseSerivce, ISMedicineLineService
    {
        public SMedicineLineService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
          : base(dbContext, config, mapper)
        {

        }

        public async Task<ApiResult<MedicineLineDto>> CreateOrEdit(MedicineLineDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        private async Task<ApiResult<MedicineLineDto>> Create(MedicineLineDto input)
        {
            var result = new ApiResult<MedicineLineDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var medicineLine = _mapper.Map<SMedicineLine>(input);
                    _dbContext.SMedicineLines.Add(medicineLine);
                    await _dbContext.SaveChangesAsync();

                    result.IsSuccessed = true;
                    result.Result = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        private async Task<ApiResult<MedicineLineDto>> Update(MedicineLineDto input)
        {
            var result = new ApiResult<MedicineLineDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var medicineLine = _mapper.Map<SMedicineLine>(input);
                    _dbContext.SMedicineLines.Update(medicineLine);
                    await _dbContext.SaveChangesAsync();

                    result.IsSuccessed = true;
                    result.Result = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public async Task<ApiResult<MedicineLineDto>> Delete(Guid id)
        {
            var result = new ApiResult<MedicineLineDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var medicineLine = _dbContext.SMedicineLines.SingleOrDefault(x => x.Id == id);
                    if (medicineLine != null)
                    {
                        _dbContext.SMedicineLines.Remove(medicineLine);
                        await _dbContext.SaveChangesAsync();
                        result.IsSuccessed = true;

                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public async Task<ApiResultList<MedicineLineDto>> GetAll(GetAllSMedicineLineInput input)
        {
            var result = new ApiResultList<MedicineLineDto>();
            try
            {
                result.Result = (from r in _dbContext.SMedicineLines
                                 select new MedicineLineDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Inactive = r.Inactive,
                                     SortOrder = r.SortOrder
                                 })
                                 .WhereIf(!string.IsNullOrEmpty(input.NameFilter), r => r.Name == input.NameFilter)
                                 .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), r => r.Code == input.CodeFilter)
                                 .WhereIf(input.InactiveFilter != null, r => r.Inactive == input.InactiveFilter)
                                 .OrderBy(o => o.SortOrder).ToList();

                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<MedicineLineDto>> GetById(Guid id)
        {
            var result = new ApiResult<MedicineLineDto>();

            var medicineLine = _dbContext.SMedicineLines.SingleOrDefault(s => s.Id == id);
            if (medicineLine != null)
            {
                result.Result = _mapper.Map<MedicineLineDto>(medicineLine);
            }

            return await Task.FromResult(result);
        }
    }
}
