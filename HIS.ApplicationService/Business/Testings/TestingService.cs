using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Linq;
using HIS.Dtos.Business.ServiceRequests;
using HIS.EntityFrameworkCore;
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

            return await Task.FromResult(pagedResults);
        }
    }
}
