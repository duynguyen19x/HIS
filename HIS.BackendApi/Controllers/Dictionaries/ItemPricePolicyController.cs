﻿using HIS.ApplicationService.Dictionaries.ItemPricePolicies;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ItemPricePolicies;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemPricePolicyController : ControllerBase
    {
        private readonly IItemPricePolicyService _itemPricePolicyService;

        public ItemPricePolicyController(IItemPricePolicyService itemPricePolicyService)
        {
            _itemPricePolicyService = itemPricePolicyService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<ItemPricePolicyDto>> GetAll([FromQuery] GetAllItemPricePolicyInput input)
        {
            return await _itemPricePolicyService.GetAll(input);
        }
    }
}
