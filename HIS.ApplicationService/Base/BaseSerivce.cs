using AutoMapper;
using HIS.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

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

        public BaseSerivce(HISDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
    }
}
