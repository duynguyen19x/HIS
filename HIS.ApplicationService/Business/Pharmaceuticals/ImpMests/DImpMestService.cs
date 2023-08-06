using AutoMapper;
using HIS.Dtos.Business.DImMest;
using HIS.Dtos.Business.Treatment;
using HIS.Dtos.Commons;
using HIS.EntityFrameworkCore.Entities.Business.Patients;
using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.ImpMests;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using HIS.Utilities.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Pharmaceuticals.ImpMests
{
    public class DImpMestService : BaseSerivce, IDImpMestService
    {
        public DImpMestService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
           : base(dbContext, config, mapper) { }

        public async Task<ApiResult<DImpMestDto>> CreateOrEdit(DImpMestDto input)
        {
            if (GuidHelper.IsNullOrEmpty(input.Id))
            {
                return await Create(input);
            }
            else
            {
                return await Update(input);
            }
        }

        private async Task<ApiResult<DImpMestDto>> Create(DImpMestDto input)
        {
            var result = new ApiResult<DImpMestDto>();

            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var id = Guid.NewGuid();
                    var dateNow = DateTime.Now;

                    var dImMest = _mapper.Map<DImpMest>(input);
                    dImMest.Id = id;
                    dImMest.CreatedDate = dateNow;

                    // Đánh số tự động
                    if (string.IsNullOrEmpty(dImMest.Code))
                    {

                    }

                    // Nhập từ thuốc nhà cung cấp
                    if (input.ImExMestTypeId == 1)
                    {
                        var dImMestMedicines = new List<DImpMestMedicine>();
                        var sMedicines = new List<SMedicine>();

                        foreach (var dImMestMedicineDto in input.DImpMestMedicines)
                        {
                            var sMedicine = _mapper.Map<SMedicine>(dImMestMedicineDto);
                            sMedicine.Id = Guid.NewGuid();
                            sMedicine.CreatedDate = dateNow;

                            var dImMestMedicine = _mapper.Map<DImpMestMedicine>(dImMestMedicineDto);
                            dImMestMedicine.Id = Guid.NewGuid();
                            dImMestMedicine.ImMestId = id;
                            dImMestMedicine.MedicineId = sMedicine.Id;

                            sMedicines.Add(sMedicine);
                            dImMestMedicines.Add(dImMestMedicine);
                        }

                        _dbContext.SMedicines.AddRange(sMedicines);
                        _dbContext.DImMestMedicines.AddRange(dImMestMedicines);
                    }

                    _dbContext.DImMests.Add(dImMest);
                    _dbContext.SaveChanges();

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

        private async Task<ApiResult<DImpMestDto>> Update(DImpMestDto input)
        {
            var result = new ApiResult<DImpMestDto>();

            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var id = Guid.NewGuid();
                    var dateNow = DateTime.Now;

                    var dImMest = _mapper.Map<DImpMest>(input);
                    dImMest.ModifiedDate = dateNow;

                    // Đánh số tự động
                    if (string.IsNullOrEmpty(dImMest.Code))
                    {

                    }

                    // Nhập từ thuốc nhà cung cấp
                    if (input.ImExMestTypeId == 1)
                    {
                        // Xóa bản ghi cũ
                        var dImMestMedicineOlds = _dbContext.DImMestMedicines.Where(s => s.ImMestId == input.Id).ToList();
                        var sMedicineOldIds = dImMestMedicineOlds.Select(s => s.MedicineId).ToList();
                        var sMedicineOlds = _dbContext.SMedicines.Where(w => sMedicineOldIds.Contains(w.Id)).ToList();

                        if (dImMestMedicineOlds != null && sMedicineOlds != null)
                        {
                            foreach (var sMedicineOld in sMedicineOlds)
                            {
                                sMedicineOld.IsDeleted = true;
                                sMedicineOld.DeletedDate = dateNow;
                            }

                            _dbContext.SMedicines.UpdateRange(sMedicineOlds);
                            _dbContext.DImMestMedicines.RemoveRange(dImMestMedicineOlds);
                        }

                        var dImMestMedicines = new List<DImpMestMedicine>();
                        var sMedicines = new List<SMedicine>();

                        foreach (var dImMestMedicineDto in input.DImpMestMedicines)
                        {
                            var sMedicine = _mapper.Map<SMedicine>(dImMestMedicineDto);
                            if (GuidHelper.IsNullOrEmpty(sMedicine.Id))
                                sMedicine.Id = Guid.NewGuid();

                            sMedicine.CreatedDate = dateNow;
                            sMedicine.ModifiedDate = dateNow;

                            var dImMestMedicine = _mapper.Map<DImpMestMedicine>(dImMestMedicineDto);
                            if (GuidHelper.IsNullOrEmpty(dImMestMedicine.Id))
                                dImMestMedicine.Id = Guid.NewGuid();
                            dImMestMedicine.MedicineId = sMedicine.Id;
                            dImMestMedicine.ImMestId = input.Id;

                            dImMestMedicines.Add(dImMestMedicine);
                        }

                        _dbContext.SMedicines.AddRange(sMedicines);
                        _dbContext.DImMestMedicines.AddRange(dImMestMedicines);
                    }

                    _dbContext.DImMests.Add(dImMest);

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

        public async Task<ApiResult<DImpMestDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResultList<DImpMestDto>> GetAll(GetAllDImpMestInput input)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResultList<DImpMestDto>> GetByStock(Guid stockId, string fromDate, string toDate)
        {
            var result = new ApiResultList<DImpMestDto>();

            try
            {
                DateTime fromDateTime = DateTime.ParseExact(fromDate, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None);
                DateTime toDateTime = DateTime.ParseExact(toDate, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None);

                result.Result = (from dImMest in _dbContext.DImMests

                                 join imStock in _dbContext.SRooms on dImMest.ImStockId equals imStock.Id into imStockDefaults
                                 from imStockDefault in imStockDefaults.DefaultIfEmpty()

                                 join exStock in _dbContext.SRooms on dImMest.ExStockId equals exStock.Id into exStockDefaults
                                 from exStockDefault in exStockDefaults.DefaultIfEmpty()

                                 select new DImpMestDto()
                                 {
                                     Code = dImMest.Code,
                                     Name = dImMest.Code,
                                     ImpMestStatus = dImMest.ImpMestStatus,
                                     ImStockId = dImMest.ImStockId,
                                     ImStockCode = imStockDefault != null ? imStockDefault.Code : null,
                                     ImStockName = imStockDefault != null ? imStockDefault.Name : null,
                                     ExStockId = dImMest.ExStockId,
                                     ExStockCode = exStockDefault != null ? exStockDefault.Code : null,
                                     ExStockName = exStockDefault != null ? exStockDefault.Name : null,
                                     ImExMestTypeId = dImMest.ImExMestTypeId,
                                     ReceiverUserId = dImMest.ReceiverUserId,
                                     ApproverUserId = dImMest.ApproverUserId,
                                     ImpTime = dImMest.ImpTime,
                                     ApproverTime = dImMest.ApproverTime,
                                     Description = dImMest.Description,
                                     ReqRoomId = dImMest.ReqRoomId,
                                     ReqDepartmentId = dImMest.ReqDepartmentId,
                                     TreatmentId = dImMest.TreatmentId,
                                     PatientId = dImMest.PatientId,
                                     SupplierId = dImMest.SupplierId,
                                     InvTime = dImMest.InvTime,
                                     Deliverer = dImMest.Deliverer
                                 })
                                 .WhereIf(fromDateTime != (DateTime)default, w => w.InvTime >= fromDateTime)
                                 .WhereIf(toDateTime != (DateTime)default, w => w.InvTime <= toDateTime)
                                 .WhereIf(!GuidHelper.IsNullOrEmpty(stockId), w => w.ImStockId == stockId || w.ExStockId == stockId)
                                 .ToList();
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<DImpMestDto>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
