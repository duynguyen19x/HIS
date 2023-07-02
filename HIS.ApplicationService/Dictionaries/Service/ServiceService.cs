using AutoMapper;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ExecutionRoom;
using HIS.Dtos.Dictionaries.Room;
using HIS.Dtos.Dictionaries.Service;
using HIS.Dtos.Dictionaries.ServicePricePolicy;
using HIS.EntityFrameworkCore.DbContexts;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Models.Commons;
using HIS.Utilities.Enums;
using HIS.Utilities.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

                    var sServicePricePolicys = _mapper.Map<List<SServicePricePolicy>>(input.ServicePricePolicies);
                    if (sServicePricePolicys != null)
                    {
                        foreach (var sServicePricePolicy in sServicePricePolicys)
                        {
                            sServicePricePolicy.Id = Guid.NewGuid();
                            sServicePricePolicy.CreatedDate = timeNow;
                            sServicePricePolicy.ServiceId = data.Id;

                            sServicePricePolicy.PatientType = null;
                            sServicePricePolicy.SService = null;
                        }

                        _dbContext.SServicePricePolicies.AddRange(sServicePricePolicys);
                    }

                    if (!GuidHelper.IsNullOrEmpty(input.ServiceGroupHeInId))
                    {
                        var serviceGroupHeInTypes = new List<string>()
                        {
                            ((int)ServiceGroupHeInTypes.LaboratoryTesting).ToString(),
                            ((int)ServiceGroupHeInTypes.DiagnosticImaging).ToString(),
                            ((int)ServiceGroupHeInTypes.FunctionalEvaluation).ToString(),
                        };

                        var serviceGroupHeIn = _dbContext.SServiceGroupHeIns.FirstOrDefault(f => f.Id == input.ServiceGroupHeInId);
                        if (serviceGroupHeIn != null && serviceGroupHeInTypes.Any(a => a == serviceGroupHeIn.Code) && input.ExecutionRooms != null)
                        {
                            var executionRoomDtos = input.ExecutionRooms.Where(w => w.IsCheck).ToList();
                            var executionRooms = _mapper.Map<List<SExecutionRoom>>(executionRoomDtos);
                            foreach (var executionRoom in executionRooms)
                            {
                                executionRoom.Id = Guid.NewGuid();
                                executionRoom.ServiceId = data.Id;
                            }

                            _dbContext.SExecutionRooms.AddRange(executionRooms);
                        }
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
                    _dbContext.SServicePricePolicies.RemoveRange(sServicePricePolicyOlds);
                    _dbContext.SExecutionRooms.RemoveRange(sExecutionRoomOlds);

                    var sService = _dbContext.SServices.FirstOrDefault(f => f.Id == input.Id);
                    if (sService != null)
                    {
                        _mapper.Map(input, sService);

                        var sServicePricePolicys = _mapper.Map<List<SServicePricePolicy>>(input.ServicePricePolicies);
                        if (sServicePricePolicys != null)
                        {
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
                            var serviceGroupHeInTypes = new List<string>()
                            {
                                ((int)ServiceGroupHeInTypes.LaboratoryTesting).ToString(),
                                ((int)ServiceGroupHeInTypes.DiagnosticImaging).ToString(),
                                ((int)ServiceGroupHeInTypes.FunctionalEvaluation).ToString(),
                            };

                            var serviceGroupHeIn = _dbContext.SServiceGroupHeIns.FirstOrDefault(f => f.Id == input.ServiceGroupHeInId);
                            if (serviceGroupHeIn != null && serviceGroupHeInTypes.Any(a => a == serviceGroupHeIn.Code))
                            {
                                var executionRoomDtos = input.ExecutionRooms.Where(w => w.IsCheck).ToList();
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
                }
                finally
                {
                    transaction.Dispose();
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

                                 join r1 in _dbContext.SServiceUnits on r.ServiceUnitId equals r1.Id
                                 join r2 in _dbContext.SServiceGroups on r.ServiceGroupId equals r2.Id
                                 join r3 in _dbContext.SServiceGroupHeIns on r.ServiceGroupHeInId equals r3.Id

                                 where (input.InactiveFilter == null || r.Inactive == !input.InactiveFilter)
                                 where (r.IsDelete == false || r.IsDelete == (bool?)default)
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
                                     ServiceUnitId = r.ServiceUnitId,
                                     //ServiceTypeId = r.ServiceTypeId,
                                     SurgicalProcedureTypeId = r.SurgicalProcedureTypeId,

                                     ServiceUnitCode = r1.Code,
                                     ServiceUnitName = r1.Name,
                                     ServiceGroupCode = r2.Code,
                                     ServiceGroupName = r2.Name,
                                     ServiceGroupHeInCode = r3.Name,
                                     ServiceGroupHeInName = r3.Name,
                                 }).OrderBy(o => o.Code).ToList();

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
                var rommTypes = new List<string>()
                {
                    ((int)RoomTypes.LaboratoryTesting).ToString(),
                    ((int)RoomTypes.DiagnosticImaging).ToString(),
                };

                if (!GuidHelper.IsNullOrEmpty(id))
                {
                    var service = _dbContext.SServices.FirstOrDefault(s => s.Id == id && (s.IsDelete == null || s.IsDelete == false));
                    var sServicePricePolicys = (from ser in _dbContext.SServicePricePolicies
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
                                                    PatientTypeCode = pa.Code,
                                                    PatientTypeName = pa.Name,
                                                    IsHeIn = pa.Code == PatientTypes.BHYT ? true : false,
                                                }).OrderBy(s => s.PatientTypeCode).ToList();

                    var sExecutionRooms = (from room in _dbContext.SRooms
                                           join roomType in _dbContext.SRoomTypes on room.RoomTypeId equals roomType.Id
                                           join exec in _dbContext.SExecutionRooms.Where(w => w.ServiceId == id) on room.Id equals exec.RoomId into SExecutionRooms
                                           from s in SExecutionRooms.DefaultIfEmpty()
                                           where rommTypes.Contains(roomType.Code)
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

                    serviceDto = _mapper.Map<SServiceDto>(service);
                    serviceDto.ServicePricePolicies = sServicePricePolicys;
                    serviceDto.ExecutionRooms = sExecutionRooms;
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
                                           join roomType in _dbContext.SRoomTypes on room.RoomTypeId equals roomType.Id
                                           where room.Inactive == false
                                                && rommTypes.Contains(roomType.Code)
                                           select new SExecutionRoomDto()
                                           {
                                               RoomId = room.Id,
                                               RoomCode = room.Code,
                                               RoomName = room.Name,
                                           }).OrderBy(s => s.RoomCode).ToList();

                    serviceDto.ServicePricePolicies = sServicePricePolicys;
                    serviceDto.ExecutionRooms = sExecutionRooms;
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
    }
}
