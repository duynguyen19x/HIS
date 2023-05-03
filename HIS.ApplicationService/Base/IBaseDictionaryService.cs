using HIS.Models.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Base
{
    public interface IBaseDictionaryService<T, U> : IBaseService<T, U>
        where T : class
        where U : class
    {
        //Task<ApiResult<T>> CheckCodeExists();
    }
}
