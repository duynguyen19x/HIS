﻿using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;
using HIS.ApplicationService.Dictionary.ServiceGroups.Dto;
using HIS.ApplicationService.Dictionary.ServiceGroups;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceGroupController : ControllerBase
    {
        private readonly IServiceGroupService _serviceGroupService;

        public ServiceGroupController(IServiceGroupService serviceGroupService)
        {
            _serviceGroupService = serviceGroupService;
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<ServiceGroupDto>> CreateOrEdit(ServiceGroupDto input)
        {
            return await _serviceGroupService.CreateOrEdit(input);
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<ServiceGroupDto>> GetAll([FromQuery] GetAllServiceGroupInput input)
        {
            return await _serviceGroupService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<ServiceGroupDto>> GetById(Guid id)
        {
            return await _serviceGroupService.GetById(id);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<ServiceGroupDto>> Delete(Guid id)
        {
            return await _serviceGroupService.Delete(id);
        }
    }
}
