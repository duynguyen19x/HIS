using AutoMapper.Configuration.Annotations;
using HIS.Core.Entities;
using HIS.EntityFrameworkCore.Entities.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Tài khoản được phân quyền sử dụng sổ thu, chi.
    /// </summary>
    public class UserAccountBook : Entity
    {
        public virtual Guid UserId { get; set; }
        public virtual Guid AccountBookId { get; set; }

        [Ignore]
        public virtual User User { get; set; }
        [Ignore]
        public virtual AccountBook AccountBook { get; set; }

        public UserAccountBook() { }
    }
}
