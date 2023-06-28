﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Utilities.Enums
{
    public enum ServiceGroupHeInTypes
    {
        [Description("Xét nghiệm")]
        LaboratoryTesting = 1,

        [Description("Chẩn đoán hình ảnh")]
        DiagnosticImaging,

        [Description("Thăm dò chức năng")]
        FunctionalEvaluation,

        [Description("Thuốc trong danh mục BHYT")]
        MedicineHeInList,

        [Description("Thuốc điều trị ung thư, chống thải ghép ngoài danh mục")]
        MedicineOutHeInList,

        [Description("Thuốc thanh toán theo tỷ lệ")]
        MedicinePaymentRate,

        [Description("Máu và chế phẩm máu")]
        Blood,

        [Description("Phẫu thuật")]
        Surgery,

        [Description("DVKT thanh toán theo tỷ lệ")]
        ServicePaymentRate,

        [Description("Vật tư y tế trong danh mục BHYT")]
        MaterialHeInList,

        [Description("VTYT thanh toán theo tỷ lệ")]
        MaterialPaymentRate,

        [Description("Vận chuyển")]
        Transportation,

        [Description("Khám bệnh")]
        MedicalExamination,

        [Description("Giường điều trị ngoại trú")]
        OutpatientBed,

        [Description("Giường điều trị nội trú")]
        InpatientBed,

        [Description("Ngày giường lưu")]
        BedOccupancyDay,

        [Description("Chế phẩm máu")]
        BloodProduct,

        [Description("Thủ thuật")]
        SurgicalIntervention,

        [Description("Vật tư y tế ngoài danh mục BHYT")]
        MaterialOutHeInList,
    }
}
