using AutoMapper;
using HIS.ApplicationService.Base;
using HIS.Core.Linq;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.MedicineGroup;
using HIS.Dtos.Dictionaries.MedicineType;
using HIS.Dtos.Dictionaries.Service;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using HIS.Utilities.Helpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.MedicineGroup
{
    public class SMedicineGroupService : BaseSerivce, ISMedicineGroupService
    {
        public SMedicineGroupService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
           : base(dbContext, config, mapper)
        {

        }

        public async Task<ApiResult<SMedicineGroupDto>> CreateOrEdit(SMedicineGroupDto input)
        {
            var result = await ValidSave(input);
            if (!result.IsSuccessed)
                return result;

            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<SMedicineGroupDto>> Create(SMedicineGroupDto input)
        {
            var result = new ApiResult<SMedicineGroupDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var medicineGroup = _mapper.Map<SMedicineGroup>(input);
                    _dbContext.SMedicineGroups.Add(medicineGroup);
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

        public async Task<ApiResult<SMedicineGroupDto>> Update(SMedicineGroupDto input)
        {
            var result = new ApiResult<SMedicineGroupDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var medicineGroup = _mapper.Map<SMedicineGroup>(input);
                    _dbContext.SMedicineGroups.Update(medicineGroup);
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

        private async Task<ApiResult<SMedicineGroupDto>> ValidSave(SMedicineGroupDto input)
        {
            var result = new ApiResult<SMedicineGroupDto>();

            try
            {
                List<string> errs = new List<string>();

                #region Ktra để trống

                var emptys = new List<string>();

                if (string.IsNullOrEmpty(input.Code))
                {
                    emptys.Add("Mã nhóm thuốc");
                }

                if (string.IsNullOrEmpty(input.Name))
                {
                    emptys.Add("Tên nhóm thuốc");
                }

                if (emptys.Count > 0)
                {
                    errs.Add(string.Format("{0} không được để trống!", string.Join(", ", emptys)));
                }

                #endregion

                var medicineGroup = _dbContext.SMedicineGroups.FirstOrDefault(w => w.Code == input.Code && w.Id != input.Id);
                if (medicineGroup != null)
                {
                    errs.Add(string.Format("Mã nhóm thuốc [{0}] đã tồn tại trên hệ thống!", input.Code));
                }

                if (errs.Count > 0)
                {
                    result.IsSuccessed = false;
                    result.Message = string.Join("\n", errs);
                }
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<SMedicineGroupDto>> Delete(Guid id)
        {
            var result = new ApiResult<SMedicineGroupDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var medicineGroup = _dbContext.SMedicineGroups.SingleOrDefault(x => x.Id == id);
                    if (medicineGroup != null)
                    {
                        _dbContext.SMedicineGroups.Remove(medicineGroup);
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

        public async Task<ApiResultList<SMedicineGroupDto>> GetAll(GetAllSMedicineGroupInput input)
        {
            var result = new ApiResultList<SMedicineGroupDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.SMedicineGroups

                                 select new SMedicineGroupDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     SortOrder = r.SortOrder,
                                     IsSystem = r.IsSystem,
                                     Inactive = r.Inactive
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

        public async Task<ApiResult<SMedicineGroupDto>> GetById(Guid id)
        {
            var result = new ApiResult<SMedicineGroupDto>();

            var medicineGroup = _dbContext.SMedicineGroups.SingleOrDefault(s => s.Id == id);
            if (medicineGroup != null)
            {
                result.IsSuccessed = true;
                result.Result = _mapper.Map<SMedicineGroupDto>(medicineGroup);
            }

            return await Task.FromResult(result);
        }
    }
}
