﻿using AutoMapper;
using HIS.Core.Linq;
using HIS.Dtos.Business.InOutStockItems;
using HIS.Dtos.Business.InOutStocks;
using HIS.Dtos.Business.ItemStocks;
using HIS.Dtos.Dictionaries.ItemPricePolicies;
using HIS.EntityFrameworkCore.Entities.Business;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Categories.Items;
using HIS.EntityFrameworkCore;
using HIS.Utilities.Enums;
using HIS.Utilities.Helpers;
using HIS.Utilities.Sections;
using Microsoft.Extensions.Configuration;
using System.Globalization;
using HIS.Core.Enums;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;

namespace HIS.ApplicationService.Business.Pharmaceuticals.InOutStocks
{
    public class InOutStockService : BaseAppService, IInOutStockService
    {
        public InOutStockService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
            : base(dbContext, mapper) { }

        public async Task<PagedResultDto<InOutStockDto>> GetByStocks(Guid stockId, string fromDate, string toDate)
        {
            var result = new PagedResultDto<InOutStockDto>();

            try
            {
                DateTime fromDateTime = DateTime.ParseExact(fromDate, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None);
                DateTime toDateTime = DateTime.ParseExact(toDate, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None);

                result.Result = (from inOutStock in Context.InOutStocks

                                 join imStock in Context.Rooms on inOutStock.ImpStockId equals imStock.Id into imStockDefaults
                                 from imStockDefault in imStockDefaults.DefaultIfEmpty()

                                 join exStock in Context.Rooms on inOutStock.ExpStockId equals exStock.Id into exStockDefaults
                                 from exStockDefault in exStockDefaults.DefaultIfEmpty()

                                 join inOutStockType in Context.InOutStockTypes on inOutStock.InOutStockTypeId equals inOutStockType.Id into inOutStockTypeDefaults
                                 from inOutStockTypeDefault in inOutStockTypeDefaults.DefaultIfEmpty()

                                 select new InOutStockDto()
                                 {
                                     Id = inOutStock.Id,
                                     Code = inOutStock.Code,
                                     Type = inOutStock.Type,
                                     Status = inOutStock.Status,
                                     ImpStockId = inOutStock.ImpStockId,
                                     ImpStockCode = imStockDefault != null ? imStockDefault.RoomCode : null,
                                     ImpStockName = imStockDefault != null ? imStockDefault.RoomName : null,
                                     ExpStockId = inOutStock.ExpStockId,
                                     ExpStockCode = exStockDefault != null ? exStockDefault.RoomCode : null,
                                     ExpStockName = exStockDefault != null ? exStockDefault.RoomName : null,
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
                result.IsSucceeded = false;
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
        public async Task<ResultDto<InOutStockDto>> ImportFromSupplierGetById(Guid id)
        {
            var result = new ResultDto<InOutStockDto>();

            try
            {
                var inOutStockDto = ObjectMapper.Map<InOutStockDto>(Context.InOutStocks.FirstOrDefault(d => d.Id == id));
                if (inOutStockDto != null)
                {
                    // Nhập thuốc NCC
                    if (inOutStockDto.InOutStockTypeId == 1)
                    {
                        var inOutStockItemDtos = ObjectMapper.Map<IList<InOutStockItemDto>>(Context.InOutStockItems.Where(w => w.InOutStockId == id).ToList());
                        var ItemIds = inOutStockItemDtos.Select(s => s.ItemId).ToList();
                        var ItemDtos = ObjectMapper.Map<IList<Item>>(Context.Items.Where(w => ItemIds.Contains(w.Id)).ToList());

                        var ItemPricePolicyDtos = (from med in Context.ItemPricePolicies
                                                   join pa in Context.PatientTypes on med.PatientTypeId equals pa.Id
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
                                                       PatientTypeCode = pa.PatientTypeCode,
                                                       PatientTypeName = pa.PatientTypeName,
                                                       IsHeIn = med.PatientTypeId == (int)PatientTypes.BHYT ? true : false,
                                                   }).WhereIf(ItemIds != null, w => ItemIds.Contains(w.ItemId))
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
                            inOutStockItem.CommodityType = sItem.CommodityType;

                            inOutStockItem.ItemPricePolicies = itemPricePolicyDtos.Where(w => w.ItemId == inOutStockItem.ItemId).ToList();
                        }

                        inOutStockDto.InOutStockItems = inOutStockItemDtos;
                    }
                }

                result.Result = inOutStockDto;
            }
            catch (Exception ex)
            {
                result.IsSucceeded = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        /// <summary>
        /// Hủy nhập kho
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ResultDto<InOutStockDto>> ImportFromSupplierCanceled(InOutStockDto input)
        {
            var result = new ResultDto<InOutStockDto>();

            try
            {
                var timeNow = DateTime.Now;
                var inOutStocks = Context.InOutStocks.FirstOrDefault(w => w.Id == input.Id);

                // Nhập thuốc từ nhà cung cấp
                if (inOutStocks.InOutStockTypeId == 1)
                {
                    var ItemOlds = (from inOutStock in Context.InOutStocks
                                    join inOutStockItem in Context.InOutStockItems on inOutStock.Id equals inOutStockItem.InOutStockId
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
                        var ItemStocks = Context.ItemStocks.Where(w => stockId.Contains(w.StockId) && medicinIds.Contains(w.ItemId)).ToList();

                        // Ktra số lượng đã bị xuất nhập chưa để hủy phiếu
                        bool anyExists = ItemStocks.Any(record => ItemOlds.Any(r => r.ApprovedQuantity < record.AvailableQuantity));
                        if (anyExists)
                        {
                            result.Message = "Bạn không thể hủy nhập kho khi phiếu thuốc đã được sử dụng!";
                            result.IsSucceeded = false;
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

                        Context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        /// <summary>
        /// Lưu phiếu tạm
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ResultDto<InOutStockDto>> ImportFromSupplierSaveAsDraft(InOutStockDto input)
        {
            return await ImportFromSupplier(input);
        }

        /// <summary>
        /// Nhập kho
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ResultDto<InOutStockDto>> ImportFromSupplierStockIn(InOutStockDto input)
        {
            input.Status = InOutStatusType.ReceivedInStock;
            return await ImportFromSupplier(input);
        }

        /// <summary>
        /// Hủy phiếu (xóa phiếu)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ResultDto<bool>> ImportFromSupplierDeleted(Guid id)
        {
            var result = new ResultDto<bool>();

            using (var transaction = Context.BeginTransaction())
            {
                try
                {
                    var timeNow = DateTime.Now;

                    var inOutStock = Context.InOutStocks.FirstOrDefault(f => f.Id == id);
                    if (inOutStock != null)
                    {
                        inOutStock.Status = InOutStatusType.Canceled;
                        inOutStock.DeletedBy = SessionExtensions.Login?.Id;
                        inOutStock.DeletedDate = timeNow;
                        inOutStock.IsDeleted = true;

                        var inOutStockItems = Context.InOutStockItems.Where(w => w.InOutStockId == id).ToList();
                        if (inOutStockItems != null)
                        {
                            var ItemIds = inOutStockItems.Select(s => s.ItemId).ToList();
                            var Items = Context.Items.Where(w => ItemIds.Contains(w.Id)).ToList();
                            if (Items != null && Items.Count > 0)
                            {
                                foreach (var Item in Items)
                                {
                                    Item.DeletedBy = SessionExtensions.Login?.Id;
                                    Item.DeletedDate = timeNow;
                                    Item.IsDeleted = true;
                                }

                                var ItemPricePolicies = Context.ItemPricePolicies.Where(w => ItemIds.Contains(w.ItemId)).ToList();
                                foreach (var pricePolicy in ItemPricePolicies)
                                {
                                    pricePolicy.DeletedBy = SessionExtensions.Login?.Id;
                                    pricePolicy.DeletedDate = timeNow;
                                    pricePolicy.IsDeleted = true;
                                }
                            }
                        }
                    }

                    Context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
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
        private async Task<ResultDto<InOutStockDto>> ImportFromSupplier(InOutStockDto input)
        {
            var result = new ResultDto<InOutStockDto>();

            result = await ImportFromSupplierValid(input);
            if (!result.IsSucceeded)
            {
                return result;
            }

            using (var transaction = Context.BeginTransaction())
            {
                try
                {
                    var dateNow = DateTime.Now;
                    var id = Guid.NewGuid();
                    input.InOutStockTypeId = (int)Utilities.Enums.InOutStockType.ImportFromSupplier;

                    var inOutStockItems = new List<InOutStockItem>();
                    var items = new List<Item>();
                    var itemStocks = new List<ItemStock>();
                    var itemPricePolicies = new List<ItemPricePolicy>();

                    if (GuidHelper.IsNullOrEmpty(input.Id))
                    {
                        var inOutStock = ObjectMapper.Map<InOutStock>(input);
                        inOutStock.Id = id;
                        inOutStock.CreatedBy = SessionExtensions.Login?.Id;
                        inOutStock.CreatedDate = dateNow;

                        foreach (var inOutStockItemDto in input.InOutStockItems)
                        {
                            inOutStockItemDto.ApprovedQuantity = inOutStockItemDto.RequestQuantity;

                            var item = ObjectMapper.Map<Item>(inOutStockItemDto);
                            if (!GuidHelper.IsNullOrEmpty(inOutStockItemDto.ItemId))
                                item.Id = inOutStockItemDto.ItemId.GetValueOrDefault();
                            else
                                item.Id = Guid.NewGuid();
                            item.CreatedDate = dateNow;
                            item.CreatedBy = SessionExtensions.Login?.Id;
                            item.ImpQuantity = inOutStockItemDto.RequestQuantity;

                            var inOutStockItem = ObjectMapper.Map<InOutStockItem>(inOutStockItemDto);
                            inOutStockItem.Id = Guid.NewGuid();
                            inOutStockItem.InOutStockId = id;
                            inOutStockItem.ItemId = item.Id;

                            if (inOutStockItemDto.ItemPricePolicies != null)
                            {
                                foreach (var sItemPricePolicyDto in inOutStockItemDto.ItemPricePolicies)
                                {
                                    var sItemPricePolicy = ObjectMapper.Map<ItemPricePolicy>(sItemPricePolicyDto);

                                    if (GuidHelper.IsNullOrEmpty(sItemPricePolicy.Id))
                                        sItemPricePolicy.Id = Guid.NewGuid();

                                    sItemPricePolicy.CreatedDate = dateNow;
                                    sItemPricePolicy.CreatedBy = SessionExtensions.Login?.Id;
                                    sItemPricePolicy.ItemId = item.Id;

                                    itemPricePolicies.Add(sItemPricePolicy);
                                }
                            }

                            // Trạng thái nhập kho mới thêm vào thuốc trong kho
                            if (input.Status == InOutStatusType.ReceivedInStock)
                            {
                                inOutStock.ApproverTime = dateNow;
                                inOutStock.ApproverUserId = SessionExtensions.Login?.Id;
                                inOutStock.StockImpTime = dateNow;
                                inOutStock.StockImpUserId = SessionExtensions.Login?.Id;

                                itemStocks.Add(new ItemStock()
                                {
                                    Id = Guid.NewGuid(),
                                    CreatedDate = dateNow,
                                    CreatedBy = SessionExtensions.Login?.Id,
                                    AvailableQuantity = inOutStockItemDto.ApprovedQuantity.GetValueOrDefault(),
                                    Quantity = inOutStockItemDto.ApprovedQuantity.GetValueOrDefault(),
                                    StockId = input.ImpStockId,
                                    ItemId = item.Id
                                });
                            }

                            items.Add(item);
                            inOutStockItems.Add(inOutStockItem);
                        }

                        if (items.Count > 0)
                        {
                            var ItemTypeIds = items.Select(s => s.ItemTypeId).ToList();
                            var ItemTypes = Context.ItemTypes.Where(w => ItemTypeIds.Contains(w.Id)).ToList();
                            if (ItemTypes != null && ItemTypes.Count > 0)
                            {
                                foreach (var Item in items)
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

                        Context.InOutStocks.Add(inOutStock);
                    }
                    else
                    {
                        var dImMestOld = Context.InOutStocks.FirstOrDefault(d => d.Id == input.Id);

                        // Xóa bản ghi cũ
                        var inOutStockItemOlds = Context.InOutStockItems.Where(s => s.InOutStockId == input.Id).ToList();
                        var itemOldIds = inOutStockItemOlds.Select(s => s.ItemId).ToList();
                        var itemOlds = Context.Items.Where(w => itemOldIds.Contains(w.Id)).ToList();
                        var itemStockOlds = Context.ItemStocks.Where(w => itemOldIds.Contains(w.ItemId) && w.StockId == dImMestOld.ImpStockId).ToList();
                        var itemPricePolicyOlds = Context.ItemPricePolicies.Where(w => itemOldIds.Contains(w.ItemId)).ToList();

                        if (inOutStockItemOlds != null && itemOlds != null)
                        {
                            Context.ItemPricePolicies.RemoveRange(itemPricePolicyOlds);
                            Context.ItemStocks.RemoveRange(itemStockOlds);
                            Context.InOutStockItems.RemoveRange(inOutStockItemOlds);
                            Context.Items.RemoveRange(itemOlds);

                            // Chưa biết nguyên nhân: Khi xóa bản ghi cũ và thêm bản ghi mới lại update khóa ngoại về NULL
                            Context.SaveChanges();
                        }

                        foreach (var inOutStockItemDto in input.InOutStockItems)
                        {
                            inOutStockItemDto.ApprovedQuantity = inOutStockItemDto.RequestQuantity;

                            var item = ObjectMapper.Map<Item>(inOutStockItemDto);
                            if (!GuidHelper.IsNullOrEmpty(inOutStockItemDto.ItemId))
                            {
                                item.Id = inOutStockItemDto.ItemId.GetValueOrDefault();
                                var ItemOld = itemOlds.FirstOrDefault(f => f.Id == item.Id);
                                if (ItemOld != null)
                                    item.Code = ItemOld.Code;
                            }
                            else
                            {
                                item.Id = Guid.NewGuid();

                                var ItemType = Context.ItemTypes.FirstOrDefault(f => f.Id == item.ItemTypeId);
                                if (ItemType != null)
                                {
                                    ItemType.AutoNumber += 1;
                                    item.Code = string.Format("{0}.{1}", ItemType.Code, ItemType.AutoNumber);
                                }
                            }
                            item.CreatedDate = dImMestOld.CreatedDate;
                            item.CreatedBy = dImMestOld.CreatedBy;
                            item.ModifiedDate = dateNow;
                            item.ModifiedBy = SessionExtensions.Login?.Id;
                            item.ImpQuantity = inOutStockItemDto.RequestQuantity;

                            var inOutStockItem = ObjectMapper.Map<InOutStockItem>(inOutStockItemDto);
                            if (GuidHelper.IsNullOrEmpty(inOutStockItem.Id))
                                inOutStockItem.Id = Guid.NewGuid();

                            inOutStockItem.ItemId = item.Id;
                            inOutStockItem.InOutStockId = input.Id;

                            if (inOutStockItemDto.ItemPricePolicies != null)
                            {
                                foreach (var sItemPricePolicyDto in inOutStockItemDto.ItemPricePolicies)
                                {
                                    var sItemPricePolicy = ObjectMapper.Map<ItemPricePolicy>(sItemPricePolicyDto);

                                    if (GuidHelper.IsNullOrEmpty(sItemPricePolicy.Id))
                                        sItemPricePolicy.Id = Guid.NewGuid();

                                    sItemPricePolicy.CreatedDate = dImMestOld.CreatedDate;
                                    sItemPricePolicy.CreatedBy = dImMestOld.CreatedBy;
                                    sItemPricePolicy.ModifiedDate = dateNow;
                                    sItemPricePolicy.ModifiedBy = SessionExtensions.Login?.Id;
                                    sItemPricePolicy.ItemId = item.Id;

                                    itemPricePolicies.Add(sItemPricePolicy);
                                }
                            }

                            // Trạng thái nhập kho mới thêm vào thuốc trong kho
                            if (input.Status == InOutStatusType.ReceivedInStock)
                            {
                                input.ApproverTime = dateNow;
                                input.ApproverUserId = SessionExtensions.Login?.Id;
                                input.StockImpTime = dateNow;
                                input.StockImpUserId = SessionExtensions.Login?.Id;

                                itemStocks.Add(new ItemStock()
                                {
                                    Id = Guid.NewGuid(),
                                    CreatedDate = dateNow,
                                    CreatedBy = SessionExtensions.Login?.Id,
                                    AvailableQuantity = inOutStockItemDto.ApprovedQuantity.GetValueOrDefault(),
                                    Quantity = inOutStockItemDto.ApprovedQuantity.GetValueOrDefault(),
                                    StockId = input.ImpStockId,
                                    ItemId = item.Id,
                                });
                            }

                            items.Add(item);
                            inOutStockItems.Add(inOutStockItem);
                        }

                        ObjectMapper.Map(input, dImMestOld);
                        dImMestOld.ModifiedDate = dateNow;
                        dImMestOld.ModifiedBy = SessionExtensions.Login?.Id;
                    }

                    Context.Items.AddRange(items);
                    Context.InOutStockItems.AddRange(inOutStockItems);
                    Context.ItemStocks.AddRange(itemStocks);
                    Context.ItemPricePolicies.AddRange(itemPricePolicies);

                    Context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSucceeded = false;
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
        private async Task<ResultDto<InOutStockDto>> ImportFromSupplierValid(InOutStockDto input)
        {
            var result = new ResultDto<InOutStockDto>();

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
                    var any = Context.InOutStocks.Any(a => a.Id != input.Id && a.Code == input.Code);
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
                    result.IsSucceeded = false;
                }
            }
            catch (Exception ex)
            {
                result.IsSucceeded = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }
        #endregion

        #region Nhập từ kho khác
        /// <summary>
        /// Lấy phiếu nhập từ kho khác
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockGetById(Guid id)
        {
            var result = new ResultDto<InOutStockDto>();

            try
            {
                var inOutStockDto = ObjectMapper.Map<InOutStockDto>(Context.InOutStocks.FirstOrDefault(d => d.Id == id));
                if (inOutStockDto != null)
                {
                    if (inOutStockDto.InOutStockTypeId == (int)Utilities.Enums.InOutStockType.ImportFromAnotherStock)
                    {
                        var inOutStockItemDtos = (from inOutStockItem in Context.InOutStockItems

                                                  join item in Context.Items on inOutStockItem.ItemId equals item.Id into itemDefaults
                                                  from itemDefault in itemDefaults.DefaultIfEmpty()

                                                  join itemType in Context.ItemTypes on inOutStockItem.ItemTypeId equals itemType.Id into itemTypeDefaults
                                                  from itemTypeDefault in itemTypeDefaults.DefaultIfEmpty()

                                                  where inOutStockItem.InOutStockId == id

                                                  select new InOutStockItemDto()
                                                  {
                                                      Id = inOutStockItem.Id,
                                                      Code = itemDefault == null ? (itemTypeDefault == null ? null : itemTypeDefault.Code) : itemDefault.Code,
                                                      HeInCode = itemTypeDefault == null ? null : itemTypeDefault.HeInCode,
                                                      Name = itemTypeDefault == null ? null : itemTypeDefault.Name,
                                                      ItemId = inOutStockItem.ItemId,
                                                      SortOrder = inOutStockItem.SortOrder,
                                                      ItemLineId = itemTypeDefault == null ? null : itemTypeDefault.ItemLineId,
                                                      ItemGroupId = itemTypeDefault == null ? null : itemTypeDefault.ItemGroupId,
                                                      ItemTypeId = inOutStockItem.ItemTypeId,
                                                      UnitId = itemTypeDefault == null ? null : itemTypeDefault.UnitId,
                                                      Tutorial = itemDefault == null ? null : itemDefault.Tutorial,
                                                      CountryId = itemDefault == null ? null : itemDefault.CountryId,
                                                      ImpPrice = itemDefault == null ? (itemTypeDefault == null ? null : itemTypeDefault.ImpPrice) : itemDefault.ImpPrice,
                                                      RequestQuantity = inOutStockItem.RequestQuantity,
                                                      ApprovedQuantity = inOutStockItem.ApprovedQuantity,
                                                      ImpVatRate = itemDefault == null ? null : itemDefault.ImpVatRate,
                                                      ImpTaxRate = itemDefault == null ? null : itemDefault.ImpTaxRate,
                                                      Description = itemDefault == null ? null : itemDefault.Description,
                                                      ActiveSubstance = itemDefault == null ? null : itemDefault.ActiveSubstance,
                                                      Concentration = itemDefault == null ? null : itemDefault.Concentration,
                                                      Content = itemDefault == null ? null : itemDefault.Content,
                                                      Manufacturer = itemDefault == null ? null : itemDefault.Manufacturer,
                                                      PackagingSpecifications = itemDefault == null ? null : itemDefault.PackagingSpecifications,
                                                      Dosage = itemDefault == null ? null : itemDefault.Dosage,
                                                      Lot = itemDefault == null ? null : itemDefault.Lot,
                                                      DueDate = itemDefault == null ? null : itemDefault.DueDate,
                                                      TenderDecision = itemDefault == null ? null : itemDefault.TenderDecision,
                                                      TenderPackage = itemDefault == null ? null : itemDefault.TenderPackage,
                                                      TenderGroup = itemDefault == null ? null : itemDefault.TenderGroup,
                                                      TenderYear = itemDefault == null ? null : itemDefault.TenderYear,
                                                      CommodityType = itemTypeDefault == null ? CommodityTypes.Medicine : itemTypeDefault.CommodityType,
                                                  }).OrderBy(o => o.SortOrder).ToList();

                        switch (inOutStockDto.Status)
                        {
                            case InOutStatusType.New:
                                {
                                    inOutStockItemDtos = inOutStockItemDtos.GroupBy(g => new
                                    {
                                        g.HeInCode,
                                        g.CommodityType,
                                        g.ItemTypeId,
                                        g.ItemLineId,
                                        g.ItemGroupId,
                                        g.UnitId,
                                    }).Select(s => new InOutStockItemDto()
                                    {
                                        HeInCode = s.Key.HeInCode,
                                        CommodityType = s.Key.CommodityType,
                                        ItemTypeId = s.Key.ItemTypeId,
                                        ItemLineId = s.Key.ItemLineId,
                                        ItemGroupId = s.Key.ItemGroupId,
                                        UnitId = s.Key.UnitId,

                                        ItemId = s.Max(m => m.ItemId),
                                        Code = s.Max(m => m.Code),
                                        Name = s.Max(m => m.Name),
                                        CountryId = s.FirstOrDefault().CountryId,
                                        Tutorial = s.FirstOrDefault().Tutorial,
                                        ImpPrice = s.FirstOrDefault().ImpPrice,
                                        RequestQuantity = s.Sum(o => o.RequestQuantity.GetValueOrDefault()),
                                        ApprovedQuantity = s.Sum(o => o.ApprovedQuantity.GetValueOrDefault()),
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
                                        SortOrder = s.Min(s => s.SortOrder),
                                    }).ToList();
                                }
                                break;
                        }

                        inOutStockDto.InOutStockItems = inOutStockItemDtos;
                    }
                }

                result.Result = inOutStockDto;
            }
            catch (Exception ex)
            {
                result.IsSucceeded = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        /// <summary>
        /// Lưu phiếu tạm
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockSaveAsDraft(InOutStockDto input)
        {
            input.Status = InOutStatusType.New;
            return await ImportFromAnotherStocks(input);
        }

        /// <summary>
        /// Gửi yêu cầu
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockRequest(InOutStockDto input)
        {
            input.Status = InOutStatusType.Request;
            return await ImportFromAnotherStocks(input);
        }

        /// <summary>
        /// Hủy yêu cầu
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockCancelRequest(InOutStockDto input)
        {
            input.Status = InOutStatusType.Request;
            return await ImportFromAnotherStockCancels(input);
        }

        /// <summary>
        /// Duyệt phiếu
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockApproved(InOutStockDto input)
        {
            input.Status = InOutStatusType.Approved;
            return await ImportFromAnotherStocks(input);
        }

        /// <summary>
        /// Hủy duyệt phiếu
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockCancelApproved(InOutStockDto input)
        {
            input.Status = InOutStatusType.Approved;
            return await ImportFromAnotherStockCancels(input);
        }

        /// <summary>
        /// Xuất kho
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockStockOut(InOutStockDto input)
        {
            input.Status = InOutStatusType.ReceivedOutStock;
            return await ImportFromAnotherStocks(input);
        }

        /// <summary>
        /// Hủy xuất kho
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockCanCelStockOut(InOutStockDto input)
        {
            input.Status = InOutStatusType.ReceivedOutStock;
            return await ImportFromAnotherStockCancels(input);
        }

        /// <summary>
        /// Nhập kho
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockStockIn(InOutStockDto input)
        {
            input.Status = InOutStatusType.ReceivedInStock;
            return await ImportFromAnotherStocks(input);
        }

        /// <summary>
        /// Hủy nhập kho
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockCancelStockIn(InOutStockDto input)
        {
            input.Status = InOutStatusType.ReceivedInStock;
            return await ImportFromAnotherStockCancels(input);
        }

        /// <summary>
        /// Hủy phiếu (xóa phiếu)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ResultDto<bool>> ImportFromAnotherStockDeleted(Guid id)
        {
            var result = new ResultDto<bool>();

            using (var transaction = Context.BeginTransaction())
            {
                try
                {
                    var timeNow = DateTime.Now;

                    var inOutStock = Context.InOutStocks.FirstOrDefault(f => f.Id == id);
                    if (inOutStock != null)
                    {
                        inOutStock.Status = InOutStatusType.Canceled;
                        inOutStock.DeletedBy = SessionExtensions.Login?.Id;
                        inOutStock.DeletedDate = timeNow;
                        inOutStock.IsDeleted = true;
                    }

                    Context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSucceeded = false;
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
        /// Kiểm tra dữ liệu trước khi lưu
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockValid(InOutStockDto input)
        {
            var result = new ResultDto<InOutStockDto>();

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

                if (input.Status == InOutStatusType.Request)
                {
                    // Ktra SL tồn, khả dụng có đủ để xuất ko
                    var itemIds = input.InOutStockItems.Select(s => s.ItemId).ToList();
                    if (itemIds != null && itemIds.Count > 0)
                    {
                        var itemStocks = Context.ItemStocks.Where(w => itemIds.Contains(w.ItemId) && w.StockId == input.ExpStockId).ToList();
                        if (itemStocks != null)
                        {
                            foreach (var item in input.InOutStockItems)
                            {
                                var itemStock = itemStocks.FirstOrDefault(f => f.ItemId == item.ItemId);
                                if (itemStock != null)
                                {
                                    if (item.RequestQuantity > itemStock.AvailableQuantity)
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
                }

                if (erros.Count > 0)
                {
                    result.Message = string.Join(", ", erros);
                    result.IsSucceeded = false;
                }
            }
            catch (Exception ex)
            {
                result.IsSucceeded = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        /// <summary>
        /// Nhập thuốc từ kho khác
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private async Task<ResultDto<InOutStockDto>> ImportFromAnotherStocks(InOutStockDto input)
        {
            var result = new ResultDto<InOutStockDto>();

            result = await ImportFromAnotherStockValid(input);
            if (!result.IsSucceeded)
            {
                return result;
            }

            using (var transaction = Context.BeginTransaction())
            {
                var dateNow = DateTime.Now;
                var id = Guid.Empty;

                input.InOutStockTypeId = (int)Utilities.Enums.InOutStockType.ImportFromAnotherStock;

                try
                {
                    if (GuidHelper.IsNullOrEmpty(input.Id)) // Thêm mới chí có 2 trạng thái là Lưu tạm và Gửi yêu cầu
                    {
                        var inOutStockItems = new List<InOutStockItem>();

                        var inOutStock = ObjectMapper.Map<InOutStock>(input);
                        inOutStock.Id = Guid.NewGuid();
                        id = inOutStock.Id;

                        switch (input.Status)
                        {
                            case InOutStatusType.New:
                                {
                                    foreach (var inOutStockItemDto in input.InOutStockItems)
                                    {
                                        var inOutStockItem = ObjectMapper.Map<InOutStockItem>(inOutStockItemDto);
                                        inOutStockItem.Id = Guid.NewGuid();
                                        inOutStockItem.InOutStockId = inOutStock.Id;

                                        inOutStockItems.Add(inOutStockItem);
                                    }
                                }
                                break;
                            case InOutStatusType.Request:
                                {
                                    var itemTypeIds = input.InOutStockItems.Select(x => x.ItemTypeId).ToList();

                                    #region Chi tiết phiếu nhập xuất
                                    var itemStockDtos = (from itemStock in Context.ItemStocks
                                                         join item in Context.Items on itemStock.ItemId equals item.Id

                                                         where itemStock.IsDeleted == false
                                                           && item.IsDeleted == false
                                                           && itemStock.AvailableQuantity > 0

                                                         select new ItemStockDto()
                                                         {
                                                             Id = itemStock.Id,
                                                             StockId = itemStock.StockId,
                                                             ItemId = itemStock.ItemId,
                                                             Code = item.Code,
                                                             AvailableQuantity = itemStock.AvailableQuantity,
                                                             Quantity = itemStock.Quantity,
                                                             ItemTypeId = item.ItemTypeId,
                                                             ItemCode = item.Code,
                                                             ImpPrice = item.ImpPrice,
                                                             ImpVatRate = item.ImpVatRate,
                                                             ImpTaxRate = item.ImpTaxRate,
                                                             DueDate = item.DueDate,
                                                         }).WhereIf(itemTypeIds != null && itemTypeIds.Count > 0, w => itemTypeIds.Contains(w.ItemTypeId)).OrderBy(o => o.DueDate).ThenBy(t => t.Code).ToList();

                                    foreach (var inOutStockItemDto in input.InOutStockItems)
                                    {
                                        var itemStockByItemTypes = itemStockDtos.Where(w => w.ItemTypeId == inOutStockItemDto.ItemTypeId).ToList();
                                        if (itemStockByItemTypes != null && itemStockByItemTypes.Count() > 0)
                                        {
                                            int index = 0;

                                            foreach (var itemStock in itemStockByItemTypes)
                                            {
                                                var inOutStockItem = new InOutStockItem()
                                                {
                                                    Id = Guid.NewGuid(),
                                                    InOutStockId = inOutStock.Id,
                                                    SortOrder = index,
                                                    ItemTypeId = inOutStockItemDto.ItemTypeId
                                                };

                                                /* 
                                                 * Kiểm tra xem số lượng yêu cầu có lớn hơn hoặc bằng số lượng khả dụng của thuốc theo lô hay không
                                                 * 1: Nếu lớn hơn hoặc bằng thì tạo 1 dòng xuất thuốc
                                                 * 2: Nhỏ hơn thì lấy số lượng của lô thuốc tiếp theo => Kiểm tra theo bước 1 => khi nào đủ số lượng xuất hoặc hết thuốc thì thôi
                                                */
                                                if (itemStock.AvailableQuantity >= inOutStockItemDto.RequestQuantity)
                                                {
                                                    inOutStockItem.ItemId = itemStock.ItemId;
                                                    inOutStockItem.ImpPrice = itemStock.ImpPrice;
                                                    inOutStockItem.ImpVatRate = itemStock.ImpVatRate;
                                                    inOutStockItem.ImpTaxRate = itemStock.ImpTaxRate;
                                                    inOutStockItem.RequestQuantity = inOutStockItemDto.RequestQuantity;
                                                    inOutStockItem.ApprovedQuantity = inOutStockItemDto.RequestQuantity;
                                                }
                                                else
                                                {
                                                    inOutStockItem.ItemId = itemStock.ItemId;
                                                    inOutStockItem.ImpPrice = itemStock.ImpPrice;
                                                    inOutStockItem.ImpVatRate = itemStock.ImpVatRate;
                                                    inOutStockItem.ImpTaxRate = itemStock.ImpTaxRate;
                                                    if (index < itemStockByItemTypes.Count - 1)
                                                        inOutStockItem.RequestQuantity = itemStock.AvailableQuantity;
                                                    else
                                                        inOutStockItem.RequestQuantity = inOutStockItemDto.RequestQuantity;
                                                    inOutStockItem.ApprovedQuantity = itemStock.AvailableQuantity;
                                                }

                                                inOutStockItemDto.RequestQuantity -= inOutStockItem.ApprovedQuantity;
                                                index += 1;

                                                inOutStockItems.Add(inOutStockItem);
                                            }
                                        }
                                    }
                                    #endregion

                                    #region Trừ khả dụng kho xuất
                                    var itemIds = inOutStockItems.Select(s => s.ItemId).ToList();
                                    var itemStocks = Context.ItemStocks.Where(w => w.StockId == input.ExpStockId && itemIds.Contains(w.ItemId)).ToList();

                                    foreach (var itemStock in itemStocks)
                                    {
                                        var item = inOutStockItems.FirstOrDefault(f => f.ItemId == itemStock.ItemId);
                                        if (item != null)
                                            itemStock.AvailableQuantity -= item.ApprovedQuantity.GetValueOrDefault();
                                    }
                                    #endregion
                                }
                                break;
                        }

                        Context.InOutStocks.Add(inOutStock);
                        Context.InOutStockItems.AddRange(inOutStockItems);
                    }
                    else
                    {
                        var inOutStockItems = new List<InOutStockItem>();
                        var inOutStock = Context.InOutStocks.FirstOrDefault(d => d.Id == input.Id);
                        id = inOutStock.Id;

                        switch (input.Status)
                        {
                            case InOutStatusType.New:
                                {
                                    input.Status = InOutStatusType.New;

                                    // Xóa bản ghi cũ
                                    var inOutStockItemOlds = Context.InOutStockItems.Where(s => s.InOutStockId == input.Id).ToList();
                                    if (inOutStockItemOlds != null)
                                        Context.InOutStockItems.RemoveRange(inOutStockItemOlds);

                                    foreach (var inOutStockItemDto in input.InOutStockItems)
                                    {
                                        var inOutStockItem = ObjectMapper.Map<InOutStockItem>(inOutStockItemDto);
                                        inOutStockItem.Id = Guid.NewGuid();
                                        inOutStockItem.InOutStockId = inOutStock.Id;

                                        inOutStockItems.Add(inOutStockItem);
                                    }
                                }
                                break;
                            case InOutStatusType.Request:
                                {
                                    input.Status = InOutStatusType.Request;

                                    var itemTypeIds = input.InOutStockItems.Select(x => x.ItemTypeId).ToList();

                                    // Xóa bản ghi cũ
                                    var inOutStockItemOlds = Context.InOutStockItems.Where(s => s.InOutStockId == input.Id).ToList();
                                    if (inOutStockItemOlds != null)
                                        Context.InOutStockItems.RemoveRange(inOutStockItemOlds);

                                    #region Chi tiết phiếu nhập xuất
                                    var itemStockDtos = (from itemStock in Context.ItemStocks
                                                         join item in Context.Items on itemStock.ItemId equals item.Id

                                                         where itemStock.IsDeleted == false
                                                           && item.IsDeleted == false
                                                           && itemStock.AvailableQuantity > 0

                                                         select new ItemStockDto()
                                                         {
                                                             Id = itemStock.Id,
                                                             StockId = itemStock.StockId,
                                                             ItemId = itemStock.ItemId,
                                                             Code = item.Code,
                                                             AvailableQuantity = itemStock.AvailableQuantity,
                                                             Quantity = itemStock.Quantity,
                                                             ItemTypeId = item.ItemTypeId,
                                                             ItemCode = item.Code,
                                                             ImpPrice = item.ImpPrice,
                                                             ImpVatRate = item.ImpVatRate,
                                                             ImpTaxRate = item.ImpTaxRate,
                                                             DueDate = item.DueDate,
                                                         }).WhereIf(itemTypeIds != null && itemTypeIds.Count > 0, w => itemTypeIds.Contains(w.ItemTypeId)).OrderBy(o => o.DueDate).ThenBy(t => t.Code).ToList();

                                    foreach (var inOutStockItemDto in input.InOutStockItems)
                                    {
                                        var itemStockByItemTypes = itemStockDtos.Where(w => w.ItemTypeId == inOutStockItemDto.ItemTypeId).ToList();
                                        if (itemStockByItemTypes != null && itemStockByItemTypes.Count() > 0)
                                        {
                                            int index = 0;

                                            foreach (var itemStock in itemStockByItemTypes)
                                            {
                                                var inOutStockItem = new InOutStockItem()
                                                {
                                                    Id = Guid.NewGuid(),
                                                    InOutStockId = inOutStock.Id,
                                                    SortOrder = index,
                                                    ItemTypeId = inOutStockItemDto.ItemTypeId
                                                };

                                                /* 
                                                 * Kiểm tra xem số lượng yêu cầu có lớn hơn hoặc bằng số lượng khả dụng của thuốc theo lô hay không
                                                 * 1: Nếu lớn hơn hoặc bằng thì tạo 1 dòng xuất thuốc
                                                 * 2: Nhỏ hơn thì lấy số lượng của lô thuốc tiếp theo => Kiểm tra theo bước 1 => khi nào đủ số lượng xuất hoặc hết thuốc thì thôi
                                                */
                                                if (itemStock.AvailableQuantity >= inOutStockItemDto.RequestQuantity)
                                                {
                                                    inOutStockItem.ItemId = itemStock.ItemId;
                                                    inOutStockItem.ImpPrice = itemStock.ImpPrice;
                                                    inOutStockItem.ImpVatRate = itemStock.ImpVatRate;
                                                    inOutStockItem.ImpTaxRate = itemStock.ImpTaxRate;
                                                    inOutStockItem.RequestQuantity = inOutStockItemDto.RequestQuantity;
                                                    inOutStockItem.ApprovedQuantity = inOutStockItemDto.RequestQuantity;
                                                }
                                                else
                                                {
                                                    inOutStockItem.ItemId = itemStock.ItemId;
                                                    inOutStockItem.ImpPrice = itemStock.ImpPrice;
                                                    inOutStockItem.ImpVatRate = itemStock.ImpVatRate;
                                                    inOutStockItem.ImpTaxRate = itemStock.ImpTaxRate;
                                                    if (index < itemStockByItemTypes.Count - 1)
                                                        inOutStockItem.RequestQuantity = itemStock.AvailableQuantity;
                                                    else
                                                        inOutStockItem.RequestQuantity = inOutStockItemDto.RequestQuantity;
                                                    inOutStockItem.ApprovedQuantity = itemStock.AvailableQuantity;
                                                }

                                                inOutStockItemDto.RequestQuantity -= inOutStockItem.ApprovedQuantity;
                                                index += 1;

                                                inOutStockItems.Add(inOutStockItem);
                                            }
                                        }
                                    }
                                    #endregion

                                    #region Trừ khả dụng kho xuất
                                    var itemIds = inOutStockItems.Select(s => s.ItemId).ToList();
                                    var itemStocks = Context.ItemStocks.Where(w => w.StockId == input.ExpStockId && itemIds.Contains(w.ItemId)).ToList();

                                    foreach (var itemStock in itemStocks)
                                    {
                                        var item = inOutStockItems.FirstOrDefault(f => f.ItemId == itemStock.ItemId);
                                        if (item != null)
                                            itemStock.AvailableQuantity -= item.ApprovedQuantity.GetValueOrDefault();
                                    }
                                    #endregion
                                }
                                break;
                            case InOutStatusType.Approved:
                                {
                                    input.ApproverTime = dateNow;
                                    input.ApproverUserId = SessionExtensions.Login?.Id;
                                    input.Status = InOutStatusType.Approved;
                                }
                                break;
                            case InOutStatusType.ReceivedOutStock:
                                {
                                    input.StockExpTime = dateNow;
                                    input.StockExpUserId = SessionExtensions.Login?.Id;
                                    input.Status = InOutStatusType.ReceivedOutStock;

                                    #region Trừ tồn kho của kho xuất khi xuất kho
                                    var itemIds = input.InOutStockItems.Select(s => s.ItemId).ToList();
                                    var itemStocks = Context.ItemStocks.Where(w => w.StockId == input.ExpStockId && itemIds.Contains(w.ItemId)).ToList();
                                    if (itemStocks != null && itemStocks.Count > 0)
                                    {
                                        foreach (var item in itemStocks)
                                        {
                                            var inOutStockItem = input.InOutStockItems.FirstOrDefault(f => f.ItemId == item.ItemId);
                                            if (inOutStockItem != null)
                                            {
                                                item.Quantity -= inOutStockItem.ApprovedQuantity.GetValueOrDefault();
                                            }
                                        }
                                    }
                                    #endregion
                                }
                                break;
                            case InOutStatusType.ReceivedInStock:
                                {
                                    input.StockImpTime = dateNow;
                                    input.StockImpUserId = SessionExtensions.Login?.Id;
                                    input.Status = InOutStatusType.ReceivedInStock;

                                    #region Cộng tồn kho của kho nhập
                                    var itemIds = input.InOutStockItems.Select(s => s.ItemId).ToList();
                                    var itemStocks = Context.ItemStocks.Where(w => w.StockId == input.ImpStockId && itemIds.Contains(w.ItemId)).ToList();
                                    if (itemStocks != null)
                                    {
                                        var itemStockNews = new List<ItemStock>();

                                        foreach (var inOutStockItem in input.InOutStockItems)
                                        {
                                            var item = itemStocks.FirstOrDefault(f => f.ItemId == inOutStockItem.ItemId);
                                            if (item != null)
                                            {
                                                item.Quantity += inOutStockItem.ApprovedQuantity.GetValueOrDefault();
                                                item.AvailableQuantity += inOutStockItem.ApprovedQuantity.GetValueOrDefault();
                                            }
                                            else
                                            {
                                                itemStockNews.Add(new ItemStock()
                                                {
                                                    Id = Guid.NewGuid(),
                                                    StockId = input.ImpStockId,
                                                    ItemId = inOutStockItem.ItemId,
                                                    Quantity = inOutStockItem.ApprovedQuantity.GetValueOrDefault(),
                                                    AvailableQuantity = inOutStockItem.ApprovedQuantity.GetValueOrDefault(),
                                                });
                                            }
                                        }

                                        if (itemStockNews.Count > 0)
                                        {
                                            Context.AddRange(itemStockNews);
                                        }
                                    }
                                    #endregion
                                }
                                break;
                        }

                        ObjectMapper.Map(input, inOutStock);
                        Context.AddRange(inOutStockItems);

                        inOutStock.ModifiedDate = dateNow;
                        inOutStock.ModifiedBy = SessionExtensions.Login?.Id;
                    }

                    Context.SaveChanges();

                    if (!GuidHelper.IsNullOrEmpty(id))
                    {
                        result.Result = (await ImportFromAnotherStockGetById(id)).Result;
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSucceeded = false;
                    result.Message = ex.Message;
                    transaction.Rollback();
                }
                finally { transaction.Dispose(); }
            }

            return await Task.FromResult(result);
        }

        /// <summary>
        /// Hủy yêu cầu, duyệt, xuất, nhập 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockCancels(InOutStockDto input)
        {
            var result = new ResultDto<InOutStockDto>();

            using (var transaction = Context.BeginTransaction())
            {
                input.InOutStockTypeId = (int)Utilities.Enums.InOutStockType.ImportFromAnotherStock;

                try
                {
                    var inOutStock = Context.InOutStocks.FirstOrDefault(f => f.Id == input.Id);
                    if (inOutStock != null)
                    {
                        switch (input.Status)
                        {
                            case InOutStatusType.Request:
                                {
                                    input.Status = InOutStatusType.New;
                                    input.ApproverTime = null;
                                    input.ApproverUserId = null;
                                    input.StockImpTime = null;
                                    input.StockExpUserId = null;
                                    input.StockExpTime = null;
                                    input.StockExpUserId = null;

                                    var inOutStockItems = Context.InOutStockItems.Where(w => w.InOutStockId == input.Id).ToList();
                                    if (inOutStockItems != null && inOutStockItems.Count > 0)
                                    {
                                        var itemIds = inOutStockItems.Select(s => s.ItemId).ToList();
                                        var itemStocks = Context.ItemStocks.Where(w => w.StockId == inOutStock.ExpStockId && itemIds.Contains(w.ItemId)).ToList();

                                        foreach (var item in itemStocks)
                                        {
                                            var inOutStockItem = inOutStockItems.FirstOrDefault(f => f.ItemId == item.ItemId);
                                            if (inOutStockItem != null)
                                            {
                                                item.AvailableQuantity += inOutStockItem.ApprovedQuantity.GetValueOrDefault();
                                            }
                                        }
                                    }
                                }
                                break;
                            case InOutStatusType.Approved:
                                {
                                    input.Status = InOutStatusType.Request;
                                    input.ApproverTime = null;
                                    input.ApproverUserId = null;
                                    input.StockImpTime = null;
                                    input.StockExpUserId = null;
                                    input.StockExpTime = null;
                                    input.StockExpUserId = null;
                                }
                                break;
                            case InOutStatusType.ReceivedOutStock:
                                {
                                    input.Status = InOutStatusType.Approved;
                                    input.StockExpTime = null;
                                    input.StockExpUserId = null;

                                    var inOutStockItems = Context.InOutStockItems.Where(w => w.InOutStockId == input.Id).ToList();
                                    if (inOutStockItems != null && inOutStockItems.Count > 0)
                                    {
                                        var itemIds = inOutStockItems.Select(s => s.ItemId).ToList();
                                        var itemStocks = Context.ItemStocks.Where(w => w.StockId == inOutStock.ExpStockId && itemIds.Contains(w.ItemId)).ToList();

                                        foreach (var item in itemStocks)
                                        {
                                            var inOutStockItem = inOutStockItems.FirstOrDefault(f => f.ItemId == item.ItemId);
                                            if (inOutStockItem != null)
                                            {
                                                //item.AvailableQuantity += inOutStockItem.ApprovedQuantity.GetValueOrDefault();
                                                item.Quantity += inOutStockItem.ApprovedQuantity.GetValueOrDefault();
                                            }
                                        }
                                    }
                                }
                                break;
                            case InOutStatusType.ReceivedInStock:
                                {
                                    input.Status = InOutStatusType.ReceivedOutStock;
                                    input.StockImpTime = null;
                                    input.StockImpUserId = null;

                                    var inOutStockItems = Context.InOutStockItems.Where(w => w.InOutStockId == input.Id).ToList();
                                    if (inOutStockItems != null && inOutStockItems.Count > 0)
                                    {
                                        var itemIds = inOutStockItems.Select(s => s.ItemId).ToList();
                                        var itemStocks = Context.ItemStocks.Where(w => w.StockId == inOutStock.ImpStockId && itemIds.Contains(w.ItemId)).ToList();

                                        foreach (var item in itemStocks)
                                        {
                                            var inOutStockItem = inOutStockItems.FirstOrDefault(f => f.ItemId == item.ItemId);
                                            if (inOutStockItem != null)
                                            {
                                                item.AvailableQuantity -= inOutStockItem.ApprovedQuantity.GetValueOrDefault();
                                                item.Quantity -= inOutStockItem.ApprovedQuantity.GetValueOrDefault();
                                            }
                                        }
                                    }
                                }
                                break;
                        }

                        ObjectMapper.Map(input, inOutStock);
                    }
                    else
                    {
                        result.IsSucceeded = false;
                        result.Message = $"Không tìm thấy phiếu [{input.Code}]. Xin vui lòng kiểm tra lại!";
                    }

                    Context.SaveChanges();

                    if (result.IsSucceeded)
                    {
                        result.Result = (await ImportFromAnotherStockGetById(input.Id.GetValueOrDefault())).Result;
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSucceeded = false;
                    result.Message = ex.Message;
                    transaction.Rollback();
                }
                finally { transaction.Dispose(); }
            }

            return await Task.FromResult(result);
        }
        #endregion

        #region Xuất trả nhà cung cấp

        /// <summary>
        /// Lấy phiếu xuất trả nhà cung cấp
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ApiResult<InOutStockDto>> ExportToSupplierGetById(Guid id)
        {
            var result = new ApiResult<InOutStockDto>();

            try
            {
                var inOutStockDto = _mapper.Map<InOutStockDto>(_dbContext.InOutStocks.FirstOrDefault(d => d.Id == id));
                if (inOutStockDto != null)
                {
                    if (inOutStockDto.InOutStockTypeId == (int)Utilities.Enums.InOutStockType.ExportFormSupplier)
                    {
                        var inOutStockItemDtos = (from inOutStockItem in _dbContext.InOutStockItems

                                                  join item in _dbContext.Items on inOutStockItem.ItemId equals item.Id into itemDefaults
                                                  from itemDefault in itemDefaults.DefaultIfEmpty()

                                                  join itemType in _dbContext.ItemTypes on inOutStockItem.ItemTypeId equals itemType.Id into itemTypeDefaults
                                                  from itemTypeDefault in itemTypeDefaults.DefaultIfEmpty()

                                                  where inOutStockItem.InOutStockId == id

                                                  select new InOutStockItemDto()
                                                  {
                                                      Id = inOutStockItem.Id,
                                                      Code = itemDefault == null ? (itemTypeDefault == null ? null : itemTypeDefault.Code) : itemDefault.Code,
                                                      HeInCode = itemTypeDefault == null ? null : itemTypeDefault.HeInCode,
                                                      Name = itemTypeDefault == null ? null : itemTypeDefault.Name,
                                                      ItemId = inOutStockItem.ItemId,
                                                      SortOrder = inOutStockItem.SortOrder,
                                                      ItemLineId = itemTypeDefault == null ? null : itemTypeDefault.ItemLineId,
                                                      ItemGroupId = itemTypeDefault == null ? null : itemTypeDefault.ItemGroupId,
                                                      ItemTypeId = inOutStockItem.ItemTypeId,
                                                      UnitId = itemTypeDefault == null ? null : itemTypeDefault.UnitId,
                                                      Tutorial = itemDefault == null ? null : itemDefault.Tutorial,
                                                      CountryId = itemDefault == null ? null : itemDefault.CountryId,
                                                      ImpPrice = itemDefault == null ? (itemTypeDefault == null ? null : itemTypeDefault.ImpPrice) : itemDefault.ImpPrice,
                                                      RequestQuantity = inOutStockItem.RequestQuantity,
                                                      ApprovedQuantity = inOutStockItem.ApprovedQuantity,
                                                      ImpVatRate = itemDefault == null ? null : itemDefault.ImpVatRate,
                                                      ImpTaxRate = itemDefault == null ? null : itemDefault.ImpTaxRate,
                                                      Description = itemDefault == null ? null : itemDefault.Description,
                                                      ActiveSubstance = itemDefault == null ? null : itemDefault.ActiveSubstance,
                                                      Concentration = itemDefault == null ? null : itemDefault.Concentration,
                                                      Content = itemDefault == null ? null : itemDefault.Content,
                                                      Manufacturer = itemDefault == null ? null : itemDefault.Manufacturer,
                                                      PackagingSpecifications = itemDefault == null ? null : itemDefault.PackagingSpecifications,
                                                      Dosage = itemDefault == null ? null : itemDefault.Dosage,
                                                      Lot = itemDefault == null ? null : itemDefault.Lot,
                                                      DueDate = itemDefault == null ? null : itemDefault.DueDate,
                                                      TenderDecision = itemDefault == null ? null : itemDefault.TenderDecision,
                                                      TenderPackage = itemDefault == null ? null : itemDefault.TenderPackage,
                                                      TenderGroup = itemDefault == null ? null : itemDefault.TenderGroup,
                                                      TenderYear = itemDefault == null ? null : itemDefault.TenderYear,
                                                      CommodityType = itemTypeDefault == null ? CommodityTypes.Medicine : itemTypeDefault.CommodityType,
                                                  }).OrderBy(o => o.SortOrder).ToList();

                        switch (inOutStockDto.Status)
                        {
                            case InOutStatusType.New:
                                {
                                    inOutStockItemDtos = inOutStockItemDtos.GroupBy(g => new
                                    {
                                        g.HeInCode,
                                        g.CommodityType,
                                        g.ItemTypeId,
                                        g.ItemLineId,
                                        g.ItemGroupId,
                                        g.UnitId,
                                    }).Select(s => new InOutStockItemDto()
                                    {
                                        HeInCode = s.Key.HeInCode,
                                        CommodityType = s.Key.CommodityType,
                                        ItemTypeId = s.Key.ItemTypeId,
                                        ItemLineId = s.Key.ItemLineId,
                                        ItemGroupId = s.Key.ItemGroupId,
                                        UnitId = s.Key.UnitId,

                                        ItemId = s.Max(m => m.ItemId),
                                        Code = s.Max(m => m.Code),
                                        Name = s.Max(m => m.Name),
                                        CountryId = s.FirstOrDefault().CountryId,
                                        Tutorial = s.FirstOrDefault().Tutorial,
                                        ImpPrice = s.FirstOrDefault().ImpPrice,
                                        RequestQuantity = s.Sum(o => o.RequestQuantity.GetValueOrDefault()),
                                        ApprovedQuantity = s.Sum(o => o.ApprovedQuantity.GetValueOrDefault()),
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
                                        SortOrder = s.Min(s => s.SortOrder),
                                    }).ToList();
                                }
                                break;
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
        /// Lưu tạm phiếu xuất trả ncc
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResult<InOutStockDto>> ExportToSupplierSaveAsDraft(InOutStockDto input)
        {
            input.Status = InOutStatusType.New;
            return await ExportToSupplier(input);
        }

        public async Task<ApiResult<InOutStockDto>> ExportToSupplierStockOut(InOutStockDto input)
        {
            input.Status = InOutStatusType.ReceivedOutStock;
            return await ExportToSupplier(input);
        }

        /// <summary>
        /// Lưu phiếu xuất kho trả nhà cung cấp
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResult<InOutStockDto>> ExportToSupplierCanCelStockOut(InOutStockDto input)
        {
            var result = new ApiResult<InOutStockDto>();

            using (var transaction = _dbContext.BeginTransaction())
            {
                input.InOutStockTypeId = (int)Utilities.Enums.InOutStockType.ImportFromAnotherStock;

                try
                {
                    var inOutStock = _dbContext.InOutStocks.FirstOrDefault(f => f.Id == input.Id);
                    if (inOutStock != null)
                    {
                        switch (input.Status)
                        {
                            case InOutStatusType.ReceivedOutStock:
                                {
                                    input.Status = InOutStatusType.New;
                                    input.ApproverTime = null;
                                    input.ApproverUserId = null;
                                    input.StockImpTime = null;
                                    input.StockExpUserId = null;
                                    input.StockExpTime = null;
                                    input.StockExpUserId = null;

                                    var inOutStockItems = _dbContext.InOutStockItems.Where(w => w.InOutStockId == input.Id).ToList();
                                    if (inOutStockItems != null && inOutStockItems.Count > 0)
                                    {
                                        var itemIds = inOutStockItems.Select(s => s.ItemId).ToList();
                                        var itemStocks = _dbContext.ItemStocks.Where(w => w.StockId == inOutStock.ExpStockId && itemIds.Contains(w.ItemId)).ToList();

                                        foreach (var item in itemStocks)
                                        {
                                            var inOutStockItem = inOutStockItems.FirstOrDefault(f => f.ItemId == item.ItemId);
                                            if (inOutStockItem != null)
                                            {
                                                item.AvailableQuantity += inOutStockItem.ApprovedQuantity.GetValueOrDefault();
                                                item.Quantity += inOutStockItem.ApprovedQuantity.GetValueOrDefault();
                                            }
                                        }
                                    }
                                }
                                break;
                        }

                        _mapper.Map(input, inOutStock);
                    }
                    else
                    {
                        result.IsSuccessed = false;
                        result.Message = $"Không tìm thấy phiếu [{input.Code}]. Xin vui lòng kiểm tra lại!";
                    }

                    _dbContext.SaveChanges();

                    if (result.IsSuccessed)
                    {
                        result.Result = (await ImportFromAnotherStockGetById(input.Id.GetValueOrDefault())).Result;
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;

                    transaction.Rollback();
                }
                finally { transaction.Dispose(); }
            }

            return await Task.FromResult(result);
        }

        /// <summary>
        /// Hủy phiếu (xóa phiếu)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ApiResult<bool>> ExportToSupplierDeleted(Guid id)
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

        private async Task<ApiResult<InOutStockDto>> ExportToSupplier(InOutStockDto input)
        {
            var result = new ApiResult<InOutStockDto>();

            result = await ExportToSupplierValid(input);
            if (!result.IsSuccessed)
            {
                return result;
            }

            using (var transaction = _dbContext.BeginTransaction())
            {
                try
                {
                    var dateNow = DateTime.Now;
                    var id = Guid.Empty;
                    input.InOutStockTypeId = (int)Utilities.Enums.InOutStockType.ExportFormSupplier;

                    if (GuidHelper.IsNullOrEmpty(input.Id))
                    {
                        var inOutStockItems = new List<InOutStockItem>();

                        var inOutStock = _mapper.Map<InOutStock>(input);
                        inOutStock.Id = Guid.NewGuid();
                        inOutStock.ModifiedDate = dateNow;
                        inOutStock.CreatedBy = SessionExtensions.Login?.Id;
                        id = inOutStock.Id;

                        switch (input.Status)
                        {
                            case InOutStatusType.New:
                                {
                                    foreach (var inOutStockItemDto in input.InOutStockItems)
                                    {
                                        var inOutStockItem = _mapper.Map<InOutStockItem>(inOutStockItemDto);
                                        inOutStockItem.Id = Guid.NewGuid();
                                        inOutStockItem.InOutStockId = inOutStock.Id;

                                        inOutStockItems.Add(inOutStockItem);
                                    }
                                }
                                break;
                        }

                        _dbContext.InOutStocks.Add(inOutStock);
                        _dbContext.InOutStockItems.AddRange(inOutStockItems);
                    }
                    else
                    {
                        var inOutStockItems = new List<InOutStockItem>();
                        var inOutStock = _dbContext.InOutStocks.FirstOrDefault(d => d.Id == input.Id);
                        id = inOutStock.Id;

                        // Xóa bản ghi cũ
                        var inOutStockItemOlds = _dbContext.InOutStockItems.Where(s => s.InOutStockId == input.Id).ToList();
                        if (inOutStockItemOlds != null)
                            _dbContext.InOutStockItems.RemoveRange(inOutStockItemOlds);

                        switch (input.Status)
                        {
                            case InOutStatusType.New:
                                {
                                    foreach (var inOutStockItemDto in input.InOutStockItems)
                                    {
                                        var inOutStockItem = _mapper.Map<InOutStockItem>(inOutStockItemDto);
                                        inOutStockItem.Id = Guid.NewGuid();
                                        inOutStockItem.InOutStockId = inOutStock.Id;

                                        inOutStockItems.Add(inOutStockItem);
                                    }
                                }
                                break;

                            case InOutStatusType.ReceivedOutStock:
                                {
                                    input.ApproverTime = dateNow;
                                    input.ApproverUserId = SessionExtensions.Login?.Id;
                                    input.StockExpTime = dateNow;
                                    input.StockExpUserId = SessionExtensions.Login?.Id;
                                    input.Status = InOutStatusType.ReceivedOutStock;

                                    var itemTypeIds = input.InOutStockItems.Select(x => x.ItemTypeId).ToList();

                                    #region Chi tiết phiếu nhập xuất
                                    var itemStockDtos = (from itemStock in _dbContext.ItemStocks
                                                         join item in _dbContext.Items on itemStock.ItemId equals item.Id

                                                         where itemStock.IsDeleted == false
                                                           && item.IsDeleted == false
                                                           && itemStock.AvailableQuantity > 0

                                                         select new ItemStockDto()
                                                         {
                                                             Id = itemStock.Id,
                                                             StockId = itemStock.StockId,
                                                             ItemId = itemStock.ItemId,
                                                             Code = item.Code,
                                                             AvailableQuantity = itemStock.AvailableQuantity,
                                                             Quantity = itemStock.Quantity,
                                                             ItemTypeId = item.ItemTypeId,
                                                             ItemCode = item.Code,
                                                             ImpPrice = item.ImpPrice,
                                                             ImpVatRate = item.ImpVatRate,
                                                             ImpTaxRate = item.ImpTaxRate,
                                                             DueDate = item.DueDate,
                                                         }).WhereIf(itemTypeIds != null && itemTypeIds.Count > 0, w => itemTypeIds.Contains(w.ItemTypeId)).OrderBy(o => o.DueDate).ThenBy(t => t.Code).ToList();

                                    foreach (var inOutStockItemDto in input.InOutStockItems)
                                    {
                                        var itemStockByItemTypes = itemStockDtos.Where(w => w.ItemTypeId == inOutStockItemDto.ItemTypeId).ToList();
                                        if (itemStockByItemTypes != null && itemStockByItemTypes.Count() > 0)
                                        {
                                            int index = 0;

                                            foreach (var itemStock in itemStockByItemTypes)
                                            {
                                                var inOutStockItem = new InOutStockItem()
                                                {
                                                    Id = Guid.NewGuid(),
                                                    InOutStockId = inOutStock.Id,
                                                    SortOrder = index,
                                                    ItemTypeId = inOutStockItemDto.ItemTypeId
                                                };

                                                /* 
                                                 * Kiểm tra xem số lượng yêu cầu có lớn hơn hoặc bằng số lượng khả dụng của thuốc theo lô hay không
                                                 * 1: Nếu lớn hơn hoặc bằng thì tạo 1 dòng xuất thuốc
                                                 * 2: Nhỏ hơn thì lấy số lượng của lô thuốc tiếp theo => Kiểm tra theo bước 1 => khi nào đủ số lượng xuất hoặc hết thuốc thì thôi
                                                */
                                                if (itemStock.AvailableQuantity >= inOutStockItemDto.RequestQuantity)
                                                {
                                                    inOutStockItem.ItemId = itemStock.ItemId;
                                                    inOutStockItem.ImpPrice = itemStock.ImpPrice;
                                                    inOutStockItem.ImpVatRate = itemStock.ImpVatRate;
                                                    inOutStockItem.ImpTaxRate = itemStock.ImpTaxRate;
                                                    inOutStockItem.RequestQuantity = inOutStockItemDto.RequestQuantity;
                                                    inOutStockItem.ApprovedQuantity = inOutStockItemDto.RequestQuantity;
                                                }
                                                else
                                                {
                                                    inOutStockItem.ItemId = itemStock.ItemId;
                                                    inOutStockItem.ImpPrice = itemStock.ImpPrice;
                                                    inOutStockItem.ImpVatRate = itemStock.ImpVatRate;
                                                    inOutStockItem.ImpTaxRate = itemStock.ImpTaxRate;
                                                    if (index < itemStockByItemTypes.Count - 1)
                                                    {
                                                        inOutStockItem.RequestQuantity = itemStock.AvailableQuantity;
                                                    }
                                                    else
                                                    {
                                                        inOutStockItem.RequestQuantity = inOutStockItemDto.RequestQuantity;
                                                    }
                                                    inOutStockItem.ApprovedQuantity = itemStock.AvailableQuantity;
                                                }

                                                inOutStockItemDto.RequestQuantity -= inOutStockItem.ApprovedQuantity;
                                                index += 1;

                                                inOutStockItems.Add(inOutStockItem);
                                            }
                                        }
                                    }
                                    #endregion

                                    #region Trừ khả dụng và tồn kho của kho xuất 
                                    var itemIds = inOutStockItems.Select(s => s.ItemId).ToList();
                                    var itemStocks = _dbContext.ItemStocks.Where(w => w.StockId == input.ExpStockId && itemIds.Contains(w.ItemId)).ToList();

                                    foreach (var itemStock in itemStocks)
                                    {
                                        var item = inOutStockItems.FirstOrDefault(f => f.ItemId == itemStock.ItemId);
                                        if (item != null)
                                        {
                                            itemStock.AvailableQuantity -= item.ApprovedQuantity.GetValueOrDefault();
                                            itemStock.Quantity -= item.ApprovedQuantity.GetValueOrDefault();
                                        }
                                    }
                                    #endregion
                                }
                                break;
                        }

                        _mapper.Map(input, inOutStock);
                        _dbContext.AddRange(inOutStockItems);

                        inOutStock.ModifiedDate = dateNow;
                        inOutStock.ModifiedBy = SessionExtensions.Login?.Id;
                    }

                    _dbContext.SaveChanges();
                    transaction.Commit();

                    if (!GuidHelper.IsNullOrEmpty(id))
                    {
                        result.Result = (await ExportToSupplierGetById(id)).Result;
                    }
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

        private async Task<ApiResult<InOutStockDto>> ExportToSupplierValid(InOutStockDto input)
        {
            var result = new ApiResult<InOutStockDto>();

            try
            {
                var erros = new List<string>();

                var erroMasters = new List<string>();

                if (GuidHelper.IsNullOrEmpty(input.ExpStockId))
                    erroMasters.Add("Kho Xuất");
                if (DatetimeHelper.IsNullOrEmpty(input.ReqTime))
                    erroMasters.Add("Ngày lập");
                if (DatetimeHelper.IsNullOrEmpty(input.InvTime))
                    erroMasters.Add("Ngày hóa đơn");
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

                if (input.Status == InOutStatusType.ReceivedOutStock)
                {
                    // Ktra SL tồn, khả dụng có đủ để xuất ko
                    var itemIds = input.InOutStockItems.Select(s => s.ItemId).ToList();
                    if (itemIds != null && itemIds.Count > 0)
                    {
                        var itemStocks = _dbContext.ItemStocks.Where(w => itemIds.Contains(w.ItemId) && w.StockId == input.ExpStockId).ToList();
                        if (itemStocks != null)
                        {
                            foreach (var item in input.InOutStockItems)
                            {
                                var itemStock = itemStocks.FirstOrDefault(f => f.ItemId == item.ItemId);
                                if (itemStock != null)
                                {
                                    if (item.RequestQuantity > itemStock.AvailableQuantity)
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

