using HIS.Dtos.Commons;
using HIS.EntityFrameworkCore.DbContexts;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService
{
    public abstract class BaseSerivce<T, U> : IBaseService<T, U>
        where T : class
        where U : class
    {
        public readonly HIS_DbContext _dbContext;
        public readonly IConfiguration _config;

        public BaseSerivce(HIS_DbContext dbContext, IConfiguration config)
        {
            _dbContext = dbContext;
            _config = config;
        }

        public virtual Task<ApiResultList<T>> GetAll(U input)
        {
            throw new NotImplementedException();
        }

        public virtual Task<ApiResult<T>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<ApiResult<T>> CreateOrEdit(T input)
        {
            throw new NotImplementedException();
        }

        public virtual Task<ApiResult<T>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
