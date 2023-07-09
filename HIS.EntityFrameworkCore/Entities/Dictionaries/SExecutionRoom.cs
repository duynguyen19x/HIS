using HIS.EntityFrameworkCore.BaseEntitys;
using HIS.EntityFrameworkCore.Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Phòng thực hiện
    /// </summary>
    public class SExecutionRoom : Entity<Guid>
    {
        public Guid? ServiceId { get; set; }
        public Guid? RoomId { get; set; }

        /// <summary>
        /// Đánh dấu phòng thực hiện chính
        /// </summary>
        public bool IsMain { get; set; }

        public SService SService { get; set; }
        public SRoom SRoom { get; set; }
    }
}
