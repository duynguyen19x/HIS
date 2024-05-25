using HIS.Dtos.Dictionaries.ExecutionRoom;
using HIS.Dtos.Dictionaries.ServiceResultIndex;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using HIS.EntityFrameworkCore.Entities;
using HIS.Utilities.Helpers;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Globalization;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Extensions;
using HIS.Core.Domain.Repositories;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.Core.Application.Services;
using HIS.ApplicationService.Dictionary.Services.Dto;
using Microsoft.EntityFrameworkCore;
using System.Transactions;
using HIS.ApplicationService.Dictionary.ServicePricePolicies.Dto;

namespace HIS.ApplicationService.Dictionary.Services
{
    public class ServiceAppService : BaseAppService, IServiceAppService
    {
        private readonly IBulkRepository<Service, Guid> _serviceRepository;
        private readonly IBulkRepository<ServiceGroup, Guid> _serviceGroupRepository;
        private readonly IBulkRepository<ServiceGroupHeIn, Guid> _serviceGroupHeinRepository;
        private readonly IBulkRepository<ServicePricePolicy, Guid> _servicePricePolicyRepository;
        private readonly IBulkRepository<ServiceResultIndice, Guid> _serviceResultIndiceRepository;
        private readonly IBulkRepository<PatientObjectType, int> _patientObjectTypeRepository;
        private readonly IBulkRepository<Room, Guid> _roomRepository;
        private readonly IBulkRepository<ExecutionRoom, Guid> _executionRoomRepository;
        private readonly IBulkRepository<SurgicalProcedureType, int> _surgicalProcedureTypeRepository;
        private readonly IBulkRepository<Unit, Guid> _unitRepository;

        public ServiceAppService(
            IBulkRepository<Service, Guid> serviceRepository,
            IBulkRepository<ServiceGroup, Guid> serviceGroupRepository,
            IBulkRepository<ServiceGroupHeIn, Guid> serviceGroupHeinRepository,
            IBulkRepository<ServicePricePolicy, Guid> servicePricePolicyRepository,
            IBulkRepository<ServiceResultIndice, Guid> serviceResultIndiceRepository,
            IBulkRepository<PatientObjectType, int> patientObjectTypeRepository,
            IBulkRepository<Room, Guid> roomRepository,
            IBulkRepository<ExecutionRoom, Guid> executionRoomRepository,
            IBulkRepository<SurgicalProcedureType, int> surgicalProcedureTypeRepository,
            IBulkRepository<Unit, Guid> unitRepository)
        {
            _serviceRepository = serviceRepository;
            _serviceGroupRepository = serviceGroupRepository;
            _serviceGroupHeinRepository = serviceGroupHeinRepository;
            _servicePricePolicyRepository = servicePricePolicyRepository;
            _serviceResultIndiceRepository = serviceResultIndiceRepository;
            _patientObjectTypeRepository = patientObjectTypeRepository;
            _roomRepository = roomRepository;
            _executionRoomRepository = executionRoomRepository;
            _surgicalProcedureTypeRepository = surgicalProcedureTypeRepository;
            _unitRepository = unitRepository;
        }

        public virtual async Task<PagedResultDto<ServiceDto>> GetAll(GetAllServiceInput input)
        {
            var result = new PagedResultDto<ServiceDto>();
            try
            {
                var filterService = _serviceRepository.GetAll()
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var filter = from r in filterService

                             join r1 in _unitRepository.GetAll() on r.UnitId equals r1.Id
                             join r2 in _serviceGroupRepository.GetAll() on r.ServiceGroupId equals r2.Id
                             join r3 in _serviceGroupHeinRepository.GetAll() on r.ServiceGroupHeInId equals r3.Id

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
                             };

                var paged = filter.ApplySortingAndPaging(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = paged.ToList();
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public virtual async Task<ResultDto<ServiceDto>> GetById(Guid id)
        {
            var result = new ResultDto<ServiceDto>();

            var serviceDto = new ServiceDto();

            try
            {
                var rommTypes = new List<int?>()
                {
                    (int?)HIS.Utilities.Enums.RoomTypes.LaboratoryTesting,
                    (int?)HIS.Utilities.Enums.RoomTypes.DiagnosticImaging,
                };

                if (!GuidHelper.IsNullOrEmpty(id))
                {
                    var service = _serviceRepository.FirstOrDefault(s => s.Id == id && s.IsDeleted == false);
                    var sServicePricePolicyDtos = (from ser in _servicePricePolicyRepository.GetAll()
                                                   join pa in _patientObjectTypeRepository.GetAll() on ser.PatientTypeId equals pa.Id
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
                                                       //ExecutionTimeString = ser.ExecutionTime == null ? null : ser.ExecutionTime.Value.ToString("dd/MM/yyyy"),
                                                       PatientTypeCode = pa.Code,
                                                       PatientTypeName = pa.Name,
                                                       IsHeIn = ser.PatientTypeId == (int)HIS.Core.Enums.DIPatientObjectType.BH ? true : false,
                                                   }).OrderBy(s => s.PatientTypeCode).ToList();

                    var sExecutionRoomDtos = (from room in _roomRepository.GetAll()
                                              join exec in _executionRoomRepository.GetAll().Where(w => w.ServiceId == id) on room.Id equals exec.RoomId into SExecutionRooms
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


                    var sServiceResultIndexs = _serviceResultIndiceRepository.GetAll().Where(w => w.ServiceId == id).ToList();
                    var sServiceResultIndexDtos = ObjectMapper.Map<IList<ServiceResultIndiceDto>>(sServiceResultIndexs);

                    serviceDto = ObjectMapper.Map<ServiceDto>(service);
                    serviceDto.SServicePricePolicies = sServicePricePolicyDtos;
                    serviceDto.SExecutionRooms = sExecutionRoomDtos;
                    serviceDto.SServiceResultIndices = sServiceResultIndexDtos;
                }
                else
                {
                    var sServicePricePolicys = (from r in _patientObjectTypeRepository.GetAll()
                                                where r.Inactive == false
                                                select new ServicePricePolicyDto()
                                                {
                                                    PatientTypeId = r.Id,
                                                    PatientTypeCode = r.Code,
                                                    PatientTypeName = r.Name,
                                                    IsHeIn = r.Id == (int)HIS.Core.Enums.DIPatientObjectType.BH ? true : false,
                                                }).OrderBy(o => o.PatientTypeCode).ToList();

                    var sExecutionRooms = (from room in _roomRepository.GetAll()
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

        public virtual async Task<ResultDto<ServiceDto>> CreateOrEdit(ServiceDto input)
        {
            var result = await ValidSave(input);
            if (!result.IsSucceeded)
                return result;

            if (Check.IsNullOrDefault(input.Id))
                return await Create(input);
            else
                return await Update(input);
        }

        public virtual async Task<ResultDto<ServiceDto>> Create(ServiceDto input)
        {
            var result = new ResultDto<ServiceDto>();

            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var timeNow = DateTime.Now;
                    input.Id = Guid.NewGuid();

                    var data = ObjectMapper.Map<EntityFrameworkCore.Entities.Categories.Service>(input);
                    data.CreatedDate = timeNow;
                    await _serviceRepository.InsertAsync(data);

                    if (input.SServicePricePolicies != null)
                    {
                        //foreach (var sServicePricePolicy in input.SServicePricePolicies)
                        //{
                        //    sServicePricePolicy.ExecutionTime = string.IsNullOrEmpty(sServicePricePolicy.ExecutionTimeString) ? null : DateTime.ParseExact(sServicePricePolicy.ExecutionTimeString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);
                        //}

                        var sServicePricePolicys = ObjectMapper.Map<List<ServicePricePolicy>>(input.SServicePricePolicies);
                        foreach (var sServicePricePolicy in sServicePricePolicys)
                        {
                            sServicePricePolicy.Id = Guid.NewGuid();
                            sServicePricePolicy.CreatedDate = timeNow;
                            sServicePricePolicy.ServiceId = data.Id;
                        }

                        await _servicePricePolicyRepository.BulkInsertAsync(sServicePricePolicys);
                        //Context.ServicePricePolicies.AddRange(sServicePricePolicys);
                    }

                    if (!GuidHelper.IsNullOrEmpty(input.ServiceGroupHeInId))
                    {
                        var serviceGroupHeInTypes = new List<string>() { "XN", "CDHA", "TDCN", };

                        var serviceGroupHeIn = _serviceGroupHeinRepository.FirstOrDefault(f => f.Id == input.ServiceGroupHeInId);
                        if (serviceGroupHeIn != null && serviceGroupHeInTypes.Any(a => a == serviceGroupHeIn.Code) && input.SExecutionRooms != null)
                        {
                            var executionRoomDtos = input.SExecutionRooms.Where(w => w.IsCheck).ToList();
                            var executionRooms = ObjectMapper.Map<List<ExecutionRoom>>(executionRoomDtos);
                            foreach (var executionRoom in executionRooms)
                            {
                                executionRoom.Id = Guid.NewGuid();
                                executionRoom.ServiceId = data.Id;
                            }

                            await _executionRoomRepository.BulkInsertAsync(executionRooms);
                            //Context.ExecutionRooms.AddRange(executionRooms);
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

                        await _serviceResultIndiceRepository.BulkInsertAsync(serviceResultIndices);
                        //Context.ServiceResultIndices.AddRange(serviceResultIndices);
                    }

                    await unitOfWork.CompleteAsync();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }

            return result;
        }

        public virtual async Task<ResultDto<ServiceDto>> Update(ServiceDto input)
        {
            var result = new ResultDto<ServiceDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var timeNow = DateTime.Now;

                    var sServicePricePolicyOlds = await _servicePricePolicyRepository.GetAllListAsync(w => w.ServiceId == input.Id); // Context.ServicePricePolicies.Where(w => w.ServiceId == input.Id).ToList();
                    if (Check.IsNotNullOrEmpty(sServicePricePolicyOlds))
                        await _servicePricePolicyRepository.BulkDeleteAsync(sServicePricePolicyOlds);

                    var sExecutionRoomOlds = await _executionRoomRepository.GetAllListAsync(w => w.ServiceId == input.Id); // Context.ExecutionRooms.Where(w => w.ServiceId == input.Id).ToList();
                    if (Check.IsNotNullOrEmpty(sExecutionRoomOlds))
                        await _executionRoomRepository.BulkDeleteAsync(sExecutionRoomOlds);

                    var sServiceResultIndexOlds = await _serviceResultIndiceRepository.GetAllListAsync(w => w.ServiceId == input.Id); // Context.ServiceResultIndices.Where(w => w.ServiceId == input.Id).ToList();
                    if (Check.IsNotNullOrEmpty(sServiceResultIndexOlds))
                        await _serviceResultIndiceRepository.BulkDeleteAsync(sServiceResultIndexOlds);
                    //Context.ServicePricePolicies.RemoveRange(sServicePricePolicyOlds);
                    //Context.ExecutionRooms.RemoveRange(sExecutionRoomOlds);
                    //Context.ServiceResultIndices.RemoveRange(sServiceResultIndexOlds);

                    var sService = _serviceRepository.FirstOrDefault(f => f.Id == input.Id);
                    if (sService != null)
                    {
                        ObjectMapper.Map(input, sService);

                        if (input.SServicePricePolicies != null)
                        {
                            //foreach (var sServicePricePolicy in input.SServicePricePolicies)
                            //{
                            //    sServicePricePolicy.ExecutionTime = string.IsNullOrEmpty(sServicePricePolicy.ExecutionTimeString) ? null : DateTime.ParseExact(sServicePricePolicy.ExecutionTimeString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);
                            //}

                            var sServicePricePolicys = ObjectMapper.Map<List<EntityFrameworkCore.Entities.Categories.Services.ServicePricePolicy>>(input.SServicePricePolicies);
                            foreach (var sServicePricePolicy in sServicePricePolicys)
                            {
                                if (Check.IsNullOrDefault(sServicePricePolicy.Id))
                                    sServicePricePolicy.Id = Guid.NewGuid();
                                sServicePricePolicy.CreatedDate = timeNow;
                                sServicePricePolicy.ModifiedDate = timeNow;
                                sServicePricePolicy.ServiceId = sService.Id;
                            }

                            await _servicePricePolicyRepository.BulkInsertAsync(sServicePricePolicys);
                        }

                        if (!GuidHelper.IsNullOrEmpty(input.ServiceGroupHeInId))
                        {
                            var serviceGroupHeInTypes = new List<string>() { "XN", "CDHA", "TDCN", };

                            var serviceGroupHeIn = _serviceGroupHeinRepository.FirstOrDefault(f => f.Id == input.ServiceGroupHeInId);
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

                                await _executionRoomRepository.BulkInsertAsync(executionRooms);
                                //Context.ExecutionRooms.AddRange(executionRooms);
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

                            await _serviceResultIndiceRepository.BulkInsertAsync(serviceResultIndices);
                            //Context.ServiceResultIndices.AddRange(serviceResultIndices);
                        }
                    }

                    await unitOfWork.CompleteAsync();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<ServiceDto>> Delete(Guid id)
        {
            var result = new ResultDto<ServiceDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _serviceRepository.GetAsync(id); // Context.Services.SingleOrDefault(x => x.Id == id);

                    await _serviceRepository.DeleteAsync(entity);

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

        public virtual async Task<ResultDto<bool>> Import(IList<ServiceImportExcelDto> input)
        {
            var result = new ResultDto<bool>();

            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var sServiceUnits = _unitRepository.GetAllList();
                    var sServiceGroupHeIns = _serviceGroupHeinRepository.GetAllList();
                    var sServiceGroups = _serviceGroupRepository.GetAllList(); // Context.ServiceGroups.ToList();
                    var sSurgicalProcedureTypes = _surgicalProcedureTypeRepository.GetAllList(); // Context.SurgicalProcedureTypes.ToList();
                    var sPatientTypes = _patientObjectTypeRepository.GetAllList(); // Context.PatientTypes.ToList();
                    var sRooms = _roomRepository.GetAllList(); // Context.Rooms.ToList();

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
                                PatientTypeCode = HIS.Core.Enums.DIPatientObjectType.BH.ToString(),
                                PaymentRate = serviceImport.PaymentRate,
                                CeilingPrice = serviceImport.CeilingPrice,
                                ExecutionTime = string.IsNullOrEmpty( serviceImport.ExecutionTimeString) ? null : DateTime.ParseExact(serviceImport.ExecutionTimeString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None),
                            },
                            new ServicePricePolicyDto()
                            {
                                Id = Guid.NewGuid(),
                                ServiceId = serviceDto.Id,
                                OldUnitPrice = serviceImport.ServicePrice,
                                PatientTypeCode = HIS.Core.Enums.DIPatientObjectType.DV.ToString(),
                                ExecutionTime = string.IsNullOrEmpty( serviceImport.ExecutionTimeString) ? null : DateTime.ParseExact(serviceImport.ExecutionTimeString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None),
                            },
                            new ServicePricePolicyDto()
                            {
                                Id = Guid.NewGuid(),
                                ServiceId = serviceDto.Id,
                                OldUnitPrice = serviceImport.PeoplePrice,
                                PatientTypeCode = HIS.Core.Enums.DIPatientObjectType.VP.ToString(),
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

                    await _serviceRepository.BulkInsertAsync(Services); //Context.Services.AddRange(Services);
                    await _servicePricePolicyRepository.BulkInsertAsync(servicePricePolicie); //Context.ServicePricePolicies.AddRange(servicePricePolicie);
                    await _executionRoomRepository.BulkInsertAsync(executionRooms); //Context.ExecutionRooms.AddRange(executionRooms);

                    await unitOfWork.CompleteAsync();
                    result.Success(true);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }

            return result;
        }

        public virtual async Task<ResultDto<bool>> ImportServiceResultIndices(IList<ServiceResultIndiceDto> sServiceResultIndexs)
        {
            var result = new ResultDto<bool>();

            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var services = await _serviceRepository.GetAllListAsync(); // Context.Services.ToList();

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

                    await _serviceResultIndiceRepository.BulkInsertAsync(serviceResultIndexs); //Context.ServiceResultIndices.AddRange(serviceResultIndexs);

                    await unitOfWork.CompleteAsync();
                    result.Success(true);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }

            return result;
        }

        private async Task<ResultDto<ServiceDto>> ValidSave(ServiceDto input)
        {
            var result = new ResultDto<ServiceDto>();

            try
            {
                List<string> errs = new List<string>();

                var Services = _serviceRepository.FirstOrDefault(w => w.Code == input.Code && w.Id != input.Id);
                if (Services != null)
                {
                    errs.Add(string.Format("Mã dịch vụ [{0}] đã tồn tại trên hệ thống!", input.Code));
                }

                var sServiceHein = _serviceRepository.FirstOrDefault(w => w.Code == input.HeInCode && w.Id != input.Id);
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
