using AutoMapper;
using HIS.Dtos.Commons;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService
{
    public abstract class BaseSerivce
    {
        public readonly HISDbContext _dbContext;
        public readonly IMapper _mapper;
        public readonly IConfiguration _config;

        public BaseSerivce(HISDbContext dbContext, IConfiguration config, IMapper mapper)
        {
            _dbContext = dbContext;
            _config = config;
            _mapper = mapper;
        }

        public BaseSerivce(HISDbContext dbContext, IConfiguration config)
        {
            _dbContext = dbContext;
            _config = config;
        }
    }
}
