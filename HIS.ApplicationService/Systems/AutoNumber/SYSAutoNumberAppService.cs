using AutoMapper;
using HIS.Application.Core.Services;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.AutoNumber
{
    public class SYSAutoNumberAppService : BaseAppService, ISYSAutoNumberAppService
    {
        public SYSAutoNumberAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public void Get()
        {

        }

        public void Update() 
        { 

        }
    }
}
