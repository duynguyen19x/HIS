using HIS.Dtos.Business.ItemStocks;
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
using HIS.ApplicationService.Business.Pharmaceuticals.ItemStocks.Dto;
using HIS.ApplicationService.Dictionary.Services.Dto;
using HIS.EntityFrameworkCore.Migrations;
using HIS.ApplicationService.Dictionary.ServicePricePolicies.Dto;
using HIS.Dtos.Dictionaries.ExecutionRoom;
using HIS.EntityFrameworkCore.Entities.Categories.Items;
using HIS.Utilities.Sections;
using System.Transactions;

namespace HIS.ApplicationService.Business.Pharmaceuticals.ItemStocks
{
    public class ItemStockService : BaseAppService, IItemStockService
    {
        private readonly IBulkRepository<Item, Guid> _itemRepository;
        private readonly IBulkRepository<ItemStock, Guid> _itemStockRepository;
        private readonly IBulkRepository<ItemType, Guid> _itemTypeRepository;
        private readonly IBulkRepository<Room, Guid> _roomRepository;
        private readonly IBulkRepository<ItemLine, Guid> _itemLineRepository;
        private readonly IBulkRepository<ItemGroup, Guid> _itemGroupRepository;
        private readonly IBulkRepository<Country, Guid> _countryRepository;
        private readonly IBulkRepository<Unit, Guid> _unitRepository;
        private readonly IBulkRepository<PatientObjectType, int> _patientObjectTypeRepository;
        private readonly IBulkRepository<ItemPricePolicy, Guid> _itemPricePolicyRepository;


        public ItemStockService(
            IBulkRepository<Item, Guid> itemRepository,
            IBulkRepository<ItemStock, Guid> itemStockRepository,
            IBulkRepository<ItemType, Guid> itemTypeRepository,
            IBulkRepository<Room, Guid> roomRepository,
            IBulkRepository<ItemLine, Guid> itemLineRepository,
            IBulkRepository<ItemGroup, Guid> itemGroupRepository,
            IBulkRepository<Country, Guid> countryRepository,
            IBulkRepository<Unit, Guid> unitRepository,
            IBulkRepository<PatientObjectType, int> patientObjectTypeRepository,
            IBulkRepository<ItemPricePolicy, Guid> itemPricePolicyRepository)
        {
            _itemRepository = itemRepository;
            _itemStockRepository = itemStockRepository;
            _itemTypeRepository = itemTypeRepository;
            _roomRepository = roomRepository;
            _itemLineRepository = itemLineRepository;
            _itemGroupRepository = itemGroupRepository;
            _countryRepository = countryRepository;
            _unitRepository = unitRepository;
            _patientObjectTypeRepository = patientObjectTypeRepository;
            _itemPricePolicyRepository = itemPricePolicyRepository;
        }

        /// <summary>
        /// Danh sách thuốc theo điều kiện
        /// </summary>
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

        /// <summary>
        /// Lấy danh sách thuốc trong kho
        /// </summary>
        /// <param name="stockId"></param>
        /// <returns></returns>
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
                                         //HeInCode = itemType.HeInCode,
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
                        //g.HeInCode,
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
                        //HeInCode = s.Key.HeInCode,
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

        /// <summary>
        /// Nhập dư đầu kỳ
        /// </summary>
        /// <returns></returns>
        public async Task<ResultDto> InportOpeningBalances(List<ItemStockImportExcelDto> input)
        {
            var result = new ResultDto();

            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                var timeNow = DateTime.Now;

                try
                {
                    #region Lấy danh mục ban đầu

                    var stockTypes = new List<int>()
                {
                    (int)RoomTypes.CentralWarehouse,
                    (int)RoomTypes.OutpatientPharmacy,
                    (int)RoomTypes.InpatientPharmacy,
                    (int)RoomTypes.EmergencyCabinet,
                    (int)RoomTypes.OutpatientInventory,
                    (int)RoomTypes.BloodBack,
                    (int)RoomTypes.InventoryCabinet,
                    (int)RoomTypes.ItemManagement,
                    (int)RoomTypes.MaterialManagement,
                };

                    var itemTypes = _itemTypeRepository.GetAll().ToList();
                    var stosks = _roomRepository.GetAll().WhereIf(true, w => stockTypes.Contains(w.RoomTypeId)).ToList();
                    var itemLines = _itemLineRepository.GetAll().ToList();
                    var itemGroups = _itemGroupRepository.GetAll().ToList();
                    var countries = _countryRepository.GetAll().ToList();
                    var units = _unitRepository.GetAll().ToList();
                    var patientObjectTypes = _patientObjectTypeRepository.GetAll().ToList();

                    #endregion

                    #region Tạo danh mục thuốc con (thuốc theo lô hạn, mã con)

                    var items = new List<Item>();
                    var itemStocks = new List<ItemStock>();
                    var itemPricePolicies = new List<ItemPricePolicy>();

                    var inputGroups = input.GroupBy(g => new
                    {
                        g.Quantity,
                        g.AvailableQuantity,
                        g.StockCode,
                        g.SortOrder,
                        g.ItemLineCode,
                        g.ItemGroupCode,
                        g.ItemTypeCode,
                        g.UnitCode,
                        g.Tutorial,
                        g.CountryCode,
                        g.ImpPrice,
                        g.ImpQuantity,
                        g.ImpVatRate,
                        g.ImpTaxRate,
                        g.Description,
                        g.ActiveSubstance,
                        g.Concentration,
                        g.Content,
                        g.Manufacturer,
                        g.PackagingSpecifications,
                        g.Dosage,
                        g.Lot,
                        g.DueDate,
                        g.TenderDecision,
                        g.TenderPackage,
                        g.TenderGroup,
                        g.TenderYear,
                        g.Inactive,
                        g.CommodityType,
                        g.PatientTypeCode,
                        g.OldUnitPrice,
                        g.NewUnitPrice,
                        g.PaymentRate,
                        g.CeilingPrice,
                        g.ExecutionTime,
                    }).Select(s => new ItemStockImportExcelDto()
                    {
                        //StockId = s.Key.StockId,
                        //ItemId = s.Key.ItemId,
                        Quantity = s.Key.Quantity,
                        AvailableQuantity = s.Key.AvailableQuantity,
                        StockCode = s.Key.StockCode,
                        //StockName = s.Key.StockName,
                        //ItemCode = s.Key.ItemCode,
                        //ItemName = s.Key.ItemName,
                        //Code = s.Key.Code,
                        //HeInCode = s.Key.HeInCode,
                        //Name = s.Key.Name,
                        SortOrder = s.Key.SortOrder,
                        ItemLineCode = s.Key.ItemLineCode,
                        //ItemGroupId = s.Key.ItemGroupId,
                        ItemGroupCode = s.Key.ItemGroupCode,
                        //ItemTypeId = s.Key.ItemTypeId,
                        ItemTypeCode = s.Key.ItemTypeCode,
                        //UnitId = s.Key.UnitId,
                        UnitCode = s.Key.UnitCode,
                        Tutorial = s.Key.Tutorial,
                        //CountryId = s.Key.CountryId,
                        CountryCode = s.Key.CountryCode,
                        ImpPrice = s.Key.ImpPrice,
                        ImpQuantity = s.Key.ImpQuantity,
                        ImpVatRate = s.Key.ImpVatRate,
                        ImpTaxRate = s.Key.ImpTaxRate,
                        Description = s.Key.Description,
                        ActiveSubstance = s.Key.ActiveSubstance,
                        Concentration = s.Key.Concentration,
                        Content = s.Key.Content,
                        Manufacturer = s.Key.Manufacturer,
                        PackagingSpecifications = s.Key.PackagingSpecifications,
                        Dosage = s.Key.Dosage,
                        Lot = s.Key.Lot,
                        DueDate = s.Key.DueDate,
                        TenderDecision = s.Key.TenderDecision,
                        TenderPackage = s.Key.TenderPackage,
                        TenderGroup = s.Key.TenderGroup,
                        TenderYear = s.Key.TenderYear,
                        Inactive = s.Key.Inactive,
                        CommodityType = s.Key.CommodityType,

                        //PatientTypeCode = s.Key.PatientTypeCode,
                        //OldUnitPrice = s.Key.OldUnitPrice,
                        //NewUnitPrice = s.Key.NewUnitPrice,
                        //PaymentRate = s.Key.PaymentRate,
                        //CeilingPrice = s.Key.CeilingPrice,
                        //ExecutionTime = s.Key.ExecutionTime,
                    }).ToList();

                    var datas = (from data in inputGroups
                                 join itemType in itemTypes on data.ItemTypeCode equals itemType.Code
                                 join stock in stosks on data.StockCode equals stock.Code
                                 join itemLine in itemLines on data.ItemLineCode equals itemLine.Code
                                 join itemGroup in itemGroups on data.ItemGroupCode equals itemGroup.Code
                                 join country in countries on data.CountryCode equals country.Code
                                 join unit in units on data.UnitCode equals unit.Code

                                 select new ItemStockImportExcelDto()
                                 {
                                     StockId = stock.Id,
                                     Quantity = data.Quantity,
                                     AvailableQuantity = data.AvailableQuantity,
                                     StockCode = data.StockCode,
                                     StockName = stock.Name,
                                     SortOrder = data.SortOrder,
                                     ItemLineId = itemLine.Id,
                                     ItemLineCode = data.ItemLineCode,
                                     ItemGroupId = itemGroup.Id,
                                     ItemGroupCode = data.ItemGroupCode,
                                     ItemTypeId = itemType.Id,
                                     ItemTypeCode = data.ItemTypeCode,
                                     UnitId = unit.Id,
                                     UnitCode = data.UnitCode,
                                     Tutorial = data.Tutorial,
                                     CountryId = country.Id,
                                     CountryCode = data.CountryCode,
                                     ImpPrice = data.ImpPrice,
                                     ImpQuantity = data.ImpQuantity,
                                     ImpVatRate = data.ImpVatRate,
                                     ImpTaxRate = data.ImpTaxRate,
                                     Description = data.Description,
                                     ActiveSubstance = data.ActiveSubstance,
                                     Concentration = data.Concentration,
                                     Content = data.Content,
                                     Manufacturer = data.Manufacturer,
                                     PackagingSpecifications = data.PackagingSpecifications,
                                     Dosage = data.Dosage,
                                     Lot = data.Lot,
                                     DueDate = data.DueDate,
                                     TenderDecision = data.TenderDecision,
                                     TenderPackage = data.TenderPackage,
                                     TenderGroup = data.TenderGroup,
                                     TenderYear = data.TenderYear,
                                     Inactive = data.Inactive,
                                     CommodityType = data.CommodityType,

                                     //PatientTypeCode = data.PatientTypeCode,
                                     //OldUnitPrice = data.OldUnitPrice,
                                     //NewUnitPrice = data.NewUnitPrice,
                                     //PaymentRate = data.PaymentRate,
                                     //CeilingPrice = data.CeilingPrice,
                                     //ExecutionTime = data.ExecutionTime,
                                 }).ToList();

                    foreach (var data in datas)
                    {
                        var item = ObjectMapper.Map<Item>((ItemDto)data);
                        item.Id = Guid.NewGuid();
                        item.CreatedDate = DateTime.Now;
                        item.CreatedBy = SessionExtensions.Login.Id;

                        var itemStock = ObjectMapper.Map<ItemStock>((ItemStockDto)data);
                        itemStock.ItemId = item.Id;
                        itemStock.CreatedDate = timeNow;
                        itemStock.CreatedBy = SessionExtensions.Login.Id;

                        var itemPricePolicyDots = inputGroups.Where(w => w.Lot == data.Lot && w.DueDate == data.DueDate && w.ItemTypeCode == data.ItemTypeCode).ToList();
                        var itemPricePolicys = (from itemPricePolicy in itemPricePolicyDots
                                                join patientObjectType in patientObjectTypes on itemPricePolicy.PatientTypeCode equals patientObjectType.Code
                                                select new ItemPricePolicy()
                                                {
                                                    CreatedDate = timeNow,
                                                    CreatedBy = SessionExtensions.Login.Id,
                                                    PatientTypeId = patientObjectType.Id,
                                                    OldUnitPrice = itemPricePolicy.OldUnitPrice,
                                                    NewUnitPrice = itemPricePolicy.NewUnitPrice,
                                                    CeilingPrice = itemPricePolicy.CeilingPrice,
                                                    PaymentRate = itemPricePolicy.PaymentRate,
                                                    ExecutionTime = itemPricePolicy.ExecutionTime,
                                                    ItemId = item.Id,
                                                }).ToList();

                        items.Add(item);
                        itemStocks.Add(itemStock);
                        itemPricePolicies.AddRange(itemPricePolicys);
                    }

                    // Gán mã con cho Item
                    if (items.Count > 0)
                    {
                        foreach (var item in items)
                        {
                            var itemType = itemTypes.FirstOrDefault(f => f.Id == item.ItemTypeId);
                            if (itemType != null)
                            {
                                itemType.AutoNumber += 1;
                                item.Code = string.Format("{0}.{1}", itemType.Code, itemType.AutoNumber);
                            }
                        }
                    }

                    #endregion

                    #region Lưu dữ liệu

                    await _itemRepository.BulkInsertAsync(items);
                    await _itemStockRepository.BulkInsertAsync(itemStocks);
                    await _itemPricePolicyRepository.BulkInsertAsync(itemPricePolicies);

                    #endregion

                    unitOfWork.Complete();
                }
                catch (Exception ex)
                {
                    result.Message = ex.Message;
                    result.IsSucceeded = false;
                }
                finally 
                {
                    unitOfWork.Dispose();
                }
            }

            return await Task<ResultDto>.FromResult(result);
        }
    }
}
