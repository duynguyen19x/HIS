using HIS.Core.Domain.Entities;
using HIS.EntityFrameworkCore.Constants.Dictionary;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Loại phiếu
    /// </summary>
    [Table("SOrderType")]
    public class OrderType : Entity<int>
    {
        [StringLength(OrderTypeConst.MaxOrderTypeCodeLength, MinimumLength = OrderTypeConst.MinOrderTypeCodeLength)]
        public string OrderTypeCode { get; set; }

        [StringLength(OrderTypeConst.MaxOrderTypeNameLength, MinimumLength = OrderTypeConst.MinOrderTypeNameLength)]
        public string OrderTypeName { get; set; }

        public bool Inactive { get; set; }

        public OrderType() { }

        public OrderType(int id, string code, string name)
        {
            Id = id;
            OrderTypeCode = code;
            OrderTypeName = name;
        }
    }
}
