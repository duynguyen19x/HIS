﻿using HIS.Core.Services.Dto;
using HIS.ApplicationService.Dictionaries.Hospital;
using HIS.Dtos.Dictionaries.Hospital;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private readonly IHospitalService _hospitalService;

        public HospitalController(IHospitalService hospitalService)
        {
            _hospitalService = hospitalService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<HospitalDto>> GetAll([FromQuery] GetAllHospitalInput input)
        {
            return await _hospitalService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<HospitalDto>> GetById(Guid id)
        {
            return await _hospitalService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<HospitalDto>> CreateOrEdit(HospitalDto input)
        {
            return await _hospitalService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<HospitalDto>> Delete(Guid id)
        {
            return await _hospitalService.Delete(id);
        }
    }
}
