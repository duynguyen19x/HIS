using AutoMapper;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ExecutionRoom;
using HIS.Dtos.Dictionaries.Room;
using HIS.Dtos.Dictionaries.Service;
using HIS.Dtos.Dictionaries.ServicePricePolicy;
using HIS.Dtos.Dictionaries.ServiceResultIndex;
using HIS.EntityFrameworkCore.DbContexts;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Models.Commons;
using HIS.Utilities.Enums;
using HIS.Utilities.Helpers;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.Service
{
    public class ServiceService : BaseSerivce, IServiceService
    {
        public ServiceService(HIS_DbContext dbContext, IConfiguration config, IMapper mapper) : base(dbContext, config, mapper)
        {
        }

        public async Task<ApiResult<SServiceDto>> CreateOrEdit(SServiceDto input)
        {
            var result = await ValidSave(input);

            if (!result.IsSuccessed)
                return result;

            if (GuidHelper.IsNullOrEmpty(input.Id))
                return await Create(input);
            else
                return await Update(input);
        }

        private async Task<ApiResult<SServiceDto>> Create(SServiceDto input)
        {
            var result = new ApiResult<SServiceDto>();

            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var timeNow = DateTime.Now;
                    input.Id = Guid.NewGuid();

                    var data = _mapper.Map<SService>(input);
                    data.CreatedDate = timeNow;
                    _dbContext.SServices.Add(data);

                    if (input.SServicePricePolicies != null)
                    {
                        foreach (var sServicePricePolicy in input.SServicePricePolicies)
                        {
                            sServicePricePolicy.ExecutionTime = string.IsNullOrEmpty(sServicePricePolicy.ExecutionTimeString) ? null : DateTime.ParseExact(sServicePricePolicy.ExecutionTimeString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);
                        }

                        var sServicePricePolicys = _mapper.Map<List<SServicePricePolicy>>(input.SServicePricePolicies);
                        foreach (var sServicePricePolicy in sServicePricePolicys)
                        {
                            sServicePricePolicy.Id = Guid.NewGuid();
                            sServicePricePolicy.CreatedDate = timeNow;
                            sServicePricePolicy.ServiceId = data.Id;
                        }

                        _dbContext.SServicePricePolicies.AddRange(sServicePricePolicys);
                    }

                    if (!GuidHelper.IsNullOrEmpty(input.ServiceGroupHeInId))
                    {
                        var serviceGroupHeInTypes = new List<string>() { "XN", "CDHA", "TDCN", };

                        var serviceGroupHeIn = _dbContext.SServiceGroupHeIns.FirstOrDefault(f => f.Id == input.ServiceGroupHeInId);
                        if (serviceGroupHeIn != null && serviceGroupHeInTypes.Any(a => a == serviceGroupHeIn.Code) && input.SExecutionRooms != null)
                        {
                            var executionRoomDtos = input.SExecutionRooms.Where(w => w.IsCheck).ToList();
                            var executionRooms = _mapper.Map<List<SExecutionRoom>>(executionRoomDtos);
                            foreach (var executionRoom in executionRooms)
                            {
                                executionRoom.Id = Guid.NewGuid();
                                executionRoom.ServiceId = data.Id;
                            }

                            _dbContext.SExecutionRooms.AddRange(executionRooms);
                        }
                    }

                    if (input.SServiceResultIndices != null)
                    {
                        var serviceResultIndices = _mapper.Map<List<SServiceResultIndice>>(input.SServiceResultIndices);
                        foreach (var item in serviceResultIndices)
                        {
                            if (GuidHelper.IsNullOrEmpty(item.Id))
                                item.Id = Guid.NewGuid();

                            item.ServiceId = input.Id;
                        }

                        _dbContext.SServiceResultIndices.AddRange(serviceResultIndices);
                    }

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

        private async Task<ApiResult<SServiceDto>> Update(SServiceDto input)
        {
            var result = new ApiResult<SServiceDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var timeNow = DateTime.Now;

                    var sServicePricePolicyOlds = _dbContext.SServicePricePolicies.Where(w => w.ServiceId == input.Id).ToList();
                    var sExecutionRoomOlds = _dbContext.SExecutionRooms.Where(w => w.ServiceId == input.Id).ToList();
                    var sServiceResultIndexOlds = _dbContext.SServiceResultIndices.Where(w => w.ServiceId == input.Id).ToList();
                    _dbContext.SServicePricePolicies.RemoveRange(sServicePricePolicyOlds);
                    _dbContext.SExecutionRooms.RemoveRange(sExecutionRoomOlds);
                    _dbContext.SServiceResultIndices.RemoveRange(sServiceResultIndexOlds);

                    var sService = _dbContext.SServices.FirstOrDefault(f => f.Id == input.Id);
                    if (sService != null)
                    {
                        _mapper.Map(input, sService);

                        if (input.SServicePricePolicies != null)
                        {
                            foreach (var sServicePricePolicy in input.SServicePricePolicies)
                            {
                                sServicePricePolicy.ExecutionTime = string.IsNullOrEmpty(sServicePricePolicy.ExecutionTimeString) ? null : DateTime.ParseExact(sServicePricePolicy.ExecutionTimeString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);
                            }

                            var sServicePricePolicys = _mapper.Map<List<SServicePricePolicy>>(input.SServicePricePolicies);
                            foreach (var sServicePricePolicy in sServicePricePolicys)
                            {
                                if (GuidHelper.IsNullOrEmpty(sServicePricePolicy.Id))
                                    sServicePricePolicy.Id = Guid.NewGuid();
                                sServicePricePolicy.CreatedDate = timeNow;
                                sServicePricePolicy.ModifiedDate = timeNow;
                                sServicePricePolicy.ServiceId = sService.Id;
                            }

                            _dbContext.SServicePricePolicies.AddRange(sServicePricePolicys);
                        }

                        if (!GuidHelper.IsNullOrEmpty(input.ServiceGroupHeInId))
                        {
                            var serviceGroupHeInTypes = new List<string>() { "XN", "CDHA", "TDCN", };

                            var serviceGroupHeIn = _dbContext.SServiceGroupHeIns.FirstOrDefault(f => f.Id == input.ServiceGroupHeInId);
                            if (serviceGroupHeIn != null && serviceGroupHeInTypes.Any(a => a == serviceGroupHeIn.Code))
                            {
                                var executionRoomDtos = input.SExecutionRooms.Where(w => w.IsCheck).ToList();
                                var executionRooms = _mapper.Map<List<SExecutionRoom>>(executionRoomDtos);
                                foreach (var executionRoom in executionRooms)
                                {
                                    if (GuidHelper.IsNullOrEmpty(executionRoom.Id))
                                        executionRoom.Id = Guid.NewGuid();

                                    executionRoom.ServiceId = sService.Id;
                                }

                                _dbContext.SExecutionRooms.AddRange(executionRooms);
                            }
                        }

                        if (input.SServiceResultIndices != null)
                        {
                            var serviceResultIndices = _mapper.Map<List<SServiceResultIndice>>(input.SServiceResultIndices);
                            foreach (var item in serviceResultIndices)
                            {
                                if (GuidHelper.IsNullOrEmpty(item.Id))
                                    item.Id = Guid.NewGuid();

                                item.ServiceId = sService.Id;
                            }

                            _dbContext.SServiceResultIndices.AddRange(serviceResultIndices);
                        }
                    }

                    _dbContext.SaveChanges();

                    result.IsSuccessed = true;
                    result.Result = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;
                    transaction.Rollback();
                }
            }
            return await Task.FromResult(result);
        }

        public async Task<ApiResult<SServiceDto>> Delete(Guid id)
        {
            var result = new ApiResult<SServiceDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var service = _dbContext.SServices.SingleOrDefault(x => x.Id == id);
                    if (service != null)
                    {
                        service.DeleteDate = DateTime.Now;
                        service.IsDelete = true;
                        _dbContext.SServices.Update(service);

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

        public async Task<ApiResultList<SServiceDto>> GetAll(GetAllSServiceInput input)
        {
            var result = new ApiResultList<SServiceDto>();

            try
            {
                result.Result = (from r in _dbContext.SServices

                                 join r1 in _dbContext.SServiceUnits on r.UnitId equals r1.Id
                                 join r2 in _dbContext.SServiceGroups on r.ServiceGroupId equals r2.Id
                                 join r3 in _dbContext.SServiceGroupHeIns on r.ServiceGroupHeInId equals r3.Id

                                 where r.IsDelete == false
                                 select new SServiceDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     HeInCode = r.HeInCode,
                                     HeInName = r.HeInName,
                                     Inactive = r.Inactive,
                                     ServiceGroupId = r.ServiceGroupId,
                                     ServiceGroupHeInId = r.ServiceGroupId,
                                     UnitId = r.UnitId,
                                     SurgicalProcedureTypeId = r.SurgicalProcedureTypeId,

                                     ServiceUnitCode = r1.Code,
                                     ServiceUnitName = r1.Name,
                                     ServiceGroupCode = r2.Code,
                                     ServiceGroupName = r2.Name,
                                     ServiceGroupHeInCode = r3.Name,
                                     ServiceGroupHeInName = r3.Name,
                                 }).WhereIf(input.InactiveFilter != null, w => w.Inactive == input.InactiveFilter).OrderBy(o => o.Code).ToList();

                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<SServiceDto>> GetById(Guid id)
        {
            var result = new ApiResult<SServiceDto>();

            var serviceDto = new SServiceDto();

            try
            {
                var rommTypes = new List<int?>()
                {
                    (int?)RoomTypes.LaboratoryTesting,
                    (int?)RoomTypes.DiagnosticImaging,
                };

                if (!GuidHelper.IsNullOrEmpty(id))
                {
                    var service = _dbContext.SServices.FirstOrDefault(s => s.Id == id && s.IsDelete == false);
                    var sServicePricePolicyDtos = (from ser in _dbContext.SServicePricePolicies
                                                   join pa in _dbContext.SPatientTypes on ser.PatientTypeId equals pa.Id
                                                   where ser.ServiceId == id
                                                   select new SServicePricePolicyDto()
                                                   {
                                                       Id = ser.Id,
                                                       ServiceId = ser.ServiceId,
                                                       PatientTypeId = ser.PatientTypeId,
                                                       OldUnitPrice = ser.OldUnitPrice,
                                                       NewUnitPrice = ser.NewUnitPrice,
                                                       CeilingPrice = ser.CeilingPrice,
                                                       PaymentRate = ser.PaymentRate,
                                                       ExecutionTime = ser.ExecutionTime,
                                                       ExecutionTimeString = ser.ExecutionTime == null ? null : ser.ExecutionTime.Value.ToString("dd/MM/yyyy"),
                                                       PatientTypeCode = pa.Code,
                                                       PatientTypeName = pa.Name,
                                                       IsHeIn = pa.Code == PatientTypes.BHYT ? true : false,
                                                   }).OrderBy(s => s.PatientTypeCode).ToList();

                    var sExecutionRoomDtos = (from room in _dbContext.SRooms
                                              join exec in _dbContext.SExecutionRooms.Where(w => w.ServiceId == id) on room.Id equals exec.RoomId into SExecutionRooms
                                              from s in SExecutionRooms.DefaultIfEmpty()
                                              where rommTypes.Contains(room.RoomTypeId)
                                              select new SExecutionRoomDto()
                                              {
                                                  Id = s != null ? s.Id : null,
                                                  RoomId = room.Id,
                                                  ServiceId = s != null ? s.ServiceId : null,
                                                  RoomCode = room.Code,
                                                  RoomName = room.Name,
                                                  IsMain = s != null ? s.IsMain : false,
                                                  IsCheck = s != null ? true : false,
                                              }).OrderBy(s => s.RoomCode).ToList();


                    var sServiceResultIndexs = _dbContext.SServiceResultIndices.Where(w => w.ServiceId == id).ToList();
                    var sServiceResultIndexDtos = _mapper.Map<IList<SServiceResultIndiceDto>>(sServiceResultIndexs);

                    serviceDto = _mapper.Map<SServiceDto>(service);
                    serviceDto.SServicePricePolicies = sServicePricePolicyDtos;
                    serviceDto.SExecutionRooms = sExecutionRoomDtos;
                    serviceDto.SServiceResultIndices = sServiceResultIndexDtos;
                }
                else
                {
                    var sServicePricePolicys = (from r in _dbContext.SPatientTypes
                                                where r.Inactive == false
                                                select new SServicePricePolicyDto()
                                                {
                                                    PatientTypeId = r.Id,
                                                    PatientTypeCode = r.Code,
                                                    PatientTypeName = r.Name,
                                                    IsHeIn = r.Code == PatientTypes.BHYT ? true : false,
                                                }).OrderBy(o => o.PatientTypeCode).ToList();

                    var sExecutionRooms = (from room in _dbContext.SRooms
                                           where room.Inactive == false
                                                && rommTypes.Contains(room.RoomTypeId)
                                           select new SExecutionRoomDto()
                                           {
                                               RoomId = room.Id,
                                               RoomCode = room.Code,
                                               RoomName = room.Name,
                                           }).OrderBy(s => s.RoomCode).ToList();

                    serviceDto.SServicePricePolicies = sServicePricePolicys;
                    serviceDto.SExecutionRooms = sExecutionRooms;
                }

                result.Result = serviceDto;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<bool>> Import(IList<SServiceImportExcelDto> input)
        {
            var result = new ApiResult<bool>();

            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var sServiceUnits = _dbContext.SServiceUnits.ToList();
                    var sServiceGroupHeIns = _dbContext.SServiceGroupHeIns.ToList();
                    var sServiceGroups = _dbContext.SServiceGroups.ToList();
                    var sSurgicalProcedureTypes = _dbContext.SSurgicalProcedureTypes.ToList();
                    var sPatientTypes = _dbContext.SPatientTypes.ToList();
                    var sRooms = _dbContext.SRooms.ToList();

                    var sServiceDtos = new List<SServiceDto>();

                    foreach (var serviceImport in input)
                    {
                        var serviceDto = (SServiceDto)serviceImport;
                        serviceDto.Id = Guid.NewGuid();

                        serviceDto.SServicePricePolicies = new List<SServicePricePolicyDto>()
                        {
                            new SServicePricePolicyDto()
                            {
                                Id = Guid.NewGuid(),
                                ServiceId = serviceDto.Id,
                                OldUnitPrice = serviceImport.HeInPrice,
                                PatientTypeCode = PatientTypes.BHYT,
                                PaymentRate = serviceImport.PaymentRate,
                                CeilingPrice = serviceImport.CeilingPrice,
                                ExecutionTime = string.IsNullOrEmpty( serviceImport.ExecutionTimeString) ? null : DateTime.ParseExact(serviceImport.ExecutionTimeString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None),
                            },
                            new SServicePricePolicyDto()
                            {
                                Id = Guid.NewGuid(),
                                ServiceId = serviceDto.Id,
                                OldUnitPrice = serviceImport.ServicePrice,
                                PatientTypeCode = PatientTypes.DV,
                                ExecutionTime = string.IsNullOrEmpty( serviceImport.ExecutionTimeString) ? null : DateTime.ParseExact(serviceImport.ExecutionTimeString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None),
                            },
                            new SServicePricePolicyDto()
                            {
                                Id = Guid.NewGuid(),
                                ServiceId = serviceDto.Id,
                                OldUnitPrice = serviceImport.PeoplePrice,
                                PatientTypeCode = PatientTypes.VP,
                                ExecutionTime = string.IsNullOrEmpty( serviceImport.ExecutionTimeString) ? null : DateTime.ParseExact(serviceImport.ExecutionTimeString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None),
                            }
                        };

                        serviceDto.SExecutionRooms = new List<SExecutionRoomDto>()
                        {
                            new SExecutionRoomDto()
                            {
                                Id = Guid.NewGuid(),
                                ServiceId = serviceDto.Id,
                                RoomCode = serviceImport.ExecutionRoomCode,
                                IsCheck = true,
                                IsMain = true,
                            }
                        };

                        sServiceDtos.Add(serviceDto);
                    }

                    var sServices = (from serviceDto in sServiceDtos
                                     join sServiceUnit in sServiceUnits on serviceDto.ServiceUnitCode equals sServiceUnit.Code
                                     join sServiceGroupHeIn in sServiceGroupHeIns on serviceDto.ServiceGroupHeInCode equals sServiceGroupHeIn.Code
                                     join sServiceGroup in sServiceGroups on serviceDto.ServiceGroupCode equals sServiceGroup.Code
                                     join sSurgicalProcedureType in sSurgicalProcedureTypes on serviceDto.SurgicalProcedureTypeCode equals sSurgicalProcedureType.Code into sSurgicalProcedureTypeTems
                                     from surg in sSurgicalProcedureTypeTems.DefaultIfEmpty()
                                     select new SService()
                                     {
                                         Id = serviceDto.Id.GetValueOrDefault(),
                                         Code = serviceDto.Code,
                                         Name = serviceDto.Name,
                                         HeInCode = serviceDto.HeInCode,
                                         HeInName = serviceDto.HeInName,
                                         SortOrder = serviceDto.SortOrder,
                                         Inactive = serviceDto.Inactive,
                                         UnitId = sServiceUnit.Id,
                                         ServiceGroupId = sServiceGroup.Id,
                                         ServiceGroupHeInId = sServiceGroupHeIn.Id,
                                         SurgicalProcedureTypeId = surg == null ? null : surg.Id,
                                     }).ToList();

                    var servicePricePolicieDtos = sServiceDtos.SelectMany(s => s.SServicePricePolicies).ToList();
                    var servicePricePolicie = (from servicePricePolicy in servicePricePolicieDtos
                                               join sPatientType in sPatientTypes on servicePricePolicy.PatientTypeCode equals sPatientType.Code
                                               select new SServicePricePolicy()
                                               {
                                                   Id = servicePricePolicy.Id.GetValueOrDefault(),
                                                   PatientTypeId = sPatientType.Id,
                                                   ServiceId = servicePricePolicy.ServiceId,
                                                   OldUnitPrice = servicePricePolicy.OldUnitPrice,
                                                   NewUnitPrice = servicePricePolicy.NewUnitPrice,
                                                   PaymentRate = servicePricePolicy.PaymentRate,
                                                   CeilingPrice = servicePricePolicy.CeilingPrice,
                                                   ExecutionTime = servicePricePolicy.ExecutionTime,
                                               }).ToList();

                    var executionRoomDtos = sServiceDtos.SelectMany(s => s.SExecutionRooms).ToList();
                    var executionRooms = (from executionRoom in executionRoomDtos
                                          join sRoom in sRooms on executionRoom.RoomCode equals sRoom.Code
                                          select new SExecutionRoom()
                                          {
                                              Id = executionRoom.Id.GetValueOrDefault(),
                                              ServiceId = executionRoom.ServiceId,
                                              RoomId = sRoom.Id,
                                              IsMain = executionRoom.IsMain,
                                          }).ToList();

                    _dbContext.SServices.AddRange(sServices);
                    _dbContext.SServicePricePolicies.AddRange(servicePricePolicie);
                    _dbContext.SExecutionRooms.AddRange(executionRooms);

                    _dbContext.SaveChanges();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;
                    transaction.Rollback();
                }
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<bool>> ImportServiceResultIndices(IList<SServiceResultIndiceDto> sServiceResultIndexs)
        {
            var result = new ApiResult<bool>();

            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var services = _dbContext.SServices.ToList();

                    var serviceResultIndexs = (from resultIndex in sServiceResultIndexs
                                               join service in services on resultIndex.ServiceCode equals service.Code
                                               select new SServiceResultIndice()
                                               {
                                                   Id = Guid.NewGuid(),
                                                   Code = resultIndex.Code,
                                                   Name = resultIndex.Name,
                                                   Unit = resultIndex.Unit,
                                                   MaleFrom = resultIndex.MaleFrom,
                                                   MaleTo = resultIndex.MaleTo,
                                                   FemaleFrom = resultIndex.FemaleFrom,
                                                   FemaleTo = resultIndex.FemaleTo,
                                                   ServiceId = service.Id,
                                                   Inactive = resultIndex.Inactive,
                                                   SortOrder = resultIndex.SortOrder,
                                               }).ToList();

                    _dbContext.SServiceResultIndices.AddRange(serviceResultIndexs);

                    _dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;
                    transaction.Rollback();
                }
                finally { transaction.Commit(); }
            }

            return await Task.FromResult(result);
        }

        private async Task<ApiResult<SServiceDto>> ValidSave(SServiceDto input)
        {
            var result = new ApiResult<SServiceDto>();

            try
            {
                List<string> errs = new List<string>();

                var sServices = _dbContext.SServices.FirstOrDefault(w => w.Code == input.Code && w.Id != input.Id);
                if (sServices != null)
                {
                    errs.Add(string.Format("Mã dịch vụ [{0}] đã tồn tại trên hệ thống!", input.Code));
                }

                var sServiceHein = _dbContext.SServices.FirstOrDefault(w => w.Code == input.HeInCode && w.Id != input.Id);
                if (sServiceHein != null)
                {
                    errs.Add(string.Format("Mã BHYT [{0}] đã tồn tại trên hệ thống!", input.HeInName));
                }

                if (input.SServiceResultIndices != null && input.SServiceResultIndices.Count > 0)
                {
                    var listCode = input.SServiceResultIndices.GroupBy(g => g.Code).Select(s => new
                    {
                        Code = s.Key,
                        Count = s.Count()
                    }).Where(w => w.Count > 1).ToList();

                    if (listCode != null && listCode.Count > 0)
                    {
                        errs.Add(string.Format("Mã trị số [{0}] đã trùng!", string.Join(", ", listCode.Select(s => s.Code).ToArray())));
                    }
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
    }
}
