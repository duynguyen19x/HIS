﻿using HIS.ApplicationService.Business.Patient;
using HIS.ApplicationService.Business.Pharmaceuticals.ImpMests;
using HIS.Dtos.Business.DImMest;
using HIS.Dtos.Business.Patient;
using HIS.Dtos.Business.Treatment;
using HIS.Dtos.Commons;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Business.Pharmaceuticals
{
    [Route("api/[controller]")]
    [ApiController]
    public class DImpMestController : ControllerBase
    {
        private readonly IDImpMestService _dImpMestService;

        public DImpMestController(IDImpMestService dImpMestService)
        {
            _dImpMestService = dImpMestService;
        }

        [HttpGet("GetByStock")]
        public async Task<ApiResultList<DImpMestDto>> GetByStock(Guid stockId, string fromDate, string toDate)
        {
            return await _dImpMestService.GetByStock(stockId, fromDate, toDate);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<DImpMestDto>> CreateOrEdit(DImpMestDto input)
        {
            return await _dImpMestService.CreateOrEdit(input);
        }
    }
}
