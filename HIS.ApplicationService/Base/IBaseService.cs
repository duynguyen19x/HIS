using HIS.Dtos.Commons;
using HIS.Dtos.Systems.Role;
using HIS.Models.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService
{
    public interface IBaseService<T, U>
        where T : class
        where U : class
    {
        Task<ApiResultList<T>> GetAll(U input);
        Task<ApiResult<T>> GetById(Guid id);
        Task<ApiResult<T>> CreateOrEdit(T input);
        Task<ApiResult<T>> Delete(Guid id);
    }
}
