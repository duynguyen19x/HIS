using AutoMapper;
using HIS.Core.Linq;
using HIS.Dtos.Business.InOutStockItems;
using HIS.Dtos.Business.InOutStocks;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ItemPricePolicies;
using HIS.EntityFrameworkCore.Entities.Business;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Categories.Items;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using HIS.Utilities.Enums;
using HIS.Utilities.Helpers;
using HIS.Utilities.Sections;
using Microsoft.Extensions.Configuration;
using System.Globalization;

namespace HIS.ApplicationService.Business.Pharmaceuticals.InOutStocks
{
    public class InOutStockService : BaseSerivce, IInOutStockService
    {
        public InOutStockService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
            : base(dbContext, config, mapper) { }

        public async Task<ApiResultList<InOutStockDto>> GetByStocks(Guid stockId, string fromDate, string toDate)
        {
            var result = new ApiResultList<InOutStockDto>();

            try
            {
                DateTime fromDateTime = DateTime.ParseExact(fromDate, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None);
                DateTime toDateTime = DateTime.ParseExact(toDate, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None);

                result.Result = (from inOutStock in _dbContext.InOutStocks

                                 join imStock in _dbContext.Rooms on inOutStock.ImpStockId equals imStock.Id into imStockDefaults
                                 from imStockDefault in imStockDefaults.DefaultIfEmpty()

                                 join exStock in _dbContext.Rooms on inOutStock.ExpStockId equals exStock.Id into exStockDefaults
                                 from exStockDefault in exStockDefaults.DefaultIfEmpty()

                                 join inOutStockType in _dbContext.InOutStockTypes on inOutStock.InOutStockTypeId equals inOutStockType.Id into inOutStockTypeDefaults
                                 from inOutStockTypeDefault in inOutStockTypeDefaults.DefaultIfEmpty()

                                 select new InOutStockDto()
                                 {
                                     Id = inOutStock.Id,
                                     Code = inOutStock.Code,
                                     Type = inOutStock.Type,
                                     Status = inOutStock.Status,
                                     ImpStockId = inOutStock.ImpStockId,
                                     ImpStockCode = imStockDefault != null ? imStockDefault.Code : null,
                                     ImpStockName = imStockDefault != null ? imStockDefault.Name : null,
                                     ExpStockId = inOutStock.ExpStockId,
                                     ExpStockCode = exStockDefault != null ? exStockDefault.Code : null,
                                     ExpStockName = exStockDefault != null ? exStockDefault.Name : null,
                                     InOutStockTypeId = inOutStock.InOutStockTypeId,
                                     InOutStockTypeName = inOutStockTypeDefault != null ? inOutStockTypeDefault.Name : null,
                                     ReceiverUserId = inOutStock.ReceiverUserId,
                                     ApproverUserId = inOutStock.ApproverUserId,
                                     ReqTime = inOutStock.ReqTime,
                                     CreationUserId = inOutStock.CreationUserId,
                                     StockImpUserId = inOutStock.StockImpUserId,
                                     StockImpTime = inOutStock.StockImpTime,
                                     ApproverTime = inOutStock.ApproverTime,
                                     Description = inOutStock.Description,
                                     ReqRoomId = inOutStock.ReqRoomId,
                                     ReqDepartmentId = inOutStock.ReqDepartmentId,
                                     PatientRecordId = inOutStock.PatientRecordId,
                                     PatientId = inOutStock.PatientId,
                                     SupplierId = inOutStock.SupplierId,
                                     InvTime = inOutStock.InvTime,
                                     InvNo = inOutStock.InvNo,
                                     Deliverer = inOutStock.Deliverer,
                                     StockExpTime = inOutStock.StockExpTime,
                                     StockExpUserId = inOutStock.StockExpUserId,
                                     CommodityType = inOutStock.CommodityType,
                                 })
                                 .WhereIf(fromDateTime != (DateTime)default, w => w.ReqTime >= fromDateTime)
                                 .WhereIf(toDateTime != (DateTime)default, w => w.ReqTime <= toDateTime)
                                 .WhereIf(!GuidHelper.IsNullOrEmpty(stockId), w => w.ImpStockId == stockId || w.ExpStockId == stockId)
                                 .ToList();
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }


            return await Task.FromResult(result);
        }

        #region Nhập từ nhà cung cấp
        /// <summary>
        /// Lấy phiếu nhập NCC
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ApiResult<InOutStockDto>> ImportFromSupplierGetById(Guid id)
        {
            var result = new ApiResult<InOutStockDto>();

            try
            {
                var inOutStockDto = _mapper.Map<InOutStockDto>(_dbContext.InOutStocks.FirstOrDefault(d => d.Id == id));
                if (inOutStockDto != null)
                {
                    // Nhập thuốc NCC
                    if (inOutStockDto.InOutStockTypeId == 1)
                    {
                        var inOutStockItemDtos = _mapper.Map<IList<InOutStockItemDto>>(_dbContext.InOutStockItems.Where(w => w.InOutStockId == id).ToList());
                        var ItemIds = inOutStockItemDtos.Select(s => s.ItemId).ToList();
                        var ItemDtos = _mapper.Map<IList<Item>>(_dbContext.Items.Where(w => ItemIds.Contains(w.Id)).ToList());

                        var ItemPricePolicyDtos = (from med in _dbContext.ItemPricePolicies
                                                       join pa in _dbContext.PatientTypes on med.PatientTypeId equals pa.Id
                                                       select new ItemPricePolicyDto()
                                                       {
                                                           Id = med.Id,
                                                           ItemId = med.ItemId,
                                                           PatientTypeId = med.PatientTypeId,
                                                           OldUnitPrice = med.OldUnitPrice,
                                                           NewUnitPrice = med.NewUnitPrice,
                                                           CeilingPrice = med.CeilingPrice,
                                                           PaymentRate = med.PaymentRate,
                                                           ExecutionTime = med.ExecutionTime,
                                                           PatientTypeCode = pa.Code,
                                                           PatientTypeName = pa.Name,
                                                           IsHeIn = pa.Code == PatientTypes.BHYT ? true : false,
                                                       })
                                                      .WhereIf(ItemIds != null, w => ItemIds.Contains(w.ItemId))
                                                      .OrderBy(s => s.PatientTypeCode).ToList();

                        foreach (var inOutStockItem in inOutStockItemDtos)
                        {
                            var sItem = ItemDtos.FirstOrDefault(f => f.Id == inOutStockItem.ItemId);

                            if (!string.IsNullOrEmpty(sItem.Code))
                                inOutStockItem.Code = sItem.Code.Split('.')?[0];

                            inOutStockItem.HeInCode = sItem.HeInCode;
                            inOutStockItem.Name = sItem.Name;
                            inOutStockItem.SortOrder = sItem.SortOrder;
                            inOutStockItem.ItemLineId = sItem.ItemLineId;
                            inOutStockItem.ItemGroupId = sItem.ItemGroupId;
                            inOutStockItem.ItemTypeId = sItem.ItemTypeId;
                            inOutStockItem.UnitId = sItem.UnitId;
                            inOutStockItem.Tutorial = sItem.Tutorial;
                            inOutStockItem.CountryId = sItem.CountryId;
                            inOutStockItem.ImpPrice = sItem.ImpPrice;
                            inOutStockItem.ImpVatRate = sItem.ImpVatRate;
                            inOutStockItem.ImpTaxRate = sItem.ImpTaxRate;
                            inOutStockItem.Description = sItem.Description;
                            inOutStockItem.ActiveSubstance = sItem.ActiveSubstance;
                            inOutStockItem.Concentration = sItem.Concentration;
                            inOutStockItem.Content = sItem.Content;
                            inOutStockItem.Manufacturer = sItem.Manufacturer;
                            inOutStockItem.PackagingSpecifications = sItem.PackagingSpecifications;
                            inOutStockItem.Dosage = sItem.Dosage;
                            inOutStockItem.Lot = sItem.Lot;
                            inOutStockItem.DueDate = sItem.DueDate;
                            inOutStockItem.TenderDecision = sItem.TenderDecision;
                            inOutStockItem.TenderPackage = sItem.TenderPackage;
                            inOutStockItem.TenderGroup = sItem.TenderGroup;
                            inOutStockItem.TenderYear = sItem.TenderYear;

                            inOutStockItem.ItemPricePolicies = ItemPricePolicyDtos.Where(w => w.ItemId == inOutStockItem.ItemId).ToList();
                        }

                        inOutStockDto.InOutStockItems = inOutStockItemDtos;
                    }
                }

                result.Result = inOutStockDto;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        /// <summary>
        /// Hủy nhập kho
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ApiResult<InOutStockDto>> ImportFromSupplierCanceled(InOutStockDto input)
        {
            var result = new ApiResult<InOutStockDto>();

            try
            {
                var timeNow = DateTime.Now;
                var inOutStocks = _dbContext.InOutStocks.FirstOrDefault(w => w.Id == input.Id);

                // Nhập thuốc từ nhà cung cấp
                if (inOutStocks.InOutStockTypeId == 1)
                {
                    var ItemOlds = (from inOutStock in _dbContext.InOutStocks
                                        join inOutStockItem in _dbContext.InOutStockItems on inOutStock.Id equals inOutStockItem.InOutStockId
                                        where inOutStock.Id == input.Id && inOutStock.IsDeleted == false
                                        select new
                                        {
                                            inOutStockItem.Id,
                                            inOutStockItem.ItemId,
                                            inOutStockItem.RequestQuantity,
                                            inOutStockItem.ApprovedQuantity,
                                            inOutStock.ImpStockId,
                                            inOutStock.InOutStockTypeId,
                                        }).Distinct().ToList();


                    if (ItemOlds != null && ItemOlds.Count > 0)
                    {
                        var stockId = ItemOlds.Select(s => s.ImpStockId).Distinct().ToList();
                        var medicinIds = ItemOlds.Select(s => s.ItemId).Distinct().ToList();
                        var ItemStocks = _dbContext.ItemStocks.Where(w => stockId.Contains(w.StockId) && medicinIds.Contains(w.ItemId)).ToList();

                        // Ktra số lượng đã bị xuất nhập chưa để hủy phiếu
                        bool anyExists = ItemStocks.Any(record => ItemOlds.Any(r => r.ApprovedQuantity < record.AvailableQuantity));
                        if (anyExists)
                        {
                            result.Message = "Bạn không thể hủy nhập kho khi phiếu thuốc đã được sử dụng!";
                            result.IsSuccessed = false;
                        }
                        else
                        {
                            inOutStocks.Status = InOutStatusType.New;
                            inOutStocks.ModifiedDate = timeNow;
                            inOutStocks.ModifiedBy = SessionExtensions.Login?.Id;
                            inOutStocks.StockExpTime = null;
                            inOutStocks.ApproverTime = null;

                            foreach (var ItemStock in ItemStocks)
                            {
                                var Item = ItemOlds.FirstOrDefault(s => s.ItemId == ItemStock.ItemId && s.ImpStockId == ItemStock.StockId);
                                if (Item != null)
                                {
                                    ItemStock.ModifiedDate = timeNow;
                                    ItemStock.ModifiedBy = SessionExtensions.Login?.Id;

                                    ItemStock.Quantity -= Item.ApprovedQuantity.GetValueOrDefault();
                                    ItemStock.AvailableQuantity -= Item.ApprovedQuantity.GetValueOrDefault();
                                }
                            }
                        }

                        _dbContext.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        /// <summary>
        /// Lưu phiếu tạm
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResult<InOutStockDto>> ImportFromSupplierSaveAsDraft(InOutStockDto input)
        {
            return await ImportFromSupplier(input);
        }

        /// <summary>
        /// Nhập kho
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResult<InOutStockDto>> ImportFromSupplierStockIn(InOutStockDto input)
        {
            input.Status = InOutStatusType.ReceivedInStock;
            return await ImportFromSupplier(input);
        }
        
        /// <summary>
        /// Hủy phiếu (xóa phiếu)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ApiResult<bool>> ImportFromSupplierDeleted(Guid id)
        {
            var result = new ApiResult<bool>();

            using (var transaction = _dbContext.BeginTransaction())
            {
                try
                {
                    var timeNow = DateTime.Now;

                    var inOutStock = _dbContext.InOutStocks.FirstOrDefault(f => f.Id == id);
                    if (inOutStock != null)
                    {
                        inOutStock.Status = InOutStatusType.Canceled;
                        inOutStock.DeletedBy = SessionExtensions.Login?.Id;
                        inOutStock.DeletedDate = timeNow;
                        inOutStock.IsDeleted = true;

                        var inOutStockItems = _dbContext.InOutStockItems.Where(w => w.InOutStockId == id).ToList();
                        if (inOutStockItems != null)
                        {
                            var ItemIds = inOutStockItems.Select(s => s.ItemId).ToList();
                            var Items = _dbContext.Items.Where(w => ItemIds.Contains(w.Id)).ToList();
                            if (Items != null && Items.Count > 0)
                            {
                                foreach (var Item in Items)
                                {
                                    Item.DeletedBy = SessionExtensions.Login?.Id;
                                    Item.DeletedDate = timeNow;
                                    Item.IsDeleted = true;
                                }

                                var ItemPricePolicies = _dbContext.ItemPricePolicies.Where(w => ItemIds.Contains(w.ItemId)).ToList();
                                foreach (var pricePolicy in ItemPricePolicies)
                                {
                                    pricePolicy.DeletedBy = SessionExtensions.Login?.Id;
                                    pricePolicy.DeletedDate = timeNow;
                                    pricePolicy.IsDeleted = true;
                                }
                            }
                        }
                    }

                    _dbContext.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;
                }
                finally
                {
                    transaction.Dispose();
                }
            }

            return await Task.FromResult(result);
        }

        /// <summary>
        /// Nhập thuốc từ NCC
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private async Task<ApiResult<InOutStockDto>> ImportFromSupplier(InOutStockDto input)
        {
            var result = new ApiResult<InOutStockDto>();

            result = await ImportFromSupplierValid(input);
            if (!result.IsSuccessed)
            {
                return result;
            }

            using (var transaction = _dbContext.BeginTransaction())
            {
                try
                {
                    var dateNow = DateTime.Now;
                    var id = Guid.NewGuid();
                    input.InOutStockTypeId = (int)Utilities.Enums.InOutStockType.ImportFromSupplier;

                    var inOutStockItems = new List<InOutStockItem>();
                    var Items = new List<Item>();
                    var ItemStocks = new List<EntityFrameworkCore.Entities.Business.ItemStock>();
                    var ItemPricePolicies = new List<ItemPricePolicy>();

                    if (GuidHelper.IsNullOrEmpty(input.Id))
                    {
                        var dImMest = _mapper.Map<EntityFrameworkCore.Entities.Business.InOutStock>(input);
                        dImMest.Id = id;
                        dImMest.CreatedBy = SessionExtensions.Login?.Id;
                        dImMest.CreatedDate = dateNow;

                        foreach (var inOutStockItemDto in input.InOutStockItems)
                        {
                            inOutStockItemDto.ApprovedQuantity = inOutStockItemDto.RequestQuantity;

                            var Item = _mapper.Map<Item>(inOutStockItemDto);
                            if (!GuidHelper.IsNullOrEmpty(inOutStockItemDto.ItemId))
                                Item.Id = inOutStockItemDto.ItemId.GetValueOrDefault();
                            else
                                Item.Id = Guid.NewGuid();
                            Item.CreatedDate = dateNow;
                            Item.CreatedBy = SessionExtensions.Login?.Id;
                            Item.ImpQuantity = inOutStockItemDto.RequestQuantity;

                            var inOutStockItem = _mapper.Map<InOutStockItem>(inOutStockItemDto);
                            inOutStockItem.Id = Guid.NewGuid();
                            inOutStockItem.InOutStockId = id;
                            inOutStockItem.ItemId = Item.Id;

                            if (inOutStockItemDto.ItemPricePolicies != null)
                            {
                                foreach (var sItemPricePolicyDto in inOutStockItemDto.ItemPricePolicies)
                                {
                                    var sItemPricePolicy = _mapper.Map<ItemPricePolicy>(sItemPricePolicyDto);

                                    if (GuidHelper.IsNullOrEmpty(sItemPricePolicy.Id))
                                        sItemPricePolicy.Id = Guid.NewGuid();

                                    sItemPricePolicy.CreatedDate = dateNow;
                                    sItemPricePolicy.CreatedBy = SessionExtensions.Login?.Id;
                                    sItemPricePolicy.ItemId = Item.Id;

                                    ItemPricePolicies.Add(sItemPricePolicy);
                                }
                            }

                            // Trạng thái nhập kho mới thêm vào thuốc trong kho
                            if (input.Status == InOutStatusType.ReceivedInStock)
                            {
                                dImMest.ApproverTime = dateNow;
                                dImMest.ApproverUserId = SessionExtensions.Login?.Id;
                                dImMest.StockImpTime = dateNow;
                                dImMest.StockImpUserId = SessionExtensions.Login?.Id;

                                ItemStocks.Add(new EntityFrameworkCore.Entities.Business.ItemStock()
                                {
                                    Id = Guid.NewGuid(),
                                    CreatedDate = dateNow,
                                    CreatedBy = SessionExtensions.Login?.Id,
                                    AvailableQuantity = inOutStockItemDto.ApprovedQuantity.GetValueOrDefault(),
                                    Quantity = inOutStockItemDto.ApprovedQuantity.GetValueOrDefault(),
                                    StockId = input.ImpStockId,
                                    ItemId = Item.Id
                                });
                            }

                            Items.Add(Item);
                            inOutStockItems.Add(inOutStockItem);
                        }

                        if (Items.Count > 0)
                        {
                            var ItemTypeIds = Items.Select(s => s.ItemTypeId).ToList();
                            var ItemTypes = _dbContext.ItemTypes.Where(w => ItemTypeIds.Contains(w.Id)).ToList();
                            if (ItemTypes != null && ItemTypes.Count > 0)
                            {
                                foreach (var Item in Items)
                                {
                                    var ItemType = ItemTypes.FirstOrDefault(f => f.Id == Item.ItemTypeId);
                                    if (ItemType != null)
                                    {
                                        ItemType.AutoNumber += 1;
                                        Item.Code = string.Format("{0}.{1}", ItemType.Code, ItemType.AutoNumber);
                                    }
                                }
                            }
                        }

                        _dbContext.InOutStocks.Add(dImMest);
                    }
                    else
                    {
                        var dImMestOld = _dbContext.InOutStocks.FirstOrDefault(d => d.Id == input.Id);

                        // Xóa bản ghi cũ
                        var inOutStockItemOlds = _dbContext.InOutStockItems.Where(s => s.InOutStockId == input.Id).ToList();
                        var ItemOldIds = inOutStockItemOlds.Select(s => s.ItemId).ToList();
                        var ItemOlds = _dbContext.Items.Where(w => ItemOldIds.Contains(w.Id)).ToList();
                        var ItemStockOlds = _dbContext.ItemStocks.Where(w => ItemOldIds.Contains(w.ItemId) && w.StockId == dImMestOld.ImpStockId).ToList();
                        var ItemPricePolicyOlds = _dbContext.ItemPricePolicies.Where(w => ItemOldIds.Contains(w.ItemId)).ToList();

                        if (inOutStockItemOlds != null && ItemOlds != null)
                        {
                            _dbContext.ItemPricePolicies.RemoveRange(ItemPricePolicyOlds);
                            _dbContext.ItemStocks.RemoveRange(ItemStockOlds);
                            _dbContext.InOutStockItems.RemoveRange(inOutStockItemOlds);
                            _dbContext.Items.RemoveRange(ItemOlds);

                            // Chưa biết nguyên nhân: Khi xóa bản ghi cũ và thêm bản ghi mới lại update khóa ngoại về NULL
                            _dbContext.SaveChanges();
                        }

                        foreach (var inOutStockItemDto in input.InOutStockItems)
                        {
                            inOutStockItemDto.ApprovedQuantity = inOutStockItemDto.RequestQuantity;

                            var Item = _mapper.Map<Item>(inOutStockItemDto);
                            if (!GuidHelper.IsNullOrEmpty(inOutStockItemDto.ItemId))
                            {
                                Item.Id = inOutStockItemDto.ItemId.GetValueOrDefault();
                                var ItemOld = ItemOlds.FirstOrDefault(f => f.Id == Item.Id);
                                if (ItemOld != null)
                                    Item.Code = ItemOld.Code;
                            }
                            else
                            {
                                Item.Id = Guid.NewGuid();

                                var ItemType = _dbContext.ItemTypes.FirstOrDefault(f => f.Id == Item.ItemTypeId);
                                if (ItemType != null)
                                {
                                    ItemType.AutoNumber += 1;
                                    Item.Code = string.Format("{0}.{1}", ItemType.Code, ItemType.AutoNumber);
                                }
                            }
                            Item.CreatedDate = dImMestOld.CreatedDate;
                            Item.CreatedBy = dImMestOld.CreatedBy;
                            Item.ModifiedDate = dateNow;
                            Item.ModifiedBy = SessionExtensions.Login?.Id;
                            Item.ImpQuantity = inOutStockItemDto.RequestQuantity;

                            var inOutStockItem = _mapper.Map<InOutStockItem>(inOutStockItemDto);
                            if (GuidHelper.IsNullOrEmpty(inOutStockItem.Id))
                                inOutStockItem.Id = Guid.NewGuid();

                            inOutStockItem.ItemId = Item.Id;
                            inOutStockItem.InOutStockId = input.Id;

                            if (inOutStockItemDto.ItemPricePolicies != null)
                            {
                                foreach (var sItemPricePolicyDto in inOutStockItemDto.ItemPricePolicies)
                                {
                                    var sItemPricePolicy = _mapper.Map<ItemPricePolicy>(sItemPricePolicyDto);

                                    if (GuidHelper.IsNullOrEmpty(sItemPricePolicy.Id))
                                        sItemPricePolicy.Id = Guid.NewGuid();

                                    sItemPricePolicy.CreatedDate = dImMestOld.CreatedDate;
                                    sItemPricePolicy.CreatedBy = dImMestOld.CreatedBy;
                                    sItemPricePolicy.ModifiedDate = dateNow;
                                    sItemPricePolicy.ModifiedBy = SessionExtensions.Login?.Id;
                                    sItemPricePolicy.ItemId = Item.Id;

                                    ItemPricePolicies.Add(sItemPricePolicy);
                                }
                            }

                            // Trạng thái nhập kho mới thêm vào thuốc trong kho
                            if (input.Status == InOutStatusType.ReceivedInStock)
                            {
                                input.ApproverTime = dateNow;
                                input.ApproverUserId = SessionExtensions.Login?.Id;
                                input.StockImpTime = dateNow;
                                input.StockImpUserId = SessionExtensions.Login?.Id;

                                ItemStocks.Add(new EntityFrameworkCore.Entities.Business.ItemStock()
                                {
                                    Id = Guid.NewGuid(),
                                    CreatedDate = dateNow,
                                    CreatedBy = SessionExtensions.Login?.Id,
                                    AvailableQuantity = inOutStockItemDto.ApprovedQuantity.GetValueOrDefault(),
                                    Quantity = inOutStockItemDto.ApprovedQuantity.GetValueOrDefault(),
                                    StockId = input.ImpStockId,
                                    ItemId = Item.Id
                                });
                            }

                            Items.Add(Item);
                            inOutStockItems.Add(inOutStockItem);
                        }

                        _mapper.Map(input, dImMestOld);
                        dImMestOld.ModifiedDate = dateNow;
                        dImMestOld.ModifiedBy = SessionExtensions.Login?.Id;
                    }

                    _dbContext.Items.AddRange(Items);
                    _dbContext.InOutStockItems.AddRange(inOutStockItems);
                    _dbContext.ItemStocks.AddRange(ItemStocks);
                    _dbContext.ItemPricePolicies.AddRange(ItemPricePolicies);

                    _dbContext.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;
                }
                finally
                {
                    transaction.Dispose();
                }
            }

            return await Task.FromResult(result);
        }

        /// <summary>
        /// Ktra trước khi lưu
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private async Task<ApiResult<InOutStockDto>> ImportFromSupplierValid(InOutStockDto input)
        {
            var result = new ApiResult<InOutStockDto>();

            try
            {
                var erros = new List<string>();

                var erroMasters = new List<string>();

                if (GuidHelper.IsNullOrEmpty(input.ImpStockId))
                    erroMasters.Add("Kho nhập");
                if (DatetimeHelper.IsNullOrEmpty(input.ReqTime))
                    erroMasters.Add("Ngày lập");
                if (DatetimeHelper.IsNullOrEmpty(input.InvTime))
                    erroMasters.Add("Ngày HĐ");
                if (GuidHelper.IsNullOrEmpty(input.SupplierId))
                    erroMasters.Add("Nhà cung cấp");

                if (erroMasters.Count > 0)
                    erros.Add(string.Format("{0} không được bỏ trống!", string.Join(", ", erroMasters)));

                if (!string.IsNullOrEmpty(input.Code))
                {
                    var any = _dbContext.InOutStocks.Any(a => a.Id != input.Id && a.Code == input.Code);
                    if (any)
                        erros.Add(string.Format("Mã phiếu nhập [{0}] đã tồn tại trên hệ thống. Vui lòng kiểm tra lại!", input.Code));
                }

                if (input.InOutStockItems == null && input.InOutStockItems.Count == 0)
                    erros.Add("Không có thuốc nào được chọn trong danh sách!");

                foreach (var detail in input.InOutStockItems)
                {
                    var erroItems = new List<string>();

                    if (detail.RequestQuantity == 0)
                        erroItems.Add("Số lượng");
                    if (DatetimeHelper.IsNullOrEmpty(detail.DueDate))
                        erroItems.Add("Hạn dùng");

                    if (erroItems.Count > 0)
                    {
                        var erro = string.Format("Mã thuốc {0}: {1} không được để trống!", detail.Code, string.Join(", ", erroItems));
                        erros.Add(erro);
                    }
                }

                if (erros.Count > 0)
                {
                    result.Message = string.Join(", ", erros);
                    result.IsSuccessed = false;
                }
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }
        #endregion

        #region Nhập từ kho khác
        /// <summary>
        /// Lấy phiếu nhập NCC
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockGetById(Guid id)
        {
            var result = new ApiResult<InOutStockDto>();

            try
            {
                var inOutStockDto = _mapper.Map<InOutStockDto>(_dbContext.InOutStocks.FirstOrDefault(d => d.Id == id));
                if (inOutStockDto != null)
                {
                    // Nhập từ kho khác
                    if (inOutStockDto.InOutStockTypeId == (int)Utilities.Enums.InOutStockType.ImportFromAnotherStock)
                    {
                        var inOutStockItemDtos = (from inOutStockItem in _dbContext.InOutStockItems
                                                      join Item in _dbContext.Items on inOutStockItem.ItemId equals Item.Id
                                                      where inOutStockItem.InOutStockId == id
                                                      select new InOutStockItemDto()
                                                      {
                                                          Id = inOutStockItem.Id,
                                                          Code = Item.Code,
                                                          HeInCode = Item.HeInCode,
                                                          Name = Item.Name,
                                                          ItemId = inOutStockItem.ItemId,
                                                          SortOrder = Item.SortOrder,
                                                          ItemLineId = Item.ItemLineId,
                                                          ItemGroupId = Item.ItemGroupId,
                                                          ItemTypeId = Item.ItemTypeId,
                                                          UnitId = Item.UnitId,
                                                          Tutorial = Item.Tutorial,
                                                          CountryId = Item.CountryId,
                                                          ImpPrice = Item.ImpPrice,
                                                          RequestQuantity = inOutStockItem.RequestQuantity,
                                                          ApprovedQuantity = inOutStockItem.ApprovedQuantity,
                                                          ImpVatRate = Item.ImpVatRate,
                                                          ImpTaxRate = Item.ImpTaxRate,
                                                          Description = Item.Description,
                                                          ActiveSubstance = Item.ActiveSubstance,
                                                          Concentration = Item.Concentration,
                                                          Content = Item.Content,
                                                          Manufacturer = Item.Manufacturer,
                                                          PackagingSpecifications = Item.PackagingSpecifications,
                                                          Dosage = Item.Dosage,
                                                          Lot = Item.Lot,
                                                          DueDate = Item.DueDate,
                                                          TenderDecision = Item.TenderDecision,
                                                          TenderPackage = Item.TenderPackage,
                                                          TenderGroup = Item.TenderGroup,
                                                          TenderYear = Item.TenderYear,
                                                      }).ToList();


                        inOutStockDto.InOutStockItems = inOutStockItemDtos;
                    }
                }

                result.Result = inOutStockDto;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        /// <summary>
        /// Lưu phiếu tạm
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockSaveAsDraft(InOutStockDto input)
        {
            input.Status = InOutStatusType.New;
            return await ImportFromAnotherStock(input);
        }

        /// <summary>
        /// Gửi yêu cầu
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockRequest(InOutStockDto input)
        {
            input.Status = InOutStatusType.Request;
            return await ImportFromAnotherStock(input);
        }

        /// <summary>
        /// Hủy yêu cầu
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockCancelRequest(InOutStockDto input)
        {
            input.Status = InOutStatusType.New;
            return await ImportFromAnotherStock(input);
        }

        /// <summary>
        /// Duyệt phiếu
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockApproved(InOutStockDto input)
        {
            input.Status = InOutStatusType.Approved;
            return await ImportFromAnotherStock(input);
        }

        /// <summary>
        /// Hủy duyệt phiếu
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockCancelApproved(InOutStockDto input)
        {
            input.Status = InOutStatusType.Request;
            return await ImportFromAnotherStock(input);
        }

        /// <summary>
        /// Xuất kho
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockStockOut(InOutStockDto input)
        {
            input.Status = InOutStatusType.ReceivedOutStock;
            return await ImportFromAnotherStock(input);
        }

        /// <summary>
        /// Hủy xuất kho
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockCanCelStockOut(InOutStockDto input)
        {
            input.Status = InOutStatusType.Approved;
            return await ImportFromAnotherStock(input, true, false);
        }

        /// <summary>
        /// Nhập kho
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockStockIn(InOutStockDto input)
        {
            input.Status = InOutStatusType.ReceivedInStock;
            return await ImportFromAnotherStock(input);
        }

        /// <summary>
        /// Hủy nhập kho
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockCancelStockIn(InOutStockDto input)
        {
            input.Status = InOutStatusType.ReceivedOutStock;
            return await ImportFromAnotherStock(input, false, true);
        }

        /// <summary>
        /// Hủy phiếu (xóa phiếu)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ApiResult<bool>> ImportFromAnotherStockDeleted(Guid id)
        {
            var result = new ApiResult<bool>();

            using (var transaction = _dbContext.BeginTransaction())
            {
                try
                {
                    var timeNow = DateTime.Now;

                    var inOutStock = _dbContext.InOutStocks.FirstOrDefault(f => f.Id == id);
                    if (inOutStock != null)
                    {
                        inOutStock.Status = InOutStatusType.Canceled;
                        inOutStock.DeletedBy = SessionExtensions.Login?.Id;
                        inOutStock.DeletedDate = timeNow;
                        inOutStock.IsDeleted = true;

                        // Cộng lại khả dụng cho kho xuất
                        var inOutStockItems = _dbContext.InOutStockItems.Where(w => w.InOutStockId == id).ToList(); 
                        var ItemIds = inOutStockItems.Select(s => s.ItemId).ToList();
                        if (ItemIds != null && ItemIds.Count > 0)
                        {
                            var ItemStockOuts = _dbContext.ItemStocks.Where(w => w.StockId == inOutStock.ExpStockId && ItemIds.Contains(w.ItemId)).ToList();
                            foreach (var ItemStock in ItemStockOuts)
                            {
                                var inOutStockItem = inOutStockItems.FirstOrDefault(f => f.ItemId == ItemStock.ItemId);
                                if (inOutStockItem != null)
                                {
                                    ItemStock.AvailableQuantity += inOutStockItem.ApprovedQuantity.GetValueOrDefault();
                                }
                            }
                        }
                    }

                    _dbContext.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;
                }
                finally
                {
                    transaction.Dispose();
                }
            }

            return await Task.FromResult(result);
        }

        /// <summary>
        /// Nhập thuốc từ kho khác
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private async Task<ApiResult<InOutStockDto>> ImportFromAnotherStock(InOutStockDto input, bool canCelStockOut = false, bool cancelStockIn = false)
        {
            var result = new ApiResult<InOutStockDto>();

            result = await ImportFromAnotherStockValid(input);
            if (!result.IsSuccessed)
            {
                return result;
            }

            using (var transaction = _dbContext.BeginTransaction())
            {
                try
                {
                    var dateNow = DateTime.Now;
                    var id = Guid.NewGuid();

                    input.InOutStockTypeId = (int)Utilities.Enums.InOutStockType.ImportFromAnotherStock;

                    var inOutStock = new EntityFrameworkCore.Entities.Business.InOutStock();
                    var inOutStockItems = new List<InOutStockItem>();
                    var ItemStocks = new List<EntityFrameworkCore.Entities.Business.ItemStock>();

                    if (GuidHelper.IsNullOrEmpty(input.Id)) // Thêm mới (Lưu tạm)
                    {
                        inOutStock = _mapper.Map<EntityFrameworkCore.Entities.Business.InOutStock>(input);
                        inOutStock.Id = id;
                        inOutStock.CreatedBy = SessionExtensions.Login?.Id;
                        inOutStock.CreatedDate = dateNow;

                        foreach (var inOutStockItemDto in input.InOutStockItems)
                        {
                            inOutStockItemDto.ApprovedQuantity = inOutStockItemDto.RequestQuantity;
                            var inOutStockItem = _mapper.Map<InOutStockItem>(inOutStockItemDto);
                            inOutStockItem.Id = Guid.NewGuid();
                            inOutStockItem.InOutStockId = id;

                            inOutStockItems.Add(inOutStockItem);
                        }

                        _dbContext.InOutStocks.Add(inOutStock);
                    }
                    else // Sửa
                    {
                        inOutStock = _dbContext.InOutStocks.FirstOrDefault(d => d.Id == input.Id);

                        // Xóa bản ghi cũ
                        var inOutStockItemOlds = _dbContext.InOutStockItems.Where(s => s.InOutStockId == input.Id).ToList();
                        if (inOutStockItemOlds != null)
                        {
                            // Cộng lại khả dụng bản ghi cũ
                            var ItemIds = inOutStockItemOlds.Select(s => s.ItemId).ToList();
                            if (ItemIds != null && ItemIds.Count > 0)
                            {
                                var ItemStockOuts = _dbContext.ItemStocks.Where(w => w.StockId == input.ExpStockId && ItemIds.Contains(w.ItemId)).ToList();
                                foreach (var ItemStock in ItemStockOuts)
                                {
                                    var inOutStockItem = input.InOutStockItems.FirstOrDefault(f => f.ItemId == ItemStock.ItemId);
                                    if (inOutStockItem != null)
                                    {
                                        ItemStock.AvailableQuantity += inOutStockItem.ApprovedQuantity.GetValueOrDefault();
                                    }
                                }
                            }

                            _dbContext.InOutStockItems.RemoveRange(inOutStockItemOlds);
                        }

                        // Thêm mới bản ghi InOutStockItems
                        foreach (var inOutStockItemDto in input.InOutStockItems)
                        {
                            switch (input.Status)
                            {
                                // Trạng thái thêm mới và gửi y/c thì mặc định để SL YC = SL Duyệt
                                case InOutStatusType.New:
                                case InOutStatusType.Request:
                                    inOutStockItemDto.ApprovedQuantity = inOutStockItemDto.RequestQuantity;
                                    break;
                            }

                            var inOutStockItem = _mapper.Map<InOutStockItem>(inOutStockItemDto);
                            if (GuidHelper.IsNullOrEmpty(inOutStockItem.Id))
                                inOutStockItem.Id = Guid.NewGuid();
                            inOutStockItem.InOutStockId = input.Id;

                            inOutStockItems.Add(inOutStockItem);
                        }

                        switch (input.Status)
                        {
                            case InOutStatusType.Approved:
                                {
                                    foreach (var inOutStockItem in inOutStockItems)
                                    {
                                        if (inOutStockItem.ApprovedQuantity == null)
                                        {
                                            inOutStockItem.ApprovedQuantity = inOutStockItem.RequestQuantity;
                                        }
                                    }
                                }
                                break;
                            case InOutStatusType.ReceivedOutStock: // Xuất kho (Nhập kho thì trừ đi tồn kho ở kho xuất (chỉ trừ tồn kho vì khả dụng đã trừ lúc tạo phiếu))
                                {
                                    if (!cancelStockIn)
                                    {
                                        var ItemIds = input.InOutStockItems.Select(s => s.ItemId).ToList();
                                        if (ItemIds != null && ItemIds.Count > 0)
                                        {
                                            var ItemStockOuts = _dbContext.ItemStocks.Where(w => w.StockId == input.ExpStockId && ItemIds.Contains(w.ItemId)).ToList();
                                            foreach (var ItemStock in ItemStockOuts)
                                            {
                                                var inOutStockItem = input.InOutStockItems.FirstOrDefault(f => f.ItemId == ItemStock.ItemId);
                                                if (inOutStockItem != null)
                                                {
                                                    ItemStock.Quantity -= inOutStockItem.ApprovedQuantity.GetValueOrDefault();
                                                }
                                            }
                                        }
                                    }
                                }
                                break;
                            case InOutStatusType.ReceivedInStock: // Nhập kho
                                {
                                    var ItemIds = input.InOutStockItems.Select(s => s.ItemId).ToList();
                                    if (ItemIds != null && ItemIds.Count > 0)
                                    {
                                        var ItemStockOlds = _dbContext.ItemStocks.Where(w => ItemIds.Contains(w.ItemId) && w.StockId == inOutStock.ImpStockId).ToList();

                                        foreach (var dImMestItemDto in input.InOutStockItems)
                                        {
                                            // Nếu tồn tại thuốc trong kho thì cộng thêm vào tồn và khả dụng
                                            var ItemStock = ItemStockOlds?.FirstOrDefault(f => f.ItemId == dImMestItemDto.ItemId);
                                            if (ItemStock != null)
                                            {
                                                ItemStock.ModifiedBy = SessionExtensions.Login?.Id;
                                                ItemStock.ModifiedDate = dateNow;

                                                ItemStock.AvailableQuantity += dImMestItemDto.ApprovedQuantity.GetValueOrDefault();
                                                ItemStock.Quantity += dImMestItemDto.ApprovedQuantity.GetValueOrDefault();
                                            }
                                            else // Nếu chưa tồn tại thuốc trong kho thì thêm mới thuốc vào kho
                                            {
                                                ItemStocks.Add(new EntityFrameworkCore.Entities.Business.ItemStock()
                                                {
                                                    Id = Guid.NewGuid(),
                                                    CreatedDate = dateNow,
                                                    CreatedBy = SessionExtensions.Login?.Id,
                                                    AvailableQuantity = dImMestItemDto.ApprovedQuantity.GetValueOrDefault(),
                                                    Quantity = dImMestItemDto.ApprovedQuantity.GetValueOrDefault(),
                                                    StockId = input.ImpStockId,
                                                    ItemId = dImMestItemDto.ItemId
                                                });
                                            }
                                        }
                                    }
                                }
                                break;
                            default:
                                break;
                        }

                        _mapper.Map(input, inOutStock);
                        inOutStock.ModifiedDate = dateNow;
                        inOutStock.ModifiedBy = SessionExtensions.Login?.Id;
                    }

                    // Trừ khả dụng kho xuất
                    var ItemIdOuts = input.InOutStockItems.Select(s => s.ItemId).ToList();
                    if (ItemIdOuts != null && ItemIdOuts.Count > 0)
                    {
                        var ItemStockOuts = _dbContext.ItemStocks.Where(w => w.StockId == input.ExpStockId && ItemIdOuts.Contains(w.ItemId)).ToList();
                        foreach (var ItemStock in ItemStockOuts)
                        {
                            var inOutStockItem = input.InOutStockItems.FirstOrDefault(f => f.ItemId == ItemStock.ItemId);
                            if (inOutStockItem != null)
                            {
                                ItemStock.AvailableQuantity -= inOutStockItem.ApprovedQuantity.GetValueOrDefault();
                            }
                        }
                    }

                    switch (input.Status)
                    {
                        case InOutStatusType.Canceled:
                            {
                                inOutStock.Status = InOutStatusType.Canceled;
                                inOutStock.DeletedDate = dateNow;
                                inOutStock.DeletedBy = SessionExtensions.Login?.Id;
                                inOutStock.IsDeleted = true;
                            }
                            break;
                        case InOutStatusType.New:
                            {
                                inOutStock.ApproverTime = null;
                                inOutStock.ApproverUserId = null;

                                inOutStock.StockImpTime = null;
                                inOutStock.StockExpUserId = null;

                                inOutStock.StockExpTime = null;
                                inOutStock.StockExpUserId = null;
                            }
                            break;
                        case InOutStatusType.Request:
                            {
                                inOutStock.ApproverTime = null;
                                inOutStock.ApproverUserId = null;

                                inOutStock.StockImpTime = null;
                                inOutStock.StockExpUserId = null;

                                inOutStock.StockExpTime = null;
                                inOutStock.StockExpUserId = null;
                            }
                            break;
                        case InOutStatusType.Approved:
                            {
                                inOutStock.Status = InOutStatusType.Approved;
                                inOutStock.ApproverTime = dateNow;
                                inOutStock.ApproverUserId = SessionExtensions.Login?.Id;

                                inOutStock.StockImpTime = null;
                                inOutStock.StockExpUserId = null;

                                inOutStock.StockExpTime = null;
                                inOutStock.StockExpUserId = null;

                                // Hủy xuất kho thì cộng lại tồn kho xuất
                                if (canCelStockOut)
                                {
                                    var ItemIds = input.InOutStockItems.Select(s => s.ItemId).ToList();
                                    if (ItemIds != null && ItemIds.Count > 0)
                                    {
                                        var ItemStockOuts = _dbContext.ItemStocks.Where(w => w.StockId == input.ExpStockId && ItemIds.Contains(w.ItemId)).ToList();
                                        foreach (var ItemStock in ItemStockOuts)
                                        {
                                            var inOutStockItem = input.InOutStockItems.FirstOrDefault(f => f.ItemId == ItemStock.ItemId);
                                            if (inOutStockItem != null)
                                            {
                                                ItemStock.Quantity += inOutStockItem.ApprovedQuantity.GetValueOrDefault();
                                                //ItemStock.AvailableQuantity += inOutStockItem.ApprovedQuantity.GetValueOrDefault(); Không cần trừ khả dụng vì đã cộng trên rồi
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                        case InOutStatusType.ReceivedOutStock:
                            {
                                inOutStock.Status = InOutStatusType.ReceivedOutStock;
                                inOutStock.StockExpTime = dateNow;
                                inOutStock.StockExpUserId = SessionExtensions.Login?.Id;

                                inOutStock.StockImpTime = null;
                                inOutStock.StockExpUserId = null;

                                // Hủy nhập kho thì trừ đi SL đã nhập
                                if (cancelStockIn)
                                {
                                    var ItemIds = input.InOutStockItems.Select(s => s.ItemId).ToList();
                                    if (ItemIds != null && ItemIds.Count > 0)
                                    {
                                        var ItemStockIns = _dbContext.ItemStocks.Where(w => ItemIds.Contains(w.ItemId) && w.StockId == inOutStock.ImpStockId).ToList();
                                        foreach (var ItemStock in ItemStockIns)
                                        {
                                            var inOutStockItem = input.InOutStockItems.FirstOrDefault(f => f.ItemId == ItemStock.ItemId);
                                            if (inOutStockItem != null)
                                            {
                                                ItemStock.Quantity -= inOutStockItem.ApprovedQuantity.GetValueOrDefault();
                                                ItemStock.AvailableQuantity -= inOutStockItem.ApprovedQuantity.GetValueOrDefault();
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                        case InOutStatusType.ReceivedInStock:
                            {
                                inOutStock.Status = InOutStatusType.ReceivedInStock;
                                inOutStock.StockImpTime = dateNow;
                                inOutStock.StockExpUserId = SessionExtensions.Login?.Id;
                            }
                            break;
                    }

                    _dbContext.InOutStockItems.AddRange(inOutStockItems);
                    _dbContext.ItemStocks.AddRange(ItemStocks);

                    _dbContext.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;
                }
                finally
                {
                    transaction.Dispose();
                }
            }

            return await Task.FromResult(result);
        }

        private async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockValid(InOutStockDto input)
        {
            var result = new ApiResult<InOutStockDto>();

            try
            {
                var erros = new List<string>();

                var erroMasters = new List<string>();

                if (GuidHelper.IsNullOrEmpty(input.ImpStockId))
                    erroMasters.Add("Kho nhập");
                if (GuidHelper.IsNullOrEmpty(input.ExpStockId))
                    erroMasters.Add("Kho Xuất");
                if (DatetimeHelper.IsNullOrEmpty(input.ReqTime))
                    erroMasters.Add("Ngày lập");
                if (GuidHelper.IsNullOrEmpty(input.CreationUserId))
                    erroMasters.Add("Người lập");

                if (erroMasters.Count > 0)
                    erros.Add(string.Format("{0} không được bỏ trống!", string.Join(", ", erroMasters)));

                if (input.InOutStockItems == null && input.InOutStockItems.Count == 0)
                    erros.Add("Không có thuốc nào được chọn trong danh sách!");

                foreach (var detail in input.InOutStockItems)
                {
                    var erroItems = new List<string>();

                    if (detail.RequestQuantity == 0)
                        erroItems.Add("Số lượng");
                    if (DatetimeHelper.IsNullOrEmpty(detail.DueDate))
                        erroItems.Add("Hạn dùng");

                    if (erroItems.Count > 0)
                    {
                        var erro = string.Format("Mã thuốc {0}: {1} không được để trống!", detail.Code, string.Join(", ", erroItems));
                        erros.Add(erro);
                    }
                }

                // Ktra SL tồn, khả dụng có đủ để xuất ko
                var ItemIds = input.InOutStockItems.Select(s => s.ItemId).ToList();
                if (ItemIds != null && ItemIds.Count > 0)
                {
                    var ItemStocks = _dbContext.ItemStocks.Where(w => ItemIds.Contains(w.ItemId) && w.StockId == input.ExpStockId).ToList();
                    if (ItemStocks != null)
                    {
                        foreach (var item in input.InOutStockItems)
                        {
                            var ItemStock = ItemStocks.FirstOrDefault(f => f.ItemId == item.ItemId);
                            if (ItemStock != null)
                            {
                                if (item.RequestQuantity > ItemStock.AvailableQuantity)
                                {
                                    erros.Add(string.Format("Mã thuốc [{0}]: Số lượng nhập phải nhỏ hơn số lượng tồn kho!", item.Code));
                                }
                            }
                            else
                            {
                                erros.Add(string.Format("Mã thuốc [{0}] không tồn tại trong kho!", item.Code));
                            }
                        }
                    }
                }

                if (erros.Count > 0)
                {
                    result.Message = string.Join(", ", erros);
                    result.IsSuccessed = false;
                }
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }
        #endregion
    }
}
