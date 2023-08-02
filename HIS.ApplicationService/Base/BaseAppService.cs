using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Base
{
    public abstract class BaseAppService
    {
        public IMapper ObjectMapper { get; set; }

        public BaseAppService() 
        {
            ObjectMapper = AutoMappers.ObjectMapper.Mapper;
        }
    }
}
