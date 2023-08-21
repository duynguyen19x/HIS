﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Utilities.Enums
{
    public enum ImpExpMestType
    {
        /// <summary>
        /// Nhập từ NCC
        /// </summary>
        ImportMedicineFromSupplier = 1,
        /// <summary>
        /// Xuất trả NCC
        /// </summary>
        ExportMedicineFormSupplier,
        /// <summary>
        /// Nhập từ kho khác
        /// </summary>
        ImportFromAnotherStock,
        /// <summary>
        /// Xuất trả kho khác
        /// </summary>
        ExportFromAnotherStock,
        /// <summary>
        /// Nhập bù
        /// </summary>
        Replenish,
        /// <summary>
        /// Xuất thanh lý
        /// </summary>
        Liquidate,
        /// <summary>
        /// Xuất kiểm nghiệm
        /// </summary>
        ReleaseForTesting,
        /// <summary>
        /// Xuất hủy
        /// </summary>
        IssueForDisposal,
        /// <summary>
        /// Xuất hao phí phòng khám
        /// </summary>
        DischargeMedicalWaste,
        /// <summary>
        /// Xuất sử dụng phòng
        /// </summary>
        IssueForRoomUse,
        /// <summary>
        /// Xuất sử dụng khoa
        /// </summary>
        IssueForDepartmentUse,
        /// <summary>
        /// Nhập bù cơ số tủ trực
        /// </summary>
        ReplenishCabinetStock,
        /// <summary>
        /// Xuất bù cơ số tủ trực
        /// </summary>
        IssueToReplenishCabinetStock,
        /// <summary>
        /// Bổ sung cơ số tủ trực
        /// </summary>
        AddToCabinetInventory,
        /// <summary>
        /// Hoàn trả cơ số tủ trực
        /// </summary>
        ReturnCabinetStock,
        /// <summary>
        /// Xuất bản cho khách hàng
        /// </summary>
        ReleaseToCustomers,
        /// <summary>
        /// Nhập trả từ khách hàng
        /// </summary>
        ReturnFromCustomer,
        /// <summary>
        /// Nhập VT từ NCC
        /// </summary>
        ImportMaterialFromSupplier,
        /// <summary>
        /// Xuất VT trả NCC
        /// </summary>
        ExportMaterialFormSupplier,
        /// <summary>
        /// Xuất khác
        /// </summary>
        OtherIssue = 99,
    }
}
