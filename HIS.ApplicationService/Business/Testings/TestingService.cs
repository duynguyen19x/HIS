using HIS.Dtos.Business.ServiceRequestDatas;
using HIS.Dtos.Business.ServiceRequests;
using HIS.Dtos.Business.ServiceResultDatas;
using HIS.Utilities.Enums;
using HIS.Utilities.Helpers;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Extensions;
using HIS.Core.Application.Services;
using HIS.EntityFrameworkCore.Views;
using HIS.Core.Domain.Repositories;
using HIS.EntityFrameworkCore.Entities.Business;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using System.Transactions;

namespace HIS.ApplicationService.Business.Testings
{
    public class TestingService : BaseAppService, ITestingService
    {
        private readonly IRepository<ServiceRequest, Guid> _serviceRequestRepository;
        private readonly IRepository<ServiceRequestView, Guid> _serviceRequestViewRepository;
        private readonly IRepository<ServiceRequestData, Guid> _serviceRequestDataRepository;
        private readonly IRepository<ServiceResultData, Guid> _serviceResultDataRepository;
        private readonly IRepository<ServiceResultIndice, Guid> _serviceResultIndiceRepository;
        private readonly IRepository<Service, Guid> _serviceRepository;

        public TestingService(
            IRepository<ServiceRequest, Guid> serviceRequestRepository,
            IRepository<ServiceRequestView, Guid> serviceRequestViewRepository,
            IRepository<ServiceRequestData, Guid> serviceRequestDataRepository,
            IRepository<ServiceResultData, Guid> serviceResultDataRepository,
            IRepository<ServiceResultIndice, Guid> serviceResultIndiceRepository,
            IRepository<Service, Guid> serviceRepository) 
        {
            _serviceRequestRepository = serviceRequestRepository;
            _serviceRequestViewRepository = serviceRequestViewRepository;
            _serviceRequestDataRepository = serviceRequestDataRepository;
            _serviceResultDataRepository = serviceResultDataRepository;
            _serviceResultIndiceRepository = serviceResultIndiceRepository;
            _serviceRepository = serviceRepository;
        }

        public async Task<PagedResultDto<ServiceRequestDto>> GetAll(GetAllServiceRequestInputDto input)
        {
            var pagedResults = new PagedResultDto<ServiceRequestDto>();

            try
            {
                var serviceRequests = _serviceRequestViewRepository.GetAll()
                    .WhereIf(input.StatusFilter != null, w => w.Status == input.StatusFilter)
                    .WhereIf(!GuidHelper.IsNullOrEmpty(input.ExecuteRoomIdFilter), w => w.ExecuteRoomId == input.ExecuteRoomIdFilter)
                    .WhereIf(!GuidHelper.IsNullOrEmpty(input.ExecuteDepartmentIdFilter), w => w.ExecuteDepartmentId == input.ExecuteDepartmentIdFilter)
                    .WhereIf(input.RequestTimeFromFilter != null && input.RequestTimeFromFilter > 0, w => w.RequestTime >= input.RequestTimeFromFilter)
                    .WhereIf(input.RequestTimeToFilter != null && input.RequestTimeToFilter > 0, w => w.RequestTime <= input.RequestTimeToFilter)
                    .WhereIf(input.UseTimeFromFilter != null && input.UseTimeFromFilter > 0, w => w.UseTime >= input.UseTimeFromFilter)
                    .WhereIf(input.UseTimeToFilter != null && input.UseTimeToFilter > 0, w => w.UseTime <= input.UseTimeToFilter)
                    .WhereIf(input.StartTimeFromFilter != null && input.StartTimeFromFilter > 0, w => w.StartTime >= input.StartTimeFromFilter)
                    .WhereIf(input.StartTimeToFilter != null && input.StartTimeToFilter > 0, w => w.StartTime <= input.StartTimeToFilter)
                    .WhereIf(input.EndTimeFromFilter != null && input.EndTimeFromFilter > 0, w => w.EndTime >= input.EndTimeFromFilter)
                    .WhereIf(input.EndTimeToFilter != null && input.EndTimeToFilter > 0, w => w.EndTime <= input.EndTimeToFilter)
                    .OrderBy(o => o.Status).ThenBy(t => t.UseTime).ToList();

                pagedResults.Result = ObjectMapper.Map<List<ServiceRequestDto>>(serviceRequests);
            }
            catch (Exception ex)
            {
                pagedResults.IsSucceeded = false;
                pagedResults.Message = ex.Message;
            }

            return await Task.FromResult(pagedResults);
        }

        public async Task<ListResultDto<ServiceRequestDataDto>> GetServiceRequestDataByServiceRequestId(Guid serviceRequestId, GenderTypes genderType, bool isDetail = true)
        {
            var listResultDto = new ListResultDto<ServiceRequestDataDto>();

            listResultDto.Result = (from serviceRequest in _serviceRequestDataRepository.GetAll()
                                    join service in _serviceRepository.GetAll() on serviceRequest.ServiceId equals service.Id

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

            listResultDto.Result = (from serviceResultData in _serviceResultDataRepository.GetAll() // Context.ServiceResultDatas
                                    join service in _serviceRepository.GetAll() on serviceResultData.ServiceId equals service.Id
                                    join serviceResultIndice in _serviceResultIndiceRepository.GetAll() on serviceResultData.ServiceResultIndiceId equals serviceResultIndice.Id

                                    where serviceResultData.ServiceRequestDataId == serviceRequestDataId

                                    select new ServiceResultDataDto()
                                    {
                                        Id = serviceResultIndice.Id,
                                        ServiceResultIndiceId = serviceResultData.ServiceResultIndiceId,
                                        ServiceRequestDataId = serviceResultData.ServiceRequestDataId,
                                        ServiceId = serviceResultData.ServiceId,
                                        Result = serviceResultData.Result,
                                        NormalRange = !string.IsNullOrEmpty(serviceResultIndice.Normal) ? serviceResultIndice.Normal : (genderType == GenderTypes.Female ? string.Format("{0} - {1} {2}", serviceResultIndice.FemaleFrom, serviceResultIndice.FemaleTo, serviceResultIndice.Unit) : string.Format("{0} - {1} {2}", serviceResultIndice.MaleFrom, serviceResultIndice.MaleTo, serviceResultIndice.Unit)),
                                        TestingMachine = serviceResultData.TestingMachine,
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

            listResultDto.Result = (from serviceResultData in _serviceResultDataRepository.GetAll() //Context.ServiceResultDatas
                                    join service in _serviceRepository.GetAll() on serviceResultData.ServiceId equals service.Id
                                    join serviceResultIndice in _serviceResultIndiceRepository.GetAll() on serviceResultData.ServiceResultIndiceId equals serviceResultIndice.Id

                                    where serviceRequestDataIds.Contains(serviceResultData.ServiceRequestDataId)

                                    select new ServiceResultDataDto()
                                    {
                                        Id = serviceResultIndice.Id,
                                        ServiceResultIndiceId = serviceResultData.ServiceResultIndiceId,
                                        ServiceRequestDataId = serviceResultData.ServiceRequestDataId,
                                        ServiceId = serviceResultData.ServiceId,
                                        Result = serviceResultData.Result,
                                        NormalRange = !string.IsNullOrEmpty(serviceResultIndice.Normal) ? serviceResultIndice.Normal : (genderType == GenderTypes.Female ? string.Format("{0} - {1} {2}", serviceResultIndice.FemaleFrom, serviceResultIndice.FemaleTo, serviceResultIndice.Unit) : string.Format("{0} - {1} {2}", serviceResultIndice.MaleFrom, serviceResultIndice.MaleTo, serviceResultIndice.Unit)),
                                        TestingMachine = serviceResultData.TestingMachine,
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

            listResultDto.Result = (from serviceRequestData in _serviceRequestDataRepository.GetAll() // Context.ServiceRequestDatas
                                    join serviceResultData in _serviceResultDataRepository.GetAll() on serviceRequestData.Id equals serviceResultData.ServiceRequestDataId
                                    join service in _serviceRepository.GetAll() on serviceResultData.ServiceId equals service.Id
                                    join serviceResultIndice in _serviceResultIndiceRepository.GetAll() on serviceResultData.ServiceResultIndiceId equals serviceResultIndice.Id

                                    where serviceRequestData.ServiceRequestId == serviceRequestId

                                    select new ServiceResultDataDto()
                                    {
                                        Id = serviceResultIndice.Id,
                                        ServiceResultIndiceId = serviceResultData.ServiceResultIndiceId,
                                        ServiceRequestDataId = serviceResultData.ServiceRequestDataId,
                                        ServiceRequestId = serviceRequestData.ServiceRequestId,
                                        ServiceId = serviceResultData.ServiceId,
                                        Result = serviceResultData.Result,
                                        NormalRange = !string.IsNullOrEmpty(serviceResultIndice.Normal) ? serviceResultIndice.Normal : (genderType == GenderTypes.Female ? string.Format("{0} - {1} {2}", serviceResultIndice.FemaleFrom, serviceResultIndice.FemaleTo, serviceResultIndice.Unit) : string.Format("{0} - {1} {2}", serviceResultIndice.MaleFrom, serviceResultIndice.MaleTo, serviceResultIndice.Unit)),
                                        TestingMachine = serviceResultData.TestingMachine,
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

        public async Task<ResultDto<ServiceRequestDto>> GetServiceRequestById(Guid id)
        {
            var result = new ResultDto<ServiceRequestDto>();

            var serviceRequestView = _serviceRequestViewRepository.FirstOrDefault(f => f.Id == id);
            result.Result = ObjectMapper.Map<ServiceRequestDto>(serviceRequestView);

            return await Task.FromResult(result);
        }

        public async Task<ResultDto<ServiceRequestDto>> UpdateTestingStatus(ServiceRequestDto input)
        {
            var result = new ResultDto<ServiceRequestDto>();

            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    switch (input.Status)
                    {
                        case ServiceRequestStatusTypes.NotExecuted:
                            break;
                        case ServiceRequestStatusTypes.Cancel:
                            break;
                        case ServiceRequestStatusTypes.AddNew:
                            break;
                        case ServiceRequestStatusTypes.Request:
                            {
                                var serviceRequest = _serviceRequestRepository.FirstOrDefault(f => f.Id == input.Id);
                                if (serviceRequest != null)
                                {
                                    // Cập nhật lại ngày Lấy mẫu bệnh phẩm, Bắt đầu xử lý, Trả kết quả = null
                                }
                            }
                            break;
                        case ServiceRequestStatusTypes.CollectingSpecimen:
                            {
                                var serviceRequest = _serviceRequestRepository.FirstOrDefault(f => f.Id == input.Id);
                                if (serviceRequest != null)
                                {
                                    // Cập nhật lại ngày Lấy mẫu bệnh phẩm, Bắt đầu xử lý, Trả kết quả
                                }
                            }
                            break;
                        case ServiceRequestStatusTypes.StartProcessing:
                            break;
                        case ServiceRequestStatusTypes.ProvideResults:
                            {
                                var serviceRequest = _serviceRequestRepository.FirstOrDefault(f => f.Id == input.Id);
                                if (serviceRequest != null)
                                {
                                    // Cập nhật lại ngày Lấy mẫu bệnh phẩm, Bắt đầu xử lý, Trả kết quả

                                    var serviceResultDatas = _serviceResultDataRepository.GetAll().Where(w => w.ServiceRequestId == input.Id).ToList();
                                    foreach (var resultData in serviceResultDatas)
                                    {
                                        var resultDataDto = input.ServiceResultDatas.FirstOrDefault(f => f.Id == resultData.Id);
                                        if (resultDataDto != null)
                                        {
                                            resultData.Result = resultDataDto.Result;
                                            resultData.TestingMachine = resultDataDto.TestingMachine;
                                        }
                                    }
                                }
                            }
                            break;
                        case ServiceRequestStatusTypes.Other:
                            break;
                        default:
                            break;
                    }

                    await unitOfWork.CompleteAsync();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }

            return await Task.FromResult(result);
        }
    }
}
