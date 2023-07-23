using AutoMapper;
using HIS.ApplicationService.Dictionaries.MedicineGroup;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.MedicineGroup;
using HIS.Dtos.Dictionaries.MedicineType;
using HIS.EntityFrameworkCore.DbContexts;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.MedicineType
{
    public class SMedicineTypeService : BaseSerivce, ISMedicineTypeService
    {
        public SMedicineTypeService(HIS_DbContext dbContext, IConfiguration config, IMapper mapper)
           : base(dbContext, config, mapper)
        {

        }

        public async Task<ApiResult<SMedicineTypeDto>> CreateOrEdit(SMedicineTypeDto input)
        {
            var result = await ValidSave(input);
            if (!result.IsSuccessed)
                return result;

            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<SMedicineTypeDto>> Create(SMedicineTypeDto input)
        {
            var result = new ApiResult<SMedicineTypeDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var medicineType = _mapper.Map<SMedicineType>(input);
                    _dbContext.SMedicineTypes.Add(medicineType);
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

        public async Task<ApiResult<SMedicineTypeDto>> Update(SMedicineTypeDto input)
        {
            var result = new ApiResult<SMedicineTypeDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var medicineType = _mapper.Map<SMedicineType>(input);
                    medicineType.ModifiedDate = DateTime.Now;
                    _dbContext.SMedicineTypes.Update(medicineType);
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

        private async Task<ApiResult<SMedicineTypeDto>> ValidSave(SMedicineTypeDto input)
        {
            var result = new ApiResult<SMedicineTypeDto>();

            try
            {
                List<string> errs = new List<string>();

                #region Ktra để trống

                var emptys = new List<string>();

                if (string.IsNullOrEmpty(input.Code))
                {
                    emptys.Add("Mã thuốc");
                }

                if (string.IsNullOrEmpty(input.Code))
                {
                    emptys.Add("Mã BHYT");
                }

                if (string.IsNullOrEmpty(input.Name))
                {
                    emptys.Add("Tên thuốc");
                }

                if (emptys.Count > 0)
                {
                    errs.Add(string.Format("{0} không được để trống!", string.Join(", ", emptys)));
                }

                #endregion

                var medicineType = _dbContext.SMedicineTypes.FirstOrDefault(w => w.Code == input.Code && w.Id != input.Id);
                if (medicineType != null)
                {
                    errs.Add(string.Format("Mã thuốc [{0}] đã tồn tại trên hệ thống!", input.Code));
                }

                medicineType = _dbContext.SMedicineTypes.FirstOrDefault(w => w.HeInCode == input.HeInCode && w.Id != input.Id);
                if (medicineType != null)
                {
                    errs.Add(string.Format("Mã BHYT [{0}] đã tồn tại trên hệ thống!", input.HeInCode));
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

        public async Task<ApiResult<SMedicineTypeDto>> Delete(Guid id)
        {
            var result = new ApiResult<SMedicineTypeDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var medicineType = _dbContext.SMedicineTypes.SingleOrDefault(x => x.Id == id);
                    if (medicineType != null)
                    {
                        medicineType.IsDelete = true;
                        medicineType.DeleteDate = DateTime.Now;

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

        public async Task<ApiResultList<SMedicineTypeDto>> GetAll(GetAllSMedicineTypeInput input)
        {
            var result = new ApiResultList<SMedicineTypeDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.SMedicineTypes
                                 where r.IsDelete == false
                                     && (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                     && ((input.MedicineLineIdFilter == null && input.MedicineLineIdFilter != Guid.Empty) || r.MedicineLineId == input.MedicineLineIdFilter)
                                     && ((input.MedicineGroupIdFilter == null && input.MedicineGroupIdFilter != Guid.Empty) || r.MedicineGroupId == input.MedicineGroupIdFilter)
                                     && ((input.UnitIdFilter == null && input.UnitIdFilter != Guid.Empty) || r.UnitId == input.UnitIdFilter)
                                     && ((input.MedicineLineIdsFilter == null && input.MedicineLineIdsFilter.Count > 0) || input.MedicineLineIdsFilter.Contains(r.MedicineLineId))
                                     && ((input.MedicineGroupIdsFilter == null && input.MedicineGroupIdsFilter.Count > 0) || input.MedicineGroupIdsFilter.Contains(r.MedicineGroupId))
                                     && ((input.UnitIdsFilter == null && input.UnitIdsFilter.Count > 0) || input.UnitIdsFilter.Contains(r.UnitId))
                                 select new SMedicineTypeDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     HeInCode = r.HeInCode,
                                     Name = r.Name,
                                     SortOrder = r.SortOrder,
                                     MedicineLineId = r.MedicineLineId,
                                     MedicineGroupId = r.MedicineGroupId,
                                     UnitId = r.UnitId,
                                     Tutorial = r.Tutorial,
                                     ActiveSubstance = r.ActiveSubstance,
                                     Concentration = r.Concentration,
                                     Content = r.Content,
                                     CountryId = r.CountryId,
                                     Manufacturer = r.Manufacturer,
                                     PackagingSpecifications = r.PackagingSpecifications,
                                     ImpPrice = r.ImpPrice,
                                     ImpVatRate = r.ImpVatRate,
                                     TaxRate = r.TaxRate,
                                     Description = r.Description,
                                     Dosage = r.Dosage,
                                     Inactive = r.Inactive,
                                 }).OrderBy(o => o.SortOrder).ToList();

                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<SMedicineTypeDto>> GetById(Guid id)
        {
            var result = new ApiResult<SMedicineTypeDto>();

            var medicineType = _dbContext.SMedicineTypes.SingleOrDefault(s => s.Id == id);
            if (medicineType != null)
            {
                result.IsSuccessed = true;
                result.Result = _mapper.Map<SMedicineTypeDto>(medicineType);
            }

            return await Task.FromResult(result);
        }
    }
}
