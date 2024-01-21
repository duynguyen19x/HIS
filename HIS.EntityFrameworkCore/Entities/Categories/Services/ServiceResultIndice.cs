using HIS.Core.Domain.Entities;

namespace HIS.EntityFrameworkCore.Entities.Categories.Services
{
    public class ServiceResultIndice : Entity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public decimal? MaleFrom { get; set; }
        public decimal? MaleTo { get; set; }
        public decimal? FemaleFrom { get; set; }
        public decimal? FemaleTo { get; set; }
        /// <summary>
        /// Giá trị bình thường dùng cho các TH xét nghiệp tự nhập kết quả (Âm tính, dương tính ....)
        /// </summary>
        public string Normal { get; set; }
        public Guid? ServiceId { get; set; }
        public int? SortOrder { get; set; }
        public bool Inactive { get; set; }

        public Service Service { get; set; }
    }
}
