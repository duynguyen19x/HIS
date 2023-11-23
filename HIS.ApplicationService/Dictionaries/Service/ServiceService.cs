using AutoMapper;
using HIS.Core.Linq;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ExecutionRoom;
using HIS.Dtos.Dictionaries.Service;
using HIS.Dtos.Dictionaries.ServicePricePolicy;
using HIS.Dtos.Dictionaries.ServiceResultIndex;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore;
using HIS.Models.Commons;
using HIS.Utilities.Enums;
using HIS.Utilities.Helpers;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.Extensions.Configuration;
using System.Globalization;
using HIS.Core.Enums;

namespace HIS.ApplicationService.Dictionaries.Service
{
    public class ServiceService : BaseSerivce, IServiceService
    {
        public ServiceService(HISDbContext dbContext, IConfiguration config, IMapper mapper) : base(dbContext, config, mapper)
        {
        }

        public async Task<ApiResult<ServiceDto>> CreateOrEdit(ServiceDto input)
        {
            var result = await ValidSave(input);

            if (!result.IsSuccessed)
                return result;

            if (GuidHelper.IsNullOrEmpty(input.Id))
                return await Create(input);
            else
                return await Update(input);
        }

        private async Task<ApiResult<ServiceDto>> Create(ServiceDto input)
        {
            var result = new ApiResult<ServiceDto>();

            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var timeNow = DateTime.Now;
                    input.Id = Guid.NewGuid();

                    var data = _mapper.Map<EntityFrameworkCore.Entities.Categories.Service>(input);
                    data.CreatedDate = timeNow;
                    _dbContext.Services.Add(data);

                    if (input.SServicePricePolicies != null)
                    {
                        foreach (var sServicePricePolicy in input.SServicePricePolicies)
                        {
                            sServicePricePolicy.ExecutionTime = string.IsNullOrEmpty(sServicePricePolicy.ExecutionTimeString) ? null : DateTime.ParseExact(sServicePricePolicy.ExecutionTimeString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);
                        }

                        var sServicePricePolicys = _mapper.Map<List<EntityFrameworkCore.Entities.Categories.Services.ServicePricePolicy>>(input.SServicePricePolicies);
                        foreach (var sServicePricePolicy in sServicePricePolicys)
                        {
                            sServicePricePolicy.Id = Guid.NewGuid();
                            sServicePricePolicy.CreatedDate = timeNow;
                            sServicePricePolicy.ServiceId = data.Id;
                        }

                        _dbContext.ServicePricePolicies.AddRange(sServicePricePolicys);
                    }

                    if (!GuidHelper.IsNullOrEmpty(input.ServiceGroupHeInId))
                    {
                        var serviceGroupHeInTypes = new List<string>() { "XN", "CDHA", "TDCN", };

                        var serviceGroupHeIn = _dbContext.ServiceGroupHeIns.FirstOrDefault(f => f.Id == input.ServiceGroupHeInId);
                        if (serviceGroupHeIn != null && serviceGroupHeInTypes.Any(a => a == serviceGroupHeIn.Code) && input.SExecutionRooms != null)
                        {
                            var executionRoomDtos = input.SExecutionRooms.Where(w => w.IsCheck).ToList();
                            var executionRooms = _mapper.Map<List<ExecutionRoom>>(executionRoomDtos);
                            foreach (var executionRoom in executionRooms)
                            {
                                executionRoom.Id = Guid.NewGuid();
                                executionRoom.ServiceId = data.Id;
                            }

                            _dbContext.ExecutionRooms.AddRange(executionRooms);
                        }
                    }

                    if (input.SServiceResultIndices != null)
                    {
                        var serviceResultIndices = _mapper.Map<List<ServiceResultIndice>>(input.SServiceResultIndices);
                        foreach (var item in serviceResultIndices)
                        {
                            if (GuidHelper.IsNullOrEmpty(item.Id))
                                item.Id = Guid.NewGuid();

                            item.ServiceId = input.Id;
                        }

                        _dbContext.ServiceResultIndices.AddRange(serviceResultIndices);
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

        private async Task<ApiResult<ServiceDto>> Update(ServiceDto input)
        {
            var result = new ApiResult<ServiceDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var timeNow = DateTime.Now;

                    var sServicePricePolicyOlds = _dbContext.ServicePricePolicies.Where(w => w.ServiceId == input.Id).ToList();
                    var sExecutionRoomOlds = _dbContext.ExecutionRooms.Where(w => w.ServiceId == input.Id).ToList();
                    var sServiceResultIndexOlds = _dbContext.ServiceResultIndices.Where(w => w.ServiceId == input.Id).ToList();
                    _dbContext.ServicePricePolicies.RemoveRange(sServicePricePolicyOlds);
                    _dbContext.ExecutionRooms.RemoveRange(sExecutionRoomOlds);
                    _dbContext.ServiceResultIndices.RemoveRange(sServiceResultIndexOlds);

                    var sService = _dbContext.Services.FirstOrDefault(f => f.Id == input.Id);
                    if (sService != null)
                    {
                        _mapper.Map(input, sService);

                        if (input.SServicePricePolicies != null)
                        {
                            foreach (var sServicePricePolicy in input.SServicePricePolicies)
                            {
                                sServicePricePolicy.ExecutionTime = string.IsNullOrEmpty(sServicePricePolicy.ExecutionTimeString) ? null : DateTime.ParseExact(sServicePricePolicy.ExecutionTimeString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);
                            }

                            var sServicePricePolicys = _mapper.Map<List<EntityFrameworkCore.Entities.Categories.Services.ServicePricePolicy>>(input.SServicePricePolicies);
                            foreach (var sServicePricePolicy in sServicePricePolicys)
                            {
                                if (GuidHelper.IsNullOrEmpty(sServicePricePolicy.Id))
                                    sServicePricePolicy.Id = Guid.NewGuid();
                                sServicePricePolicy.CreatedDate = timeNow;
                                sServicePricePolicy.ModifiedDate = timeNow;
                                sServicePricePolicy.ServiceId = sService.Id;
                            }

                            _dbContext.ServicePricePolicies.AddRange(sServicePricePolicys);
                        }

                        if (!GuidHelper.IsNullOrEmpty(input.ServiceGroupHeInId))
                        {
                            var serviceGroupHeInTypes = new List<string>() { "XN", "CDHA", "TDCN", };

                            var serviceGroupHeIn = _dbContext.ServiceGroupHeIns.FirstOrDefault(f => f.Id == input.ServiceGroupHeInId);
                            if (serviceGroupHeIn != null && serviceGroupHeInTypes.Any(a => a == serviceGroupHeIn.Code))
                            {
                                var executionRoomDtos = input.SExecutionRooms.Where(w => w.IsCheck).ToList();
                                var executionRooms = _mapper.Map<List<ExecutionRoom>>(executionRoomDtos);
                                foreach (var executionRoom in executionRooms)
                                {
                                    if (GuidHelper.IsNullOrEmpty(executionRoom.Id))
                                        executionRoom.Id = Guid.NewGuid();

                                    executionRoom.ServiceId = sService.Id;
                                }

                                _dbContext.ExecutionRooms.AddRange(executionRooms);
                            }
                        }

                        if (input.SServiceResultIndices != null)
                        {
                            var serviceResultIndices = _mapper.Map<List<ServiceResultIndice>>(input.SServiceResultIndices);
                            foreach (var item in serviceResultIndices)
                            {
                                if (GuidHelper.IsNullOrEmpty(item.Id))
                                    item.Id = Guid.NewGuid();

                                item.ServiceId = sService.Id;
                            }

                            _dbContext.ServiceResultIndices.AddRange(serviceResultIndices);
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

        public async Task<ApiResult<ServiceDto>> Delete(Guid id)
        {
            var result = new ApiResult<ServiceDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var service = _dbContext.Services.SingleOrDefault(x => x.Id == id);
                    if (service != null)
                    {
                        service.DeletedDate = DateTime.Now;
                        service.IsDeleted = true;
                        _dbContext.Services.Update(service);

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

        public async Task<ApiResultList<ServiceDto>> GetAll(GetAllServiceInput input)
        {
            var result = new ApiResultList<ServiceDto>();

            try
            {
                result.Result = (from r in _dbContext.Services

                                 join r1 in _dbContext.Units on r.UnitId equals r1.Id
                                 join r2 in _dbContext.ServiceGroups on r.ServiceGroupId equals r2.Id
                                 join r3 in _dbContext.ServiceGroupHeIns on r.ServiceGroupHeInId equals r3.Id

                                 where r.IsDeleted == false
                                 select new ServiceDto()
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

        public async Task<ApiResult<ServiceDto>> GetById(Guid id)
        {
            var result = new ApiResult<ServiceDto>();

            var serviceDto = new ServiceDto();

            try
            {
                var rommTypes = new List<int?>()
                {
                    (int?)RoomTypes.LaboratoryTesting,
                    (int?)RoomTypes.DiagnosticImaging,
                };

                if (!GuidHelper.IsNullOrEmpty(id))
                {
                    var service = _dbContext.Services.FirstOrDefault(s => s.Id == id && s.IsDeleted == false);
                    var sServicePricePolicyDtos = (from ser in _dbContext.ServicePricePolicies
                                                   join pa in _dbContext.PatientObjectTypes on ser.PatientObjectTypeId equals pa.Id
                                                   where ser.ServiceId == id
                                                   select new ServicePricePolicyDto()
                                                   {
                                                       Id = ser.Id,
                                                       ServiceId = ser.ServiceId,
                                                       PatientObjectTypeId = ser.PatientObjectTypeId,
                                                       OldUnitPrice = ser.OldUnitPrice,
                                                       NewUnitPrice = ser.NewUnitPrice,
                                                       CeilingPrice = ser.CeilingPrice,
                                                       PaymentRate = ser.PaymentRate,
                                                       ExecutionTime = ser.ExecutionTime,
                                                       ExecutionTimeString = ser.ExecutionTime == null ? null : ser.ExecutionTime.Value.ToString("dd/MM/yyyy"),
                                                       PatientObjectTypeCode = pa.PatientObjectTypeCode,
                                                       PatientObjectTypeName = pa.PatientObjectTypeName,
                                                       IsHeIn = ser.PatientObjectTypeId == (int)HIS.Core.Enums.PatientObjectTypes.BHYT ? true : false,
                                                   }).OrderBy(s => s.PatientObjectTypeCode).ToList();

                    var sExecutionRoomDtos = (from room in _dbContext.Rooms
                                              join exec in _dbContext.ExecutionRooms.Where(w => w.ServiceId == id) on room.Id equals exec.RoomId into SExecutionRooms
                                              from s in SExecutionRooms.DefaultIfEmpty()
                                              where rommTypes.Contains(room.RoomTypeId)
                                              select new ExecutionRoomDto()
                                              {
                                                  Id = s != null ? s.Id : null,
                                                  RoomId = room.Id,
                                                  ServiceId = s != null ? s.ServiceId : null,
                                                  RoomCode = room.Code,
                                                  RoomName = room.Name,
                                                  IsMain = s != null ? s.IsMain : false,
                                                  IsCheck = s != null ? true : false,
                                              }).OrderBy(s => s.RoomCode).ToList();


                    var sServiceResultIndexs = _dbContext.ServiceResultIndices.Where(w => w.ServiceId == id).ToList();
                    var sServiceResultIndexDtos = _mapper.Map<IList<ServiceResultIndiceDto>>(sServiceResultIndexs);

                    serviceDto = _mapper.Map<ServiceDto>(service);
                    serviceDto.SServicePricePolicies = sServicePricePolicyDtos;
                    serviceDto.SExecutionRooms = sExecutionRoomDtos;
                    serviceDto.SServiceResultIndices = sServiceResultIndexDtos;
                }
                else
                {
                    var sServicePricePolicys = (from r in _dbContext.PatientObjectTypes
                                                where r.Inactive == false
                                                select new ServicePricePolicyDto()
                                                {
                                                    PatientObjectTypeId = r.Id,
                                                    PatientObjectTypeCode = r.PatientObjectTypeCode,
                                                    PatientObjectTypeName = r.PatientObjectTypeName,
                                                    IsHeIn = r.Id == (int)HIS.Core.Enums.PatientObjectTypes.BHYT ? true : false,
                                                }).OrderBy(o => o.PatientObjectTypeCode).ToList();

                    var sExecutionRooms = (from room in _dbContext.Rooms
                                           where room.Inactive == false
                                                && rommTypes.Contains(room.RoomTypeId)
                                           select new ExecutionRoomDto()
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

        public async Task<ApiResult<bool>> Import(IList<ServiceImportExcelDto> input)
        {
            var result = new ApiResult<bool>();

            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var sServiceUnits = _dbContext.Units.ToList();
                    var sServiceGroupHeIns = _dbContext.ServiceGroupHeIns.ToList();
                    var sServiceGroups = _dbContext.ServiceGroups.ToList();
                    var sSurgicalProcedureTypes = _dbContext.SurgicalProcedureTypes.ToList();
                    var sPatientTypes = _dbContext.PatientObjectTypes.ToList();
                    var sRooms = _dbContext.Rooms.ToList();

                    var sServiceDtos = new List<ServiceDto>();

                    foreach (var serviceImport in input)
                    {
                        var serviceDto = (ServiceDto)serviceImport;
                        serviceDto.Id = Guid.NewGuid();

                        serviceDto.SServicePricePolicies = new List<ServicePricePolicyDto>()
                        {
                            new ServicePricePolicyDto()
                            {
                                Id = Guid.NewGuid(),
                                ServiceId = serviceDto.Id,
                                OldUnitPrice = serviceImport.HeInPrice,
                                PatientObjectTypeCode = HIS.Core.Enums.PatientObjectTypes.BHYT.ToString(),
                                PaymentRate = serviceImport.PaymentRate,
                                CeilingPrice = serviceImport.CeilingPrice,
                                ExecutionTime = string.IsNullOrEmpty( serviceImport.ExecutionTimeString) ? null : DateTime.ParseExact(serviceImport.ExecutionTimeString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None),
                            },
                            new ServicePricePolicyDto()
                            {
                                Id = Guid.NewGuid(),
                                ServiceId = serviceDto.Id,
                                OldUnitPrice = serviceImport.ServicePrice,
                                PatientObjectTypeCode = HIS.Core.Enums.PatientObjectTypes.DV.ToString(),
                                ExecutionTime = string.IsNullOrEmpty( serviceImport.ExecutionTimeString) ? null : DateTime.ParseExact(serviceImport.ExecutionTimeString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None),
                            },
                            new ServicePricePolicyDto()
                            {
                                Id = Guid.NewGuid(),
                                ServiceId = serviceDto.Id,
                                OldUnitPrice = serviceImport.PeoplePrice,
                                PatientObjectTypeCode = HIS.Core.Enums.PatientObjectTypes.VP.ToString(),
                                ExecutionTime = string.IsNullOrEmpty( serviceImport.ExecutionTimeString) ? null : DateTime.ParseExact(serviceImport.ExecutionTimeString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None),
                            }
                        };

                        serviceDto.SExecutionRooms = new List<ExecutionRoomDto>()
                        {
                            new ExecutionRoomDto()
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

                    var Services = (from serviceDto in sServiceDtos
                                     join sServiceUnit in sServiceUnits on serviceDto.ServiceUnitCode equals sServiceUnit.Code
                                     join sServiceGroupHeIn in sServiceGroupHeIns on serviceDto.ServiceGroupHeInCode equals sServiceGroupHeIn.Code
                                     join sServiceGroup in sServiceGroups on serviceDto.ServiceGroupCode equals sServiceGroup.Code
                                     join sSurgicalProcedureType in sSurgicalProcedureTypes on serviceDto.SurgicalProcedureTypeCode equals sSurgicalProcedureType.Code into sSurgicalProcedureTypeTems
                                     from surg in sSurgicalProcedureTypeTems.DefaultIfEmpty()
                                     select new EntityFrameworkCore.Entities.Categories.Service()
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
                                               join sPatientType in sPatientTypes on servicePricePolicy.PatientObjectTypeCode equals sPatientType.PatientObjectTypeCode
                                               select new EntityFrameworkCore.Entities.Categories.Services.ServicePricePolicy()
                                               {
                                                   Id = servicePricePolicy.Id.GetValueOrDefault(),
                                                   PatientObjectTypeId = sPatientType.Id,
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
                                          select new ExecutionRoom()
                                          {
                                              Id = executionRoom.Id.GetValueOrDefault(),
                                              ServiceId = executionRoom.ServiceId,
                                              RoomId = sRoom.Id,
                                              IsMain = executionRoom.IsMain,
                                          }).ToList();

                    _dbContext.Services.AddRange(Services);
                    _dbContext.ServicePricePolicies.AddRange(servicePricePolicie);
                    _dbContext.ExecutionRooms.AddRange(executionRooms);

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

        public async Task<ApiResult<bool>> ImportServiceResultIndices(IList<ServiceResultIndiceDto> sServiceResultIndexs)
        {
            var result = new ApiResult<bool>();

            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var services = _dbContext.Services.ToList();

                    var serviceResultIndexs = (from resultIndex in sServiceResultIndexs
                                               join service in services on resultIndex.ServiceCode equals service.Code
                                               select new ServiceResultIndice()
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

                    _dbContext.ServiceResultIndices.AddRange(serviceResultIndexs);

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

        private async Task<ApiResult<ServiceDto>> ValidSave(ServiceDto input)
        {
            var result = new ApiResult<ServiceDto>();

            try
            {
                List<string> errs = new List<string>();

                var Services = _dbContext.Services.FirstOrDefault(w => w.Code == input.Code && w.Id != input.Id);
                if (Services != null)
                {
                    errs.Add(string.Format("Mã dịch vụ [{0}] đã tồn tại trên hệ thống!", input.Code));
                }

                var sServiceHein = _dbContext.Services.FirstOrDefault(w => w.Code == input.HeInCode && w.Id != input.Id);
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
