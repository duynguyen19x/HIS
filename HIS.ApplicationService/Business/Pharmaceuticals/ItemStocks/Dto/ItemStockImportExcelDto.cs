using HIS.Dtos.Business.ItemStocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Pharmaceuticals.ItemStocks.Dto
{
    public class ItemStockImportExcelDto : ItemStockDto
    {
        public string PatientTypeCode { get; set; }
        public decimal OldUnitPrice { get; set; }
        public decimal NewUnitPrice { get; set; }
        public decimal PaymentRate { get; set; }
        public decimal CeilingPrice { get; set; }
        public DateTime ExecutionTime { get; set; }

        public object ItemLineCode { get; set; }
        public object ItemGroupCode { get; set; }
        public object ItemTypeCode { get; set; }
        public object UnitCode { get; set; }
        public object CountryCode { get; set; }
    }
}
