using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Linq;
using HIS.Dtos.Business.ServiceRequestDatas;
using HIS.Dtos.Business.ServiceRequests;
using HIS.Dtos.Business.ServiceResultDatas;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Business;
using HIS.Utilities.Enums;
using HIS.Utilities.Helpers;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Business.Testings
{
    public class TestingService : BaseAppService, ITestingService
    {
        public TestingService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
           : base(dbContext, mapper) { }

        public async Task<PagedResultDto<ServiceRequestDto>> GetAll(GetAllServiceRequestInputDto input)
        {
            var pagedResults = new PagedResultDto<ServiceRequestDto>();

            //var serviceRequests = (from serviceRequest in Context.ServiceRequests

            //                       select new ServiceRequestDto()
            //                       {
            //                           ServiceRequestCode = serviceRequest.ServiceRequestCode,
            //                           ServiceRequestDate = serviceRequest.ServiceRequestDate,
            //                           ServiceRequestUseDate = serviceRequest.ServiceRequestUseDate,
            //                           Barcode = serviceRequest.Barcode,
            //                           NumOrder = serviceRequest.NumOrder,
            //                           IsPriority = serviceRequest.IsPriority,
            //                           IcdCode = serviceRequest.IcdCode,
            //                           IcdName = serviceRequest.IcdName,
            //                           IcdSubCode = serviceRequest.IcdSubCode,
            //                           IcdText = serviceRequest.IcdText,
            //                           ServiceRequestTypeId = serviceRequest.ServiceRequestTypeId,
            //                           ServiceRequestStatusId = serviceRequest.ServiceRequestStatusId,
            //                           PatientRecordId = serviceRequest.PatientRecordId,
            //                           MedicalRecordId = serviceRequest.MedicalRecordId,
            //                           TreatmentId = serviceRequest.TreatmentId,
            //                           DepartmentId = serviceRequest.DepartmentId,
            //                           RoomId = serviceRequest.RoomId,
            //                           UserId = serviceRequest.UserId,
            //                           ExecuteDepartmentId = serviceRequest.ExecuteDepartmentId,
            //                           ExecuteRoomId = serviceRequest.ExecuteRoomId,
            //                           ExecuteUserId = serviceRequest.ExecuteUserId,
            //                       }).ToList();

            var serviceRequests = Context.ServiceRequestViews
                .WhereIf(input.ServiceRequestStatusIdFilter != null, w => w.ServiceRequestStatusId == input.ServiceRequestStatusIdFilter)
                .WhereIf(!GuidHelper.IsNullOrEmpty(input.ExecuteRoomIdFilter), w => w.ExecuteRoomId == input.ExecuteRoomIdFilter)
                .WhereIf(!GuidHelper.IsNullOrEmpty(input.ExecuteDepartmentIdFilter), w => w.ExecuteDepartmentId == input.ExecuteDepartmentIdFilter)
                .WhereIf(!DatetimeHelper.IsNullOrEmpty(input.ServiceRequestDateFromFilter), w => w.ServiceRequestDate >= input.ServiceRequestDateFromFilter)
                .WhereIf(!DatetimeHelper.IsNullOrEmpty(input.ServiceRequestDateToFilter), w => w.ServiceRequestDate <= input.ServiceRequestDateToFilter)
                .WhereIf(!DatetimeHelper.IsNullOrEmpty(input.ServiceRequestUseDateFromFilter), w => w.ServiceRequestUseDate >= input.ServiceRequestUseDateFromFilter)
                .WhereIf(!DatetimeHelper.IsNullOrEmpty(input.ServiceRequestUseDateToFilter), w => w.ServiceRequestUseDate <= input.ServiceRequestUseDateToFilter)
                .ToList();

            pagedResults.Result = ObjectMapper.Map<List<ServiceRequestDto>>(serviceRequests);

            return await Task.FromResult(pagedResults);
        }

        public async Task<ListResultDto<ServiceRequestDataDto>> GetServiceRequestDataByServiceRequestId(Guid serviceRequestId, GenderTypes genderType, bool isDetail = true)
        {
            var listResultDto = new ListResultDto<ServiceRequestDataDto>();

            listResultDto.Result = (from serviceRequest in Context.ServiceRequestDatas
                                    join service in Context.Services on serviceRequest.ServiceId equals service.Id

                                    where serviceRequest.ServiceRequestId == serviceRequestId

                                    select new ServiceRequestDataDto()
                                    {
                                        Id = serviceRequest.Id,
                                        ServiceRequestId = serviceRequest.ServiceRequestId,
                                        InsuranceId = serviceRequest.InsuranceId,
                                        ServiceId = serviceRequest.ServiceId,
                                        StartTime = serviceRequest.StartTime,
                                        EndTime = serviceRequest.EndTime,
                                        Price = serviceRequest.Price,
                                        Quantity = serviceRequest.Quantity,
                                        Amount = serviceRequest.Amount,
                                        DiscountAmount = serviceRequest.DiscountAmount,

                                        PatientTypeId = serviceRequest.PatientTypeId,
                                        Description = serviceRequest.Description,

                                        ServiceCode = service.Code,
                                        ServiceName = service.Name,
                                    }).ToList();

            if (isDetail)
            {
                var serviceRequestDataIds = listResultDto.Result.Select(s => (Guid?)s.Id).ToList();
                var serviceResultDatas = (await GetServiceResultDataByServiceRequestDataIds(serviceRequestDataIds, genderType)).Result;

                if (serviceResultDatas != null)
                {
                    foreach (var result in listResultDto.Result)
                    {
                        result.ServiceResultDatas = serviceResultDatas.Where(w => w.ServiceRequestDataId == result.Id).ToList();
                    }
                }
            }

            return await Task.FromResult(listResultDto);
        }

        public async Task<ListResultDto<ServiceResultDataDto>> GetServiceResultDataByServiceRequestDataId(Guid serviceRequestDataId, GenderTypes genderType)
        {
            var listResultDto = new ListResultDto<ServiceResultDataDto>();

            listResultDto.Result = (from serviceResultData in Context.ServiceResultDatas
                                    join service in Context.Services on serviceResultData.ServiceId equals service.Id
                                    join serviceResultIndice in Context.ServiceResultIndices on serviceResultData.ServiceResultIndiceId equals serviceResultIndice.Id

                                    where serviceResultData.ServiceRequestDataId == serviceRequestDataId

                                    select new ServiceResultDataDto()
                                    {
                                        Id = serviceResultIndice.Id,
                                        ServiceResultIndiceId = serviceResultData.ServiceResultIndiceId,
                                        ServiceRequestDataId = serviceResultData.ServiceRequestDataId,
                                        ServiceId = serviceResultData.ServiceId,
                                        Result = serviceResultData.Result,
                                        NormalRange = !string.IsNullOrEmpty(serviceResultIndice.Normal) ? serviceResultIndice.Normal : (genderType == GenderTypes.Female ? string.Format("{0} - {1} {2}", serviceResultIndice.FemaleFrom, serviceResultIndice.FemaleTo, serviceResultIndice.Unit) : string.Format("{0} - {1} {2}", serviceResultIndice.MaleFrom, serviceResultIndice.MaleTo, serviceResultIndice.Unit)),
                                        //TestingMachine = serviceResultData.TestingMachine,
                                        ResultType = serviceResultData.ResultType,
                                        IsNumber = !string.IsNullOrEmpty(serviceResultIndice.Normal) ? true : false,
                                        ServiceCode = service.Code,
                                        ServiceName = service.Name,
                                        ServiceResultIndiceCode = serviceResultIndice.Code,
                                        ServiceResultIndiceName = serviceResultIndice.Name,
                                        ServiceResultIndiceUnit = serviceResultIndice.Unit,
                                    }).ToList();

            return await Task.FromResult(listResultDto);
        }

        public async Task<ListResultDto<ServiceResultDataDto>> GetServiceResultDataByServiceRequestDataIds(List<Guid?> serviceRequestDataIds, GenderTypes genderType)
        {
            var listResultDto = new ListResultDto<ServiceResultDataDto>();

            listResultDto.Result = (from serviceResultData in Context.ServiceResultDatas
                                    join service in Context.Services on serviceResultData.ServiceId equals service.Id
                                    join serviceResultIndice in Context.ServiceResultIndices on serviceResultData.ServiceResultIndiceId equals serviceResultIndice.Id

                                    where serviceRequestDataIds.Contains(serviceResultData.ServiceRequestDataId)

                                    select new ServiceResultDataDto()
                                    {
                                        Id = serviceResultIndice.Id,
                                        ServiceResultIndiceId = serviceResultData.ServiceResultIndiceId,
                                        ServiceRequestDataId = serviceResultData.ServiceRequestDataId,
                                        ServiceId = serviceResultData.ServiceId,
                                        Result = serviceResultData.Result,
                                        NormalRange = !string.IsNullOrEmpty(serviceResultIndice.Normal) ? serviceResultIndice.Normal : (genderType == GenderTypes.Female ? string.Format("{0} - {1} {2}", serviceResultIndice.FemaleFrom, serviceResultIndice.FemaleTo, serviceResultIndice.Unit) : string.Format("{0} - {1} {2}", serviceResultIndice.MaleFrom, serviceResultIndice.MaleTo, serviceResultIndice.Unit)),
                                        //TestingMachine = serviceResultData.TestingMachine,
                                        ResultType = serviceResultData.ResultType,
                                        IsNumber = !string.IsNullOrEmpty(serviceResultIndice.Normal) ? true : false,
                                        ServiceCode = service.Code,
                                        ServiceName = service.Name,
                                        ServiceResultIndiceCode = serviceResultIndice.Code,
                                        ServiceResultIndiceName = serviceResultIndice.Name,
                                        ServiceResultIndiceUnit = serviceResultIndice.Unit,
                                    }).ToList();

            return await Task.FromResult(listResultDto);
        }

        public async Task<ListResultDto<ServiceResultDataDto>> GetServiceResultDataByServiceRequestId(Guid serviceRequestId, GenderTypes genderType)
        {
            var listResultDto = new ListResultDto<ServiceResultDataDto>();

            listResultDto.Result = (from serviceRequestData in Context.ServiceRequestDatas
                                    join serviceResultData in Context.ServiceResultDatas on serviceRequestData.Id equals serviceResultData.ServiceRequestDataId
                                    join service in Context.Services on serviceResultData.ServiceId equals service.Id
                                    join serviceResultIndice in Context.ServiceResultIndices on serviceResultData.ServiceResultIndiceId equals serviceResultIndice.Id

                                    where serviceRequestData.ServiceRequestId == serviceRequestId

                                    select new ServiceResultDataDto()
                                    {
                                        Id = serviceResultIndice.Id,
                                        ServiceResultIndiceId = serviceResultData.ServiceResultIndiceId,
                                        ServiceRequestDataId = serviceResultData.ServiceRequestDataId,
                                        ServiceId = serviceResultData.ServiceId,
                                        Result = serviceResultData.Result,
                                        NormalRange = !string.IsNullOrEmpty(serviceResultIndice.Normal) ? serviceResultIndice.Normal : (genderType == GenderTypes.Female ? string.Format("{0} - {1} {2}", serviceResultIndice.FemaleFrom, serviceResultIndice.FemaleTo, serviceResultIndice.Unit) : string.Format("{0} - {1} {2}", serviceResultIndice.MaleFrom, serviceResultIndice.MaleTo, serviceResultIndice.Unit)),
                                        //TestingMachine = serviceResultData.TestingMachine,
                                        ResultType = serviceResultData.ResultType,
                                        IsNumber = string.IsNullOrEmpty(serviceResultIndice.Normal) ? true : false,
                                        ServiceCode = service.Code,
                                        ServiceName = service.Name,
                                        ServiceResultIndiceCode = serviceResultIndice.Code,
                                        ServiceResultIndiceName = serviceResultIndice.Name,
                                        ServiceResultIndiceUnit = serviceResultIndice.Unit,
                                    }).ToList();

            return await Task.FromResult(listResultDto);
        }
    }
}
