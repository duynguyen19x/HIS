﻿using HIS.Dtos.Business.ItemStocks;
using HIS.Dtos.Dictionaries.Items;
using HIS.Utilities.Enums;
using HIS.Utilities.Helpers;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Extensions;
using HIS.Core.Application.Services;
using HIS.Core.Domain.Repositories;
using HIS.EntityFrameworkCore.Entities.Business;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities;

namespace HIS.ApplicationService.Business.Pharmaceuticals.ItemStocks
{
    public class ItemStockService : BaseAppService, IItemStockService
    {
        private readonly IRepository<Item, Guid> _itemRepository;
        private readonly IRepository<ItemStock, Guid> _itemStockRepository;
        private readonly IRepository<ItemType, Guid> _itemTypeRepository;
        private readonly IRepository<Room, Guid> _roomRepository;
        

        public ItemStockService(
            IRepository<Item, Guid> itemRepository,
            IRepository<ItemStock, Guid> itemStockRepository,
            IRepository<ItemType, Guid> itemTypeRepository,
            IRepository<Room, Guid> roomRepository)
        {
            _itemRepository = itemRepository;
            _itemStockRepository = itemStockRepository;
            _itemTypeRepository = itemTypeRepository;
            _roomRepository = roomRepository;
        } 

        public async Task<PagedResultDto<ItemStockDto>> GetAll(GetAllItemStockInput input)
        {
            var result = new PagedResultDto<ItemStockDto>();

            try
            {
                result.Result = (from mediStock in _itemStockRepository.GetAll()
                                 join stock in _roomRepository.GetAll() on mediStock.StockId equals stock.Id
                                 join Item in _itemRepository.GetAll() on mediStock.ItemId equals Item.Id
                                 select new ItemStockDto()
                                 {
                                     Id = mediStock.Id,
                                     ItemId = mediStock.ItemId,
                                     StockId = mediStock.StockId,
                                     AvailableQuantity = mediStock.AvailableQuantity,
                                     Quantity = mediStock.Quantity,

                                     ItemCode = Item.Code,
                                     ItemName = Item.Name,
                                     StockCode = stock.Code,
                                     StockName = stock.Name,
                                     CommodityType = Item.CommodityType
                                 })
                                 .WhereIf(!GuidHelper.IsNullOrEmpty(input.StockIdFilter), w => w.StockId == input.StockIdFilter)
                                 .WhereIf(!GuidHelper.IsNullOrEmpty(input.ItemIdFilter), w => w.ItemId == input.ItemIdFilter)
                                 .WhereIf(input.CommodityTypeFilter != null, w => w.CommodityType == input.CommodityTypeFilter)
                                 .OrderBy(o => o.StockCode).ToList();

                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSucceeded = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<PagedResultDto<ItemStockDto>> GetItemByStocks(Guid stockId)
        {
            var result = new PagedResultDto<ItemStockDto>();

            try
            {
                result.Result = (from dItemStock in _itemStockRepository.GetAll() // Context.ItemStocks
                                 join sItem in _itemRepository.GetAll() on dItemStock.ItemId equals sItem.Id

                                 where dItemStock.IsDeleted == false
                                    && dItemStock.AvailableQuantity > 0
                                    && dItemStock.StockId == stockId

                                 select new ItemStockDto()
                                 {
                                     Id = dItemStock.Id,
                                     ItemCode = sItem.Code,
                                     ItemName = sItem.Name,
                                     StockId = dItemStock.StockId,
                                     ItemId = dItemStock.ItemId,
                                     Quantity = dItemStock.Quantity,
                                     AvailableQuantity = dItemStock.AvailableQuantity,
                                     Item = ObjectMapper.Map<ItemDto>(sItem)
                                 }).ToList();
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public async Task<PagedResultDto<ItemStockDto>> GetItemStockByStocks(Guid stockId, CommodityTypes? commodityType, bool isGroup = false, bool isAvailableQuantity = false)
        {
            var result = new PagedResultDto<ItemStockDto>();

            try
            {
                var itemStockDtos = (from itemStock in _itemStockRepository.GetAll() // Context.ItemStocks
                                     join stock in _roomRepository.GetAll() on itemStock.StockId equals stock.Id
                                     join item in _itemRepository.GetAll() on itemStock.ItemId equals item.Id
                                     join itemType in _itemTypeRepository.GetAll() on item.ItemTypeId equals itemType.Id

                                     where itemStock.IsDeleted == false
                                        && itemStock.StockId == stockId

                                     select new ItemStockDto()
                                     {
                                         Id = itemStock.Id,
                                         ItemId = itemStock.ItemId,
                                         StockId = itemStock.StockId,
                                         AvailableQuantity = itemStock.AvailableQuantity,
                                         Quantity = itemStock.Quantity,

                                         ItemCode = itemType.Code,
                                         ItemName = itemType.Name,
                                         StockCode = stock.Code,
                                         StockName = stock.Name,

                                         // Phần Item
                                         CommodityType = item.CommodityType,
                                         Code = itemType.Code,
                                         HeInCode = itemType.HeInCode,
                                         Name = itemType.Name,
                                         ItemLineId = item.ItemLineId,
                                         ItemGroupId = item.ItemGroupId,
                                         ItemTypeId = item.ItemTypeId,
                                         UnitId = item.UnitId,
                                         Tutorial = item.Tutorial,
                                         CountryId = item.CountryId,
                                         ImpPrice = item.ImpPrice,
                                         ImpQuantity = item.ImpQuantity,
                                         ImpVatRate = item.ImpVatRate,
                                         ImpTaxRate = item.ImpTaxRate,
                                         Description = item.Description,
                                         ActiveSubstance = item.ActiveSubstance,
                                         Concentration = item.Concentration,
                                         Content = item.Content,
                                         Manufacturer = item.Manufacturer,
                                         PackagingSpecifications = item.PackagingSpecifications,
                                         Dosage = item.Dosage,
                                         Lot = item.Lot,
                                         DueDate = item.DueDate,
                                         TenderDecision = item.TenderDecision,
                                         TenderPackage = item.TenderPackage,
                                         TenderGroup = item.TenderGroup,
                                         TenderYear = item.TenderYear,
                                     })
                         .WhereIf(true, w => w.StockId == stockId)
                         .WhereIf(isAvailableQuantity, w => w.AvailableQuantity >= 0)
                         .WhereIf(!isAvailableQuantity, w => w.AvailableQuantity > 0)
                         .WhereIf(commodityType != null, w => w.CommodityType == commodityType)
                         .OrderBy(o => o.ItemCode).ThenBy(t => t.DueDate).ToList(); // ToList() tại đây vì trong GroupBy mà có FirstOrDefault Sql build ra rất dài

                if (isGroup)
                {
                    result.Result = itemStockDtos.GroupBy(g => new
                    {
                        g.ItemTypeId,
                        g.StockId,
                        g.StockCode,
                        g.StockName,
                        g.ItemCode,
                        g.ItemName,
                        g.Code,
                        g.Name,
                        g.HeInCode,
                        g.CommodityType,
                        g.ItemLineId,
                        g.ItemGroupId,
                        g.UnitId,
                        //g.CountryId,
                    }).Select(s => new ItemStockDto()
                    {
                        ItemTypeId = s.Key.ItemTypeId,
                        StockId = s.Key.StockId,
                        StockCode = s.Key.StockCode,
                        StockName = s.Key.StockName,
                        ItemId = s.FirstOrDefault().ItemId,
                        ItemCode = s.Key.ItemCode,
                        ItemName = s.Key.ItemName,
                        Code = s.Key.ItemCode,
                        HeInCode = s.Key.HeInCode,
                        Name = s.Key.Name,
                        CommodityType = s.Key.CommodityType,
                        ItemLineId = s.Key.ItemLineId,
                        ItemGroupId = s.Key.ItemGroupId,
                        UnitId = s.Key.UnitId,
                        Quantity = s.Sum(o => o.Quantity),
                        AvailableQuantity = s.Sum(o => o.AvailableQuantity),

                        CountryId = s.FirstOrDefault().CountryId,
                        Tutorial = s.FirstOrDefault().Tutorial,
                        ImpPrice = s.FirstOrDefault().ImpPrice,
                        ImpQuantity = s.FirstOrDefault().ImpQuantity,
                        ImpVatRate = s.FirstOrDefault().ImpVatRate,
                        ImpTaxRate = s.FirstOrDefault().ImpTaxRate,
                        Description = s.FirstOrDefault().Description,
                        ActiveSubstance = s.FirstOrDefault().ActiveSubstance,
                        Concentration = s.FirstOrDefault().Concentration,
                        Content = s.FirstOrDefault().Content,
                        Manufacturer = s.FirstOrDefault().Manufacturer,
                        PackagingSpecifications = s.FirstOrDefault().PackagingSpecifications,
                        Dosage = s.FirstOrDefault().Dosage,
                        Lot = s.FirstOrDefault().Lot,
                        DueDate = s.FirstOrDefault().DueDate,
                        TenderDecision = s.FirstOrDefault().TenderDecision,
                        TenderPackage = s.FirstOrDefault().TenderPackage,
                        TenderGroup = s.FirstOrDefault().TenderGroup,
                        TenderYear = s.FirstOrDefault().TenderYear,
                    }).ToList();
                }
                else
                {
                    result.Result = itemStockDtos;
                }

                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }
    }
}
