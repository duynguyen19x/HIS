using AutoMapper;
using HIS.Core.Linq.Extensions;
using HIS.Dtos.Dictionaries.ExecutionRoom;
using HIS.Dtos.Dictionaries.Service;
using HIS.Dtos.Dictionaries.ServicePricePolicy;
using HIS.Dtos.Dictionaries.ServiceResultIndex;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore;
using HIS.Utilities.Enums;
using HIS.Utilities.Helpers;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.Extensions.Configuration;
using System.Globalization;
using HIS.Application.Core.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionaries.Service
{
    public class ServiceService : BaseCrudAppService<ServiceDto, Guid?, GetAllServiceInput>, IServiceService
    {
        public ServiceService(HISDbContext dbContext, IConfiguration config, IMapper mapper) 
            : base(dbContext, mapper)
        {
        }

        public override async Task<ResultDto<ServiceDto>> CreateOrEdit(ServiceDto input)
        {
            var result = await ValidSave(input);
            if (!result.IsSucceeded)
                return result;

            if (GuidHelper.IsNullOrEmpty(input.Id))
                return await Create(input);
            else
                return await Update(input);
        }

        public override async Task<ResultDto<ServiceDto>> Create(ServiceDto input)
        {
            var result = new ResultDto<ServiceDto>();

            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var timeNow = DateTime.Now;
                    input.Id = Guid.NewGuid();

                    var data = ObjectMapper.Map<EntityFrameworkCore.Entities.Categories.Service>(input);
                    data.CreatedDate = timeNow;
                    Context.Services.Add(data);

                    if (input.SServicePricePolicies != null)
                    {
                        foreach (var sServicePricePolicy in input.SServicePricePolicies)
                        {
                            sServicePricePolicy.ExecutionTime = string.IsNullOrEmpty(sServicePricePolicy.ExecutionTimeString) ? null : DateTime.ParseExact(sServicePricePolicy.ExecutionTimeString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);
                        }

                        var sServicePricePolicys = ObjectMapper.Map<List<EntityFrameworkCore.Entities.Categories.Services.ServicePricePolicy>>(input.SServicePricePolicies);
                        foreach (var sServicePricePolicy in sServicePricePolicys)
                        {
                            sServicePricePolicy.Id = Guid.NewGuid();
                            sServicePricePolicy.CreatedDate = timeNow;
                            sServicePricePolicy.ServiceId = data.Id;
                        }

                        Context.ServicePricePolicies.AddRange(sServicePricePolicys);
                    }

                    if (!GuidHelper.IsNullOrEmpty(input.ServiceGroupHeInId))
                    {
                        var serviceGroupHeInTypes = new List<string>() { "XN", "CDHA", "TDCN", };

                        var serviceGroupHeIn = Context.ServiceGroupHeIns.FirstOrDefault(f => f.Id == input.ServiceGroupHeInId);
                        if (serviceGroupHeIn != null && serviceGroupHeInTypes.Any(a => a == serviceGroupHeIn.Code) && input.SExecutionRooms != null)
                        {
                            var executionRoomDtos = input.SExecutionRooms.Where(w => w.IsCheck).ToList();
                            var executionRooms = ObjectMapper.Map<List<ExecutionRoom>>(executionRoomDtos);
                            foreach (var executionRoom in executionRooms)
                            {
                                executionRoom.Id = Guid.NewGuid();
                                executionRoom.ServiceId = data.Id;
                            }

                            Context.ExecutionRooms.AddRange(executionRooms);
                        }
                    }

                    if (input.SServiceResultIndices != null)
                    {
                        var serviceResultIndices = ObjectMapper.Map<List<ServiceResultIndice>>(input.SServiceResultIndices);
                        foreach (var item in serviceResultIndices)
                        {
                            if (GuidHelper.IsNullOrEmpty(item.Id))
                                item.Id = Guid.NewGuid();

                            item.ServiceId = input.Id;
                        }

                        Context.ServiceResultIndices.AddRange(serviceResultIndices);
                    }

                    await Context.SaveChangesAsync();

                    result.IsSucceeded = true;
                    result.Result = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSucceeded = false;
                    result.Message = ex.Message;
                }
                finally
                {
                    transaction.Dispose();
                }
            }

            return await Task.FromResult(result);
        }

        public  override async Task<ResultDto<ServiceDto>> Update(ServiceDto input)
        {
            var result = new ResultDto<ServiceDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var timeNow = DateTime.Now;

                    var sServicePricePolicyOlds = Context.ServicePricePolicies.Where(w => w.ServiceId == input.Id).ToList();
                    var sExecutionRoomOlds = Context.ExecutionRooms.Where(w => w.ServiceId == input.Id).ToList();
                    var sServiceResultIndexOlds = Context.ServiceResultIndices.Where(w => w.ServiceId == input.Id).ToList();
                    Context.ServicePricePolicies.RemoveRange(sServicePricePolicyOlds);
                    Context.ExecutionRooms.RemoveRange(sExecutionRoomOlds);
                    Context.ServiceResultIndices.RemoveRange(sServiceResultIndexOlds);

                    var sService = Context.Services.FirstOrDefault(f => f.Id == input.Id);
                    if (sService != null)
                    {
                        ObjectMapper.Map(input, sService);

                        if (input.SServicePricePolicies != null)
                        {
                            foreach (var sServicePricePolicy in input.SServicePricePolicies)
                            {
                                sServicePricePolicy.ExecutionTime = string.IsNullOrEmpty(sServicePricePolicy.ExecutionTimeString) ? null : DateTime.ParseExact(sServicePricePolicy.ExecutionTimeString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);
                            }

                            var sServicePricePolicys = ObjectMapper.Map<List<EntityFrameworkCore.Entities.Categories.Services.ServicePricePolicy>>(input.SServicePricePolicies);
                            foreach (var sServicePricePolicy in sServicePricePolicys)
                            {
                                if (GuidHelper.IsNullOrEmpty(sServicePricePolicy.Id))
                                    sServicePricePolicy.Id = Guid.NewGuid();
                                sServicePricePolicy.CreatedDate = timeNow;
                                sServicePricePolicy.ModifiedDate = timeNow;
                                sServicePricePolicy.ServiceId = sService.Id;
                            }

                            Context.ServicePricePolicies.AddRange(sServicePricePolicys);
                        }

                        if (!GuidHelper.IsNullOrEmpty(input.ServiceGroupHeInId))
                        {
                            var serviceGroupHeInTypes = new List<string>() { "XN", "CDHA", "TDCN", };

                            var serviceGroupHeIn = Context.ServiceGroupHeIns.FirstOrDefault(f => f.Id == input.ServiceGroupHeInId);
                            if (serviceGroupHeIn != null && serviceGroupHeInTypes.Any(a => a == serviceGroupHeIn.Code))
                            {
                                var executionRoomDtos = input.SExecutionRooms.Where(w => w.IsCheck).ToList();
                                var executionRooms = ObjectMapper.Map<List<ExecutionRoom>>(executionRoomDtos);
                                foreach (var executionRoom in executionRooms)
                                {
                                    if (GuidHelper.IsNullOrEmpty(executionRoom.Id))
                                        executionRoom.Id = Guid.NewGuid();

                                    executionRoom.ServiceId = sService.Id;
                                }

                                Context.ExecutionRooms.AddRange(executionRooms);
                            }
                        }

                        if (input.SServiceResultIndices != null)
                        {
                            var serviceResultIndices = ObjectMapper.Map<List<ServiceResultIndice>>(input.SServiceResultIndices);
                            foreach (var item in serviceResultIndices)
                            {
                                if (GuidHelper.IsNullOrEmpty(item.Id))
                                    item.Id = Guid.NewGuid();

                                item.ServiceId = sService.Id;
                            }

                            Context.ServiceResultIndices.AddRange(serviceResultIndices);
                        }
                    }

                    Context.SaveChanges();

                    result.IsSucceeded = true;
                    result.Result = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSucceeded = false;
                    result.Message = ex.Message;
                    transaction.Rollback();
                }
            }
            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<ServiceDto>> Delete(Guid? id)
        {
            var result = new ResultDto<ServiceDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var service = Context.Services.SingleOrDefault(x => x.Id == id);
                    if (service != null)
                    {
                        service.DeletedDate = DateTime.Now;
                        service.IsDeleted = true;
                        Context.Services.Update(service);

                        await Context.SaveChangesAsync();
                        result.IsSucceeded = true;

                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    result.IsSucceeded = false;
                    result.Message = ex.Message;
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public override async Task<PagedResultDto<ServiceDto>> GetAll(GetAllServiceInput input)
        {
            var result = new PagedResultDto<ServiceDto>();

            try
            {
                result.Result = (from r in Context.Services

                                 join r1 in Context.Units on r.UnitId equals r1.Id
                                 join r2 in Context.ServiceGroups on r.ServiceGroupId equals r2.Id
                                 join r3 in Context.ServiceGroupHeIns on r.ServiceGroupHeInId equals r3.Id

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
                result.IsSucceeded = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<ServiceDto>> GetById(Guid? id)
        {
            var result = new ResultDto<ServiceDto>();

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
                    var service = Context.Services.FirstOrDefault(s => s.Id == id && s.IsDeleted == false);
                    var sServicePricePolicyDtos = (from ser in Context.ServicePricePolicies
                                                   join pa in Context.PatientTypes on ser.PatientTypeId equals pa.Id
                                                   where ser.ServiceId == id
                                                   select new ServicePricePolicyDto()
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
                                                       IsHeIn = ser.PatientTypeId == (int)HIS.Core.Enums.PatientTypes.BHYT ? true : false,
                                                   }).OrderBy(s => s.PatientTypeCode).ToList();

                    var sExecutionRoomDtos = (from room in Context.Rooms
                                              join exec in Context.ExecutionRooms.Where(w => w.ServiceId == id) on room.Id equals exec.RoomId into SExecutionRooms
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


                    var sServiceResultIndexs = Context.ServiceResultIndices.Where(w => w.ServiceId == id).ToList();
                    var sServiceResultIndexDtos = ObjectMapper.Map<IList<ServiceResultIndiceDto>>(sServiceResultIndexs);

                    serviceDto = ObjectMapper.Map<ServiceDto>(service);
                    serviceDto.SServicePricePolicies = sServicePricePolicyDtos;
                    serviceDto.SExecutionRooms = sExecutionRoomDtos;
                    serviceDto.SServiceResultIndices = sServiceResultIndexDtos;
                }
                else
                {
                    var sServicePricePolicys = (from r in Context.PatientTypes
                                                where r.Inactive == false
                                                select new ServicePricePolicyDto()
                                                {
                                                    PatientTypeId = r.Id,
                                                    PatientTypeCode = r.Code,
                                                    PatientTypeName = r.Name,
                                                    IsHeIn = r.Id == (int)HIS.Core.Enums.PatientTypes.BHYT ? true : false,
                                                }).OrderBy(o => o.PatientTypeCode).ToList();

                    var sExecutionRooms = (from room in Context.Rooms
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
                result.IsSucceeded = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ResultDto<bool>> Import(IList<ServiceImportExcelDto> input)
        {
            var result = new ResultDto<bool>();

            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var sServiceUnits = Context.Units.ToList();
                    var sServiceGroupHeIns = Context.ServiceGroupHeIns.ToList();
                    var sServiceGroups = Context.ServiceGroups.ToList();
                    var sSurgicalProcedureTypes = Context.SurgicalProcedureTypes.ToList();
                    var sPatientTypes = Context.PatientTypes.ToList();
                    var sRooms = Context.Rooms.ToList();

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
                                PatientTypeCode = HIS.Core.Enums.PatientTypes.BHYT.ToString(),
                                PaymentRate = serviceImport.PaymentRate,
                                CeilingPrice = serviceImport.CeilingPrice,
                                ExecutionTime = string.IsNullOrEmpty( serviceImport.ExecutionTimeString) ? null : DateTime.ParseExact(serviceImport.ExecutionTimeString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None),
                            },
                            new ServicePricePolicyDto()
                            {
                                Id = Guid.NewGuid(),
                                ServiceId = serviceDto.Id,
                                OldUnitPrice = serviceImport.ServicePrice,
                                PatientTypeCode = HIS.Core.Enums.PatientTypes.DV.ToString(),
                                ExecutionTime = string.IsNullOrEmpty( serviceImport.ExecutionTimeString) ? null : DateTime.ParseExact(serviceImport.ExecutionTimeString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None),
                            },
                            new ServicePricePolicyDto()
                            {
                                Id = Guid.NewGuid(),
                                ServiceId = serviceDto.Id,
                                OldUnitPrice = serviceImport.PeoplePrice,
                                PatientTypeCode = HIS.Core.Enums.PatientTypes.VP.ToString(),
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
                                               join sPatientType in sPatientTypes on servicePricePolicy.PatientTypeCode equals sPatientType.Code
                                               select new EntityFrameworkCore.Entities.Categories.Services.ServicePricePolicy()
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
                                          select new ExecutionRoom()
                                          {
                                              Id = executionRoom.Id.GetValueOrDefault(),
                                              ServiceId = executionRoom.ServiceId,
                                              RoomId = sRoom.Id,
                                              IsMain = executionRoom.IsMain,
                                          }).ToList();

                    Context.Services.AddRange(Services);
                    Context.ServicePricePolicies.AddRange(servicePricePolicie);
                    Context.ExecutionRooms.AddRange(executionRooms);

                    Context.SaveChanges();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSucceeded = false;
                    result.Message = ex.Message;
                    transaction.Rollback();
                }
            }

            return await Task.FromResult(result);
        }

        public async Task<ResultDto<bool>> ImportServiceResultIndices(IList<ServiceResultIndiceDto> sServiceResultIndexs)
        {
            var result = new ResultDto<bool>();

            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var services = Context.Services.ToList();

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
                                                   Normal = resultIndex.Normal,
                                               }).ToList();

                    Context.ServiceResultIndices.AddRange(serviceResultIndexs);

                    Context.SaveChanges();
                }
                catch (Exception ex)
                {
                    result.IsSucceeded = false;
                    result.Message = ex.Message;
                    transaction.Rollback();
                }
                finally { transaction.Commit(); }
            }

            return await Task.FromResult(result);
        }

        private async Task<ResultDto<ServiceDto>> ValidSave(ServiceDto input)
        {
            var result = new ResultDto<ServiceDto>();

            try
            {
                List<string> errs = new List<string>();

                var Services = Context.Services.FirstOrDefault(w => w.Code == input.Code && w.Id != input.Id);
                if (Services != null)
                {
                    errs.Add(string.Format("Mã dịch vụ [{0}] đã tồn tại trên hệ thống!", input.Code));
                }

                var sServiceHein = Context.Services.FirstOrDefault(w => w.Code == input.HeInCode && w.Id != input.Id);
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
                    result.IsSucceeded = false;
                    result.Message = string.Join("\n", errs);
                }
            }
            catch (Exception ex)
            {
                result.IsSucceeded = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }
    }
}
