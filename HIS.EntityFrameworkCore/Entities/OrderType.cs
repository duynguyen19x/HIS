using HIS.Core.Domain.Entities;
using HIS.EntityFrameworkCore.Constants;
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
        [Required]
        [StringLength(OrderTypeConst.MaxOrderTypeCodeLength, MinimumLength = OrderTypeConst.MinOrderTypeCodeLength)]
        public string OrderTypeCode { get; set; }

        [Required]
        [StringLength(OrderTypeConst.MaxOrderTypeNameLength, MinimumLength = OrderTypeConst.MinOrderTypeNameLength)]
        public string OrderTypeName { get; set; }

        [StringLength(OrderTypeConst.MaxDescriptionLength, MinimumLength = OrderTypeConst.MinDescriptionLength)]
        public string Description { get; set; }

        public int SortOrder { get; set; }

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
